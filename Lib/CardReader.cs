using DnD_NFC.Models;
using PCSC;
using PCSC.Exceptions;
using PCSC.Iso7816;
using PCSC.Monitoring;
using System;
using System.Windows.Forms;

namespace DnD_NFC.Lib
{
    class CardReader
    {
        private ISCardMonitor monitor;
        private Settings settings;
        private ControlPanel cp;
        public string NFCData { get; set; }
        private string readerName;
        private ISCardContext context;

        public CardReader(ControlPanel controlPanel, Settings appSettings)
        {
            settings = appSettings;
            cp = controlPanel;
            InitializeDevice();
        }

        private void InitializeDevice()
        {
            var contextFactory = ContextFactory.Instance;
            using (context = contextFactory.Establish(SCardScope.System))
            {
                var readerNames = context.GetReaders();
                var monitorFactory = MonitorFactory.Instance;
                monitor = monitorFactory.Create(SCardScope.System);

                if (readerNames.Length == 0)
                {
                    cp.Invoke((MethodInvoker)(() => this.cp.DeviceInitialized(true)));
                    return;
                }
                readerName = readerNames[0];

                AttachToAllEvents(monitor);
                Console.WriteLine($"Initializing Reader: {readerNames[0]}");
                monitor.Start(readerNames[0]);
                Console.WriteLine($"Reader Initialized: {readerNames[0]}");
            }
        }

        private void AttachToAllEvents(ISCardMonitor monitor)
        {
            monitor.CardInserted += (sender, args) => CardInserted(sender, args);
            monitor.CardRemoved += (sender, args) => CardRemoved(args);
            monitor.Initialized += (sender, args) => MonitorInitialized(args);
            monitor.StatusChanged += StatusChanged;
            monitor.MonitorException += MonitorException;
        }

        private void CardRemoved(CardStatusEventArgs args)
        {
            Console.WriteLine("Card Removed");
            cp.NFCData = null;
            cp.Invoke((MethodInvoker)(() => this.cp.SetNFCData()));
        }

        private void CardInserted(object sender, CardStatusEventArgs args)
        {
            Console.WriteLine("Card Inserted");
            var hex = BitConverter.ToString(args.Atr ?? new byte[0]);
            cp.NFCData = hex;
            cp.Invoke((MethodInvoker)(() => this.cp.SetNFCData()));
            ReadData();

        }

        private void MonitorInitialized(CardStatusEventArgs args)
        {
            cp.Invoke((MethodInvoker)(() => this.cp.DeviceInitialized(true)));
        }

        private void StatusChanged(object sender, StatusChangeEventArgs args)
        {
            Console.WriteLine($"State Changed: {args.NewState}");
        }

        private void MonitorException(object sender, PCSCException ex)
        {
            Console.WriteLine("Monitor exited due an error:", ex);
            cp.Invoke((MethodInvoker)(() => this.cp.DeviceErrored()));
        }

        public void ReadData()
        {
            var contextFactory = ContextFactory.Instance;
            using (var ctx = contextFactory.Establish(SCardScope.System))
            {
                using (var isoReader = new IsoReader(ctx, readerName, SCardShareMode.Shared, SCardProtocol.Any, false))
                {
                    var updateBinaryCmd = new CommandApdu(IsoCase.Case3Short, SCardProtocol.Any)
                    {
                        CLA = 0xFF,
                        INS = 0xCA,
                        P1 = 0x00,
                        P2 = 0x00
                    };

                    var response = isoReader.Transmit(updateBinaryCmd);
                    Console.WriteLine(response.GetData());
                    Console.WriteLine("SW1 SW2 = {0:X2} {1:X2}", response.SW1, response.SW2);
                }
            }
        }

        private static void PrintCardAtr(byte[] atr)
        {
            if (atr == null || atr.Length <= 0)
            {
                return;
            }

            Console.WriteLine("Card ATR: {0}", BitConverter.ToString(atr));
        }
    }
}

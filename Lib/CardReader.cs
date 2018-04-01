using DnD_NFC.Models;
using PCSC;
using PCSC.Exceptions;
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

        public CardReader(ControlPanel controlPanel, Settings appSettings)
        {
            settings = appSettings;
            cp = controlPanel;
            InitializeDevice();
        }

        private void InitializeDevice()
        {
            var contextFactory = ContextFactory.Instance;
            using (var context = contextFactory.Establish(SCardScope.System))
            {
                var readerNames = context.GetReaders();
                InitializeReader(readerNames);
            }
        }

        private void InitializeReader(string[] readerNames)
        {
            var monitorFactory = MonitorFactory.Instance;
            monitor = monitorFactory.Create(SCardScope.System);

            AttachToAllEvents(monitor);
            foreach (var item in readerNames)
            {
                Console.WriteLine($"Initializing Reader: {item}");
                monitor.Start(item);
                Console.WriteLine($"Reader Initialized: {item}");
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
        }

        private void MonitorInitialized(CardStatusEventArgs args)
        {
            cp.DeviceInitialized(true);
        }

        private void StatusChanged(object sender, StatusChangeEventArgs args)
        {
            Console.WriteLine($"State Changed: {args.NewState}");
        }

        private void MonitorException(object sender, PCSCException ex)
        {
            Console.WriteLine("Monitor exited due an error:", ex);
            cp.DeviceErrored();
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

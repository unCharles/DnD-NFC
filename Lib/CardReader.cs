using DnD_NFC.Models;
using PCSC.Monitoring;
using SpringCard.PCSC;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DnD_NFC.Lib
{
    class CardReader
    {
        private SCardReader reader = null;
        private SCardChannel channel = null;
        private Dictionary<string, string> cardsNames = new Dictionary<string, string>();
        private Dictionary<int, string> protocols = new Dictionary<int, string>();
        private Settings settings;
        private ControlPanel cp;
        public string NFCData { get; set; }

        public CardReader(ControlPanel controlPanel, Settings appSettings)
        {
            settings = appSettings;
            cp = controlPanel;
            LoadProtocols();
            LoadCardsNames();
            InitializeDevice();
        }

        private void InitializeDevice()
        {
            var readers = SCARD.Readers;

            if (readers.Length == 0)
            {
                Console.WriteLine("No Reader Found");
                cp.DeviceErrored();
            }

            try
            {
                reader = new SCardReader(readers[0]);
                reader.StartMonitor(ReaderStatusChanged);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("There was an error while creating the reader's object : " + Ex.Message);
                return;
            }
        }

        private void LoadProtocols()
        {
            protocols.Add(0, "No information given");
            protocols.Add(1, "ISO 14443 A, level 1");
            protocols.Add(2, "ISO 14443 A, level 2");
            protocols.Add(3, "ISO 14443 A, level 3 or 4 (and Mifare)");
            protocols.Add(5, "ISO 14443 B, level 1");
            protocols.Add(6, "ISO 14443 B, level 2");
            protocols.Add(7, "ISO 14443 B, level 3 or 4");
            protocols.Add(9, "ICODE 1");
            protocols.Add(11, "ISO 15693");
        }

        private void LoadCardsNames()
        {
            cardsNames.Add("0001", "NXP Mifare Standard 1k");
            cardsNames.Add("0002", "NXP Mifare Standard 4k");
            cardsNames.Add("0003", "NXP Mifare UltraLight, Other Type 2 NFC Tags(NFC Forum) with a capacity <= 64 bytes");
            cardsNames.Add("0006", "ST Micro Electronics SR176");
            cardsNames.Add("0007", "ST Micro Electronics SRI4K, SRIX4K, SRIX512, SRI512, SRT512");
            cardsNames.Add("000A", "Atmel AT88SC0808CRF");
            cardsNames.Add("000B", "Atmel AT88SC1616CRF");
            cardsNames.Add("000C", "Atmel AT88SC3216CRF");
            cardsNames.Add("000D", "Atmel AT88SC6416CRF");
            cardsNames.Add("0012", "Texas Instruments TAG IT");
            cardsNames.Add("0013", "ST Micro Electronics LRI512");
            cardsNames.Add("0014", "NXP ICODE SLI");
            cardsNames.Add("0015", "NXP ICODE1");
            cardsNames.Add("0021", "ST Micro Electronics LRI64");
            cardsNames.Add("0024", "ST Micro Electronics LR12");
            cardsNames.Add("0025", "ST Micro Electronics LRI128");
            cardsNames.Add("0026", "NXP Mifare Mini");
            cardsNames.Add("002F", "Innovision Jewel");
            cardsNames.Add("0030", "Innovision Topaz (NFC Forum type 1 tag)");
            cardsNames.Add("0034", "Atmel AT88RF04C");
            cardsNames.Add("0035", "NXP ICODE SL2");
            cardsNames.Add("003A", "NXP Mifare UltraLight C. Other Type 2 NFC Tags(NFC Forum) with a capacity > 64 bytes");
            cardsNames.Add("FFA0", "Generic/unknown 14443-A card");
            cardsNames.Add("FFA1", "Kovio RF barcode");
            cardsNames.Add("FFB0", "Generic/unknown 14443-B card");
            cardsNames.Add("FFB1", "ASK CTS 256B");
            cardsNames.Add("FFB2", "ASK CTS 512B");
            cardsNames.Add("FFB3", "Pre-standard ST Micro Electronics SRI 4K");
            cardsNames.Add("FFB4", "Pre-standard ST Micro Electronics SRI X512");
            cardsNames.Add("FFB5", "Pre-standard ST Micro Electronics SRI 512");
            cardsNames.Add("FFB6", "Pre-standard ST Micro Electronics SRT 512");
            cardsNames.Add("FFB7", "Inside Contactless PICOTAG/PICOPASS");
            cardsNames.Add("FFB8", "Generic Atmel AT88SC / AT88RF card");
            cardsNames.Add("FFC0", "Calypso card using the Innovatron protoco");
            cardsNames.Add("FFD0", "Generic ISO 15693 from unknown manufacturer");
            cardsNames.Add("FFD1", "Generic ISO 15693 from EM Marin (or Legic)");
            cardsNames.Add("FFD2", "Generic ISO 15693 from ST Micro Electronics, block number on 8 bits");
            cardsNames.Add("FFD3", "Generic ISO 15693 from ST Micro Electronics, block number on 16");
            cardsNames.Add("FFFF", "Virtual card (test only)");
        }

        delegate void readerStatusChangedInvoker(uint readerState, CardBuffer cardAtr);

        private void ReaderStatusChanged(uint readerState, CardBuffer cardAtr)
        {
            if (cardAtr != null)
            {
                channel = new SCardChannel(reader);
                if (!channel.Connect())
                {
                    Console.WriteLine("Error, can't connect to the card");
                    return;
                }
                CAPDU capdu = new CAPDU(0xFF, 0xCA, 0x00, 0x00);
                RAPDU rapdu = channel.Transmit(capdu);

                if (rapdu.SW != 0x9000)
                {
                    Console.WriteLine($"Get UID APDU failed! {rapdu.SW}");
                    return;
                }
                // Display card's UID formated as an hexadecimal string
                byte[] rapduB = rapdu.data.GetBytes();
                string hexadecimalResult = BitConverter.ToString(rapduB);

                cp.NFCData = hexadecimalResult.Replace("-", " ");
                cp.Invoke((MethodInvoker)(() => this.cp.SetNFCData()));
            }
            else
            {
                cp.NFCData = null;
                cp.Invoke((MethodInvoker)(() => this.cp.SetNFCData()));
            }
        }
    }
}

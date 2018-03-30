using DnD_NFC.Models;
using NdefLibrary.Ndef;
using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Devices.Enumeration;
using Windows.Networking.Proximity;

namespace DnD_NFC.Lib
{
    class CardReader
    {
        private ProximityDevice proximityDevice;
        private Settings settings;
        private ControlPanel cp;

        public CardReader(ControlPanel controlPanel, Settings appSettings)
        {
            settings = appSettings;
            cp = controlPanel;
            InitializeDevice();
        }

        private async void InitializeDevice()
        {
            //string selectorString = ProximityDevice.GetDeviceSelector();
            string selectorString = "System.Devices.ModelName:~~'NFC'";

            var deviceInfoCollection = await DeviceInformation.FindAllAsync(selectorString, null);

            if (deviceInfoCollection.Count == 0)
            {
                Console.WriteLine("No proximity devices found.");
                cp.DeviceInitialized(false);
            }
            else
            {
                Console.WriteLine($"{deviceInfoCollection.Count} Devices Found");
                proximityDevice = ProximityDevice.FromId(deviceInfoCollection[0].Id);
                cp.DeviceInitialized(true);
            }
        }

        private void ProximityDeviceDeparted(ProximityDevice sender)
        {
            Console.WriteLine("Proximate device arrived. id = " + sender.DeviceId + "\n");
        }

        private void ProximityDeviceArrived(ProximityDevice sender)
        {
            Console.WriteLine("Proximate device departed. id = " + sender.DeviceId + "\n");
            if (settings.EnableNFC)
            {
                sender.SubscribeForMessage("whatisthis", MessageReceivedHandler);
            }
        }

        public void WriteToCard(string docType, string text)
        {
            var spRecord = new NdefSpRecord
            {
                Uri = text,
                NfcAction = NdefSpActRecord.NfcActionType.DoAction
            };
            spRecord.AddTitle(new NdefTextRecord
            {
                Text = docType,
                LanguageCode = "en"
            });

            var msg = new NdefMessage { spRecord };

            proximityDevice.PublishBinaryMessage("NDEF:WriteTag", msg.ToByteArray().AsBuffer());
            proximityDevice.PublishBinaryMessage("NDEF", msg.ToByteArray().AsBuffer());
        }

        private void MessageReceivedHandler(ProximityDevice sender, ProximityMessage message)
        {
            var rawMsg = message.Data.ToArray();
            var ndefMessage = NdefMessage.FromByteArray(rawMsg);

            foreach (NdefRecord record in ndefMessage)
            {
                Console.WriteLine("Record type: " + Encoding.UTF8.GetString(record.Type, 0, record.Type.Length));
                if (record.CheckSpecializedType(false) == typeof(NdefSpRecord))
                {
                    var spRecord = new NdefSpRecord(record);
                    cp.CardReadHandler(spRecord.Uri, spRecord.Titles[0].Text);

                }
            }
        }
    }
}

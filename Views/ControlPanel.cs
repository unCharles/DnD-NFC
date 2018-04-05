using DnD_NFC.Lib;
using DnD_NFC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DnD_NFC
{
    public partial class ControlPanel : Form
    {
        private Settings settings;
        private DisplayWindow displayWindow;
        private int screenCount;
        private CardReader cardReader;

        public string NFCData { get; set; }

        public ControlPanel()
        {
            InitializeComponent();
            InitializeSettings();
            InitializeData();
            InitializeFunctions();
            InitializeDisplayWindow();

            cardReader = new CardReader(this, settings);
        }

        public void DeviceInitialized(Boolean initialized)
        {
            try
            {
                if (initialized)
                {
                    nfcStatusLabel.Text = "Device Initialized";
                    nfcStatusLabel.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    nfcStatusLabel.Text = "Device Not Found";
                    nfcStatusLabel.ForeColor = System.Drawing.Color.Orange;
                    nfcToggle.Enabled = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    
        public void DeviceErrored()
        {
            nfcStatusLabel.Text = "Device Exception Occured";
            nfcStatusLabel.ForeColor = System.Drawing.Color.Red;
        }

        public void InitializeSettings()
        {
            settings = Settings.Get();
            displayToggle.Checked = settings.EnableDisplay;
            nfcToggle.Checked = settings.EnableNFC;
        }

        public void CardReadHandler(string docType, string message)
        {
            Console.WriteLine($"{docType} {message}");
        }

        public void InitializeDisplayWindow()
        {
            displayWindow = new DisplayWindow();
            displayWindow.SetMonitor(settings.Monitor);
            if (settings.DefaultImage != null)
            {
                defaultImage.Image = new Bitmap(settings.DefaultImage);
                displayWindow.DisplayImage(settings.DefaultImage);
            }
            RefreshMaps();
            if (settings.EnableDisplay)
            {
                displayWindow.Show();
            }
        }

        public void InitializeData()
        {
            this.characterListBox.DataSource = Character.All();
            this.cardListBox.DataSource = Card.All();
            screenCount = Screen.AllScreens.Length;
            monitorSelector.Items.Clear();
            for (int i = 0; i < screenCount; i++)
            {
                var item = $"Monitor {i + 1}";
                monitorSelector.Items.Add(item);
                if (settings.Monitor == i)
                {
                    monitorSelector.SelectedItem = item;
                }

            }
            monitorSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            monitorSelector.SelectedValueChanged += SelectedMonitorChanged;
        }

        public void InitializeFunctions()
        {
            this.editCharacterButton.Click += EditCharacter;
            this.newCharacterButton.Click += NewCharacter;
            this.deleteCharacterButton.Click += DeleteCharacter;
            this.displayCharacterButton.Click += DisplayCharacter;
            this.displayToggle.CheckedChanged += ToggleDisplay;
            this.nfcToggle.CheckedChanged += ToggleNFC;
            this.clearButton.Click += ClearDisplay;
            this.setDefaultImageButton.Click += ChooseDefaultImage;
            this.refreshMapImages.Click += RefreshMaps;
            this.chooseMapFolder.Click += SetMapFolderPath;
            this.mapImageList.SelectedIndexChanged += SetThumbnailImage;
            this.displayMap.Click += DisplayMap;
            this.mapReset.Click += ClearDisplay;
            this.registerMapCardButton.Click += RegisterMapCard;
        }

        public void SetNFCData()
        {
            if (NFCData == null)
            {
                Console.WriteLine("NFC Data Cleared");
                displayWindow.RevertState();
                return;
            } else
            {
                Console.WriteLine($"NFC Data Received {NFCData}");
                if (settings.EnableNFC)
                {
                    Console.WriteLine("NFC Enabled: Displaying Element");
                    LoadElementFromNFC();
                }
                else
                {
                    Console.WriteLine("NFC Disabled");
                }
            }
        }

        private void LoadElementFromNFC()
        {
            displayWindow.PreserveState();
            Console.WriteLine("Loading Element from NFC");
            Card card = Card.FindOrCreate(NFCData);
            if (card == null)
            {
                Console.WriteLine("Card not found.");
                Notify("Card Data Not Found.");
                return;
            }

            if (card.Type == "Map")
            {
                Console.WriteLine($"Loading {card.Type} = {card.Source}");
                displayWindow.DisplayImage(card.Source);
            }
            else if (card.Type == "Character")
            {
                Character character = Character.Find(Int32.Parse(card.Source));
            } else
            {
                Console.WriteLine("Invalid Card Found.");
                Notify("Card Data Invalid.");
            }
        }

        private void EditCharacter(object sender, EventArgs e)
        {
            Character character = (Character)characterListBox.SelectedItem;
            if (character != null)
            {
                new CharacterForm(character.Id, this).Show();
            }

        }

        private void NewCharacter(object sender, EventArgs e)
        {
            var character = Character.Create();
            new CharacterForm(character.Id, this).Show();
        }

        private void DeleteCharacter(object sender, EventArgs e)
        {
            Character character = (Character)characterListBox.SelectedItem;
            if (character == null) return;

            var confirmResult = MessageBox.Show(
                "Are you sure to delete this Character?",
                "Delete Character",
                 MessageBoxButtons.YesNo
            );

            if (confirmResult == DialogResult.Yes)
            {
                character.Delete();
                InitializeData();
            }
        }

        private void RegisterMapCard(object sender, EventArgs e)
        {
            if (NFCData == null)
            {
                registerMapCardLabel.Text = "No NFC Card Detected";
                return;
            }
            Card card = Card.FindOrCreate(NFCData);
            DisplayableImage image = (DisplayableImage)mapImageList.SelectedItem;
            card.Type = "Map";
            card.Source = image.ImagePath;
            card.Save();
            registerMapCardLabel.Text = "Map Card Registered!";
        }

        private void ToggleDisplay(object sender, EventArgs e)
        {
            settings.EnableDisplay = displayToggle.Checked;
            settings.Save();
            if (displayToggle.Checked)
            {
                displayWindow.Show();
            }
            else
            {
                displayWindow.Hide();
            }
        }

        private void ToggleNFC(object sender, EventArgs e)
        {
            settings.EnableNFC = nfcToggle.Checked;
            settings.Save();
        }

        private void ClearDisplay(object sender, EventArgs e)
        {
            displayWindow.DisplayImage(settings.DefaultImage);
        }

        private void SelectedMonitorChanged(object sender, EventArgs e)
        {
            settings.Monitor = (monitorSelector.SelectedIndex);
            settings.Save();
            displayWindow.SetMonitor(monitorSelector.SelectedIndex);
        }

        private void DisplayCharacter(object sender, EventArgs e)
        {
            Character character = (Character)characterListBox.SelectedItem;
            displayWindow.DisplayCharacter(character.Id);
        }

        private void ChooseDefaultImage(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Choose Image";
                dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    defaultImage.Image = new Bitmap(dlg.FileName);
                    settings.DefaultImage = dlg.FileName;
                    settings.Save();
                }
            }
        }

        private void DisplayMap(object sender, EventArgs e)
        {
            DisplayableImage value = (DisplayableImage)mapImageList.SelectedItem;
            displayWindow.DisplayImage(value.ImagePath);  
        }


        private void SetMapFolderPath(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Set Maps Path";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    settings.MapFolder = dlg.SelectedPath;
                    settings.Save();
                    RefreshMaps();
                }
            }
        }

        private void RefreshMaps()
        {
            if (settings.MapFolder != null)
            {
                var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
                var files = GetFilesFrom(settings.MapFolder, filters, true);
                this.mapImageList.DataSource = files;
            }
        }

        private void RefreshMaps(object sender, EventArgs e)
        {
            RefreshMaps();
        }

        private void SetThumbnailImage(object sender, EventArgs e)
        {
            DisplayableImage value = (DisplayableImage)mapImageList.SelectedItem;
            mapThumbnailImage.Image = new Bitmap(value.ImagePath);
        }

        private ArrayList GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return ImageFileList(filesFound);
        }

        private ArrayList ImageFileList(List<string> imagePaths)
        {
            ArrayList list = new ArrayList();
            foreach (var item in imagePaths)
            {
                DisplayableImage image = new DisplayableImage(item);
                list.Add(image);
            }
            return list;
        }

        private void Notify(string text)
        {
            notificationLabel.Invoke((Action)delegate
            {
                notificationLabel.Text = text;
            });
        }
    }
}

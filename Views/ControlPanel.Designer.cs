using System.Collections;

namespace DnD_NFC
{
    partial class ControlPanel
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.nfcStatusLabel = new System.Windows.Forms.Label();
            this.defaultImage = new System.Windows.Forms.PictureBox();
            this.setDefaultImageButton = new System.Windows.Forms.Button();
            this.monitorSelector = new System.Windows.Forms.ComboBox();
            this.nfcToggle = new System.Windows.Forms.CheckBox();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.displayToggle = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.characterTab = new System.Windows.Forms.TabPage();
            this.clearButton = new System.Windows.Forms.Button();
            this.characterListBox = new System.Windows.Forms.ListBox();
            this.displayCharacterButton = new System.Windows.Forms.Button();
            this.deleteCharacterButton = new System.Windows.Forms.Button();
            this.editCharacterButton = new System.Windows.Forms.Button();
            this.newCharacterButton = new System.Windows.Forms.Button();
            this.mapsTab = new System.Windows.Forms.TabPage();
            this.registerMapCardLabel = new System.Windows.Forms.Label();
            this.registerMapCardButton = new System.Windows.Forms.Button();
            this.mapImageList = new System.Windows.Forms.ListBox();
            this.mapThumbnailImage = new System.Windows.Forms.PictureBox();
            this.refreshMapImages = new System.Windows.Forms.Button();
            this.mapReset = new System.Windows.Forms.Button();
            this.displayMap = new System.Windows.Forms.Button();
            this.chooseMapFolder = new System.Windows.Forms.Button();
            this.cardTab = new System.Windows.Forms.TabPage();
            this.cardListBox = new System.Windows.Forms.ListBox();
            this.thumbnailPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.folderSelector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultImage)).BeginInit();
            this.tabControl.SuspendLayout();
            this.characterTab.SuspendLayout();
            this.mapsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapThumbnailImage)).BeginInit();
            this.cardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.notificationLabel);
            this.splitContainer1.Panel1.Controls.Add(this.nfcStatusLabel);
            this.splitContainer1.Panel1.Controls.Add(this.defaultImage);
            this.splitContainer1.Panel1.Controls.Add(this.setDefaultImageButton);
            this.splitContainer1.Panel1.Controls.Add(this.monitorSelector);
            this.splitContainer1.Panel1.Controls.Add(this.nfcToggle);
            this.splitContainer1.Panel1.Controls.Add(this.settingsLabel);
            this.splitContainer1.Panel1.Controls.Add(this.displayToggle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 697);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 0;
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationLabel.Location = new System.Drawing.Point(12, 672);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(0, 16);
            this.notificationLabel.TabIndex = 7;
            // 
            // nfcStatusLabel
            // 
            this.nfcStatusLabel.AutoSize = true;
            this.nfcStatusLabel.Location = new System.Drawing.Point(95, 104);
            this.nfcStatusLabel.Name = "nfcStatusLabel";
            this.nfcStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.nfcStatusLabel.TabIndex = 6;
            // 
            // defaultImage
            // 
            this.defaultImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defaultImage.Location = new System.Drawing.Point(18, 127);
            this.defaultImage.Name = "defaultImage";
            this.defaultImage.Size = new System.Drawing.Size(187, 102);
            this.defaultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defaultImage.TabIndex = 5;
            this.defaultImage.TabStop = false;
            // 
            // setDefaultImageButton
            // 
            this.setDefaultImageButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.setDefaultImageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.setDefaultImageButton.Location = new System.Drawing.Point(18, 235);
            this.setDefaultImageButton.Name = "setDefaultImageButton";
            this.setDefaultImageButton.Size = new System.Drawing.Size(121, 35);
            this.setDefaultImageButton.TabIndex = 4;
            this.setDefaultImageButton.Text = "Set Default Image";
            this.setDefaultImageButton.UseVisualStyleBackColor = false;
            // 
            // monitorSelector
            // 
            this.monitorSelector.FormattingEnabled = true;
            this.monitorSelector.Location = new System.Drawing.Point(18, 70);
            this.monitorSelector.Name = "monitorSelector";
            this.monitorSelector.Size = new System.Drawing.Size(121, 21);
            this.monitorSelector.TabIndex = 3;
            // 
            // nfcToggle
            // 
            this.nfcToggle.AutoSize = true;
            this.nfcToggle.Location = new System.Drawing.Point(18, 104);
            this.nfcToggle.Name = "nfcToggle";
            this.nfcToggle.Size = new System.Drawing.Size(83, 17);
            this.nfcToggle.TabIndex = 2;
            this.nfcToggle.Text = "Enable NFC";
            this.nfcToggle.UseVisualStyleBackColor = true;
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(57, 9);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(113, 31);
            this.settingsLabel.TabIndex = 1;
            this.settingsLabel.Text = "Settings";
            // 
            // displayToggle
            // 
            this.displayToggle.AutoSize = true;
            this.displayToggle.Location = new System.Drawing.Point(18, 47);
            this.displayToggle.Name = "displayToggle";
            this.displayToggle.Size = new System.Drawing.Size(96, 17);
            this.displayToggle.TabIndex = 0;
            this.displayToggle.Text = "Enable Display";
            this.displayToggle.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.characterTab);
            this.tabControl.Controls.Add(this.mapsTab);
            this.tabControl.Controls.Add(this.cardTab);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(833, 694);
            this.tabControl.TabIndex = 0;
            // 
            // characterTab
            // 
            this.characterTab.Controls.Add(this.clearButton);
            this.characterTab.Controls.Add(this.characterListBox);
            this.characterTab.Controls.Add(this.displayCharacterButton);
            this.characterTab.Controls.Add(this.deleteCharacterButton);
            this.characterTab.Controls.Add(this.editCharacterButton);
            this.characterTab.Controls.Add(this.newCharacterButton);
            this.characterTab.Location = new System.Drawing.Point(4, 29);
            this.characterTab.Name = "characterTab";
            this.characterTab.Padding = new System.Windows.Forms.Padding(3);
            this.characterTab.Size = new System.Drawing.Size(825, 661);
            this.characterTab.TabIndex = 0;
            this.characterTab.Text = "Characters";
            this.characterTab.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Goldenrod;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Snow;
            this.clearButton.Location = new System.Drawing.Point(547, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(131, 47);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Reset";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // characterListBox
            // 
            this.characterListBox.AccessibleDescription = "";
            this.characterListBox.AccessibleName = "";
            this.characterListBox.FormattingEnabled = true;
            this.characterListBox.ItemHeight = 20;
            this.characterListBox.Location = new System.Drawing.Point(0, 72);
            this.characterListBox.Name = "characterListBox";
            this.characterListBox.Size = new System.Drawing.Size(822, 584);
            this.characterListBox.TabIndex = 4;
            // 
            // displayCharacterButton
            // 
            this.displayCharacterButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.displayCharacterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCharacterButton.ForeColor = System.Drawing.Color.Snow;
            this.displayCharacterButton.Location = new System.Drawing.Point(684, 12);
            this.displayCharacterButton.Name = "displayCharacterButton";
            this.displayCharacterButton.Size = new System.Drawing.Size(131, 47);
            this.displayCharacterButton.TabIndex = 3;
            this.displayCharacterButton.Text = "Display";
            this.displayCharacterButton.UseVisualStyleBackColor = false;
            // 
            // deleteCharacterButton
            // 
            this.deleteCharacterButton.BackColor = System.Drawing.Color.Red;
            this.deleteCharacterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCharacterButton.ForeColor = System.Drawing.Color.Snow;
            this.deleteCharacterButton.Location = new System.Drawing.Point(280, 9);
            this.deleteCharacterButton.Name = "deleteCharacterButton";
            this.deleteCharacterButton.Size = new System.Drawing.Size(131, 47);
            this.deleteCharacterButton.TabIndex = 2;
            this.deleteCharacterButton.Text = "Delete";
            this.deleteCharacterButton.UseVisualStyleBackColor = false;
            // 
            // editCharacterButton
            // 
            this.editCharacterButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editCharacterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCharacterButton.ForeColor = System.Drawing.Color.Snow;
            this.editCharacterButton.Location = new System.Drawing.Point(143, 9);
            this.editCharacterButton.Name = "editCharacterButton";
            this.editCharacterButton.Size = new System.Drawing.Size(131, 47);
            this.editCharacterButton.TabIndex = 1;
            this.editCharacterButton.Text = "Edit";
            this.editCharacterButton.UseVisualStyleBackColor = false;
            // 
            // newCharacterButton
            // 
            this.newCharacterButton.BackColor = System.Drawing.Color.Green;
            this.newCharacterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCharacterButton.ForeColor = System.Drawing.Color.Snow;
            this.newCharacterButton.Location = new System.Drawing.Point(6, 9);
            this.newCharacterButton.Name = "newCharacterButton";
            this.newCharacterButton.Size = new System.Drawing.Size(131, 47);
            this.newCharacterButton.TabIndex = 0;
            this.newCharacterButton.Text = "New";
            this.newCharacterButton.UseVisualStyleBackColor = false;
            // 
            // mapsTab
            // 
            this.mapsTab.Controls.Add(this.folderSelector);
            this.mapsTab.Controls.Add(this.thumbnailPlayer);
            this.mapsTab.Controls.Add(this.registerMapCardLabel);
            this.mapsTab.Controls.Add(this.registerMapCardButton);
            this.mapsTab.Controls.Add(this.mapImageList);
            this.mapsTab.Controls.Add(this.mapThumbnailImage);
            this.mapsTab.Controls.Add(this.refreshMapImages);
            this.mapsTab.Controls.Add(this.mapReset);
            this.mapsTab.Controls.Add(this.displayMap);
            this.mapsTab.Controls.Add(this.chooseMapFolder);
            this.mapsTab.Location = new System.Drawing.Point(4, 29);
            this.mapsTab.Name = "mapsTab";
            this.mapsTab.Padding = new System.Windows.Forms.Padding(3);
            this.mapsTab.Size = new System.Drawing.Size(825, 661);
            this.mapsTab.TabIndex = 1;
            this.mapsTab.Text = "Maps";
            this.mapsTab.UseVisualStyleBackColor = true;
            // 
            // registerMapCardLabel
            // 
            this.registerMapCardLabel.AutoSize = true;
            this.registerMapCardLabel.Location = new System.Drawing.Point(615, 93);
            this.registerMapCardLabel.Name = "registerMapCardLabel";
            this.registerMapCardLabel.Size = new System.Drawing.Size(0, 20);
            this.registerMapCardLabel.TabIndex = 13;
            // 
            // registerMapCardButton
            // 
            this.registerMapCardButton.BackColor = System.Drawing.Color.Blue;
            this.registerMapCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerMapCardButton.ForeColor = System.Drawing.Color.Snow;
            this.registerMapCardButton.Location = new System.Drawing.Point(663, 72);
            this.registerMapCardButton.Name = "registerMapCardButton";
            this.registerMapCardButton.Size = new System.Drawing.Size(131, 47);
            this.registerMapCardButton.TabIndex = 12;
            this.registerMapCardButton.Text = "Register NFC";
            this.registerMapCardButton.UseVisualStyleBackColor = false;
            // 
            // mapImageList
            // 
            this.mapImageList.AccessibleDescription = "";
            this.mapImageList.AccessibleName = "";
            this.mapImageList.FormattingEnabled = true;
            this.mapImageList.ItemHeight = 20;
            this.mapImageList.Location = new System.Drawing.Point(203, 38);
            this.mapImageList.Name = "mapImageList";
            this.mapImageList.Size = new System.Drawing.Size(435, 144);
            this.mapImageList.TabIndex = 11;
            // 
            // mapThumbnailImage
            // 
            this.mapThumbnailImage.BackColor = System.Drawing.Color.Gainsboro;
            this.mapThumbnailImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mapThumbnailImage.Location = new System.Drawing.Point(51, 203);
            this.mapThumbnailImage.Name = "mapThumbnailImage";
            this.mapThumbnailImage.Size = new System.Drawing.Size(743, 458);
            this.mapThumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mapThumbnailImage.TabIndex = 10;
            this.mapThumbnailImage.TabStop = false;
            // 
            // refreshMapImages
            // 
            this.refreshMapImages.BackColor = System.Drawing.Color.CornflowerBlue;
            this.refreshMapImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshMapImages.ForeColor = System.Drawing.Color.Snow;
            this.refreshMapImages.Location = new System.Drawing.Point(38, 95);
            this.refreshMapImages.Name = "refreshMapImages";
            this.refreshMapImages.Size = new System.Drawing.Size(131, 47);
            this.refreshMapImages.TabIndex = 9;
            this.refreshMapImages.Text = "Refresh";
            this.refreshMapImages.UseVisualStyleBackColor = false;
            // 
            // mapReset
            // 
            this.mapReset.BackColor = System.Drawing.Color.Goldenrod;
            this.mapReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapReset.ForeColor = System.Drawing.Color.Snow;
            this.mapReset.Location = new System.Drawing.Point(663, 125);
            this.mapReset.Name = "mapReset";
            this.mapReset.Size = new System.Drawing.Size(131, 47);
            this.mapReset.TabIndex = 8;
            this.mapReset.Text = "Reset";
            this.mapReset.UseVisualStyleBackColor = false;
            // 
            // displayMap
            // 
            this.displayMap.BackColor = System.Drawing.Color.MidnightBlue;
            this.displayMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMap.ForeColor = System.Drawing.Color.Snow;
            this.displayMap.Location = new System.Drawing.Point(663, 15);
            this.displayMap.Name = "displayMap";
            this.displayMap.Size = new System.Drawing.Size(131, 47);
            this.displayMap.TabIndex = 7;
            this.displayMap.Text = "Display";
            this.displayMap.UseVisualStyleBackColor = false;
            // 
            // chooseMapFolder
            // 
            this.chooseMapFolder.BackColor = System.Drawing.Color.Green;
            this.chooseMapFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseMapFolder.ForeColor = System.Drawing.Color.Snow;
            this.chooseMapFolder.Location = new System.Drawing.Point(38, 23);
            this.chooseMapFolder.Name = "chooseMapFolder";
            this.chooseMapFolder.Size = new System.Drawing.Size(131, 47);
            this.chooseMapFolder.TabIndex = 6;
            this.chooseMapFolder.Text = "Choose Folder";
            this.chooseMapFolder.UseVisualStyleBackColor = false;
            // 
            // cardTab
            // 
            this.cardTab.Controls.Add(this.cardListBox);
            this.cardTab.Location = new System.Drawing.Point(4, 29);
            this.cardTab.Name = "cardTab";
            this.cardTab.Padding = new System.Windows.Forms.Padding(3);
            this.cardTab.Size = new System.Drawing.Size(825, 661);
            this.cardTab.TabIndex = 2;
            this.cardTab.Text = "Cards";
            this.cardTab.UseVisualStyleBackColor = true;
            // 
            // cardListBox
            // 
            this.cardListBox.FormattingEnabled = true;
            this.cardListBox.ItemHeight = 20;
            this.cardListBox.Location = new System.Drawing.Point(3, 3);
            this.cardListBox.Name = "cardListBox";
            this.cardListBox.Size = new System.Drawing.Size(816, 644);
            this.cardListBox.TabIndex = 0;
            // 
            // thumbnailPlayer
            // 
            this.thumbnailPlayer.Enabled = true;
            this.thumbnailPlayer.Location = new System.Drawing.Point(51, 203);
            this.thumbnailPlayer.Name = "thumbnailPlayer";
            this.thumbnailPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("thumbnailPlayer.OcxState")));
            this.thumbnailPlayer.Size = new System.Drawing.Size(743, 453);
            this.thumbnailPlayer.TabIndex = 14;
            // 
            // folderSelector
            // 
            this.folderSelector.FormattingEnabled = true;
            this.folderSelector.Location = new System.Drawing.Point(203, 7);
            this.folderSelector.Name = "folderSelector";
            this.folderSelector.Size = new System.Drawing.Size(435, 28);
            this.folderSelector.TabIndex = 15;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 697);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ControlPanel";
            this.Text = "DNDNFC Control Panel";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.defaultImage)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.characterTab.ResumeLayout(false);
            this.mapsTab.ResumeLayout(false);
            this.mapsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapThumbnailImage)).EndInit();
            this.cardTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage characterTab;
        private System.Windows.Forms.Button displayCharacterButton;
        private System.Windows.Forms.Button deleteCharacterButton;
        private System.Windows.Forms.Button editCharacterButton;
        private System.Windows.Forms.Button newCharacterButton;
        protected internal System.Windows.Forms.TabPage mapsTab;
        private System.Windows.Forms.CheckBox displayToggle;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.CheckBox nfcToggle;
        private System.Windows.Forms.ListBox characterListBox;
        private System.Windows.Forms.ComboBox monitorSelector;
        private System.Windows.Forms.PictureBox defaultImage;
        private System.Windows.Forms.Button setDefaultImageButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox mapImageList;
        private System.Windows.Forms.PictureBox mapThumbnailImage;
        private System.Windows.Forms.Button refreshMapImages;
        private System.Windows.Forms.Button mapReset;
        private System.Windows.Forms.Button displayMap;
        private System.Windows.Forms.Button chooseMapFolder;
        private System.Windows.Forms.Label nfcStatusLabel;
        private System.Windows.Forms.Label registerMapCardLabel;
        private System.Windows.Forms.Button registerMapCardButton;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.TabPage cardTab;
        private System.Windows.Forms.ListBox cardListBox;
        private AxWMPLib.AxWindowsMediaPlayer thumbnailPlayer;
        private System.Windows.Forms.ComboBox folderSelector;
    }
}


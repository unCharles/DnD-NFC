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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nfcToggle = new System.Windows.Forms.CheckBox();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.displayToggle = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.characterTab = new System.Windows.Forms.TabPage();
            this.characterListBox = new System.Windows.Forms.ListBox();
            this.displayCharacterButton = new System.Windows.Forms.Button();
            this.deleteCharacterButton = new System.Windows.Forms.Button();
            this.editCharacterButton = new System.Windows.Forms.Button();
            this.newCharacterButton = new System.Windows.Forms.Button();
            this.mapsTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.characterTab.SuspendLayout();
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
            // nfcToggle
            // 
            this.nfcToggle.AutoSize = true;
            this.nfcToggle.Location = new System.Drawing.Point(18, 71);
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
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(833, 694);
            this.tabControl.TabIndex = 0;
            // 
            // characterTab
            // 
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
            // characterListBox
            // 
            this.characterListBox.DisplayMember = "name";
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
            this.mapsTab.Location = new System.Drawing.Point(4, 29);
            this.mapsTab.Name = "mapsTab";
            this.mapsTab.Padding = new System.Windows.Forms.Padding(3);
            this.mapsTab.Size = new System.Drawing.Size(825, 661);
            this.mapsTab.TabIndex = 1;
            this.mapsTab.Text = "Maps";
            this.mapsTab.UseVisualStyleBackColor = true;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 697);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ControlPanel";
            this.Text = "DNDNFC Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.characterTab.ResumeLayout(false);
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
    }
}


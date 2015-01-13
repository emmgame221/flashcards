namespace FlashCards
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashCardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deckMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divider = new System.Windows.Forms.ToolStripSeparator();
            this.quitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.flipButton = new System.Windows.Forms.Button();
            this.decksComboBox = new System.Windows.Forms.ComboBox();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.modeMenuItem,
            this.helpMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.saveMenuItem,
            this.divider,
            this.quitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flashCardMenuItem,
            this.deckMenuItem});
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newMenuItem.Text = "New";
            // 
            // flashCardMenuItem
            // 
            this.flashCardMenuItem.Name = "flashCardMenuItem";
            this.flashCardMenuItem.Size = new System.Drawing.Size(129, 22);
            this.flashCardMenuItem.Text = "Flash Card";
            // 
            // deckMenuItem
            // 
            this.deckMenuItem.Name = "deckMenuItem";
            this.deckMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deckMenuItem.Text = "Deck";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // divider
            // 
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(95, 6);
            // 
            // quitMenuItem
            // 
            this.quitMenuItem.Name = "quitMenuItem";
            this.quitMenuItem.Size = new System.Drawing.Size(98, 22);
            this.quitMenuItem.Text = "Quit";
            this.quitMenuItem.Click += new System.EventHandler(this.quitMenuItem_Click);
            // 
            // modeMenuItem
            // 
            this.modeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMenuItem,
            this.studyMenuItem});
            this.modeMenuItem.Name = "modeMenuItem";
            this.modeMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeMenuItem.Text = "Mode";
            // 
            // createMenuItem
            // 
            this.createMenuItem.Name = "createMenuItem";
            this.createMenuItem.Size = new System.Drawing.Size(108, 22);
            this.createMenuItem.Text = "Create";
            // 
            // studyMenuItem
            // 
            this.studyMenuItem.Name = "studyMenuItem";
            this.studyMenuItem.Size = new System.Drawing.Size(108, 22);
            this.studyMenuItem.Text = "Study";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // cardTextBox
            // 
            this.cardTextBox.AcceptsReturn = true;
            this.cardTextBox.Location = new System.Drawing.Point(26, 50);
            this.cardTextBox.Multiline = true;
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.ReadOnly = true;
            this.cardTextBox.Size = new System.Drawing.Size(228, 182);
            this.cardTextBox.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(26, 239);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next Card";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(178, 239);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(75, 23);
            this.flipButton.TabIndex = 3;
            this.flipButton.Text = "Flip Card";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // decksComboBox
            // 
            this.decksComboBox.FormattingEnabled = true;
            this.decksComboBox.Location = new System.Drawing.Point(26, 28);
            this.decksComboBox.Name = "decksComboBox";
            this.decksComboBox.Size = new System.Drawing.Size(121, 21);
            this.decksComboBox.TabIndex = 4;
            this.decksComboBox.Text = "Choose Deck";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.decksComboBox);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cardTextBox);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Flash Cards";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripSeparator divider;
        private System.Windows.Forms.ToolStripMenuItem quitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashCardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deckMenuItem;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.ComboBox decksComboBox;
    }
}


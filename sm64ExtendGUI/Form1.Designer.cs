namespace WindowsFormsApplication2
{
    partial class TitleBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleBar));
            this.browseButton = new System.Windows.Forms.Button();
            this.romLabel = new System.Windows.Forms.Label();
            this.romLoc = new System.Windows.Forms.TextBox();
            this.basicPanel = new System.Windows.Forms.Panel();
            this.setExtendedLabel = new System.Windows.Forms.Label();
            this.option64MB = new System.Windows.Forms.RadioButton();
            this.option48MB = new System.Windows.Forms.RadioButton();
            this.option32MB = new System.Windows.Forms.RadioButton();
            this.option24MB = new System.Windows.Forms.RadioButton();
            this.basicButton = new System.Windows.Forms.RadioButton();
            this.customButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.extendButton = new System.Windows.Forms.Button();
            this.customPanel = new System.Windows.Forms.Panel();
            this.custPadMIO0 = new System.Windows.Forms.TextBox();
            this.custPadMIO0Label = new System.Windows.Forms.Label();
            this.custExtRomSize = new System.Windows.Forms.TextBox();
            this.custExtRomLabel = new System.Windows.Forms.Label();
            this.custBytePadLabel = new System.Windows.Forms.Label();
            this.custBytePad = new System.Windows.Forms.TextBox();
            this.custDumpMIO0 = new System.Windows.Forms.CheckBox();
            this.custFillMIO0 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.basicPanel.SuspendLayout();
            this.customPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(397, 10);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // romLabel
            // 
            this.romLabel.AutoSize = true;
            this.romLabel.Location = new System.Drawing.Point(4, 15);
            this.romLabel.Name = "romLabel";
            this.romLabel.Size = new System.Drawing.Size(38, 13);
            this.romLabel.TabIndex = 1;
            this.romLabel.Text = "ROM: ";
            // 
            // romLoc
            // 
            this.romLoc.Location = new System.Drawing.Point(41, 12);
            this.romLoc.Name = "romLoc";
            this.romLoc.Size = new System.Drawing.Size(350, 20);
            this.romLoc.TabIndex = 2;
            // 
            // basicPanel
            // 
            this.basicPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.basicPanel.Controls.Add(this.setExtendedLabel);
            this.basicPanel.Controls.Add(this.option64MB);
            this.basicPanel.Controls.Add(this.option48MB);
            this.basicPanel.Controls.Add(this.option32MB);
            this.basicPanel.Controls.Add(this.option24MB);
            this.basicPanel.Location = new System.Drawing.Point(86, 61);
            this.basicPanel.Name = "basicPanel";
            this.basicPanel.Size = new System.Drawing.Size(317, 140);
            this.basicPanel.TabIndex = 3;
            // 
            // setExtendedLabel
            // 
            this.setExtendedLabel.AutoSize = true;
            this.setExtendedLabel.Location = new System.Drawing.Point(95, 13);
            this.setExtendedLabel.Name = "setExtendedLabel";
            this.setExtendedLabel.Size = new System.Drawing.Size(122, 13);
            this.setExtendedLabel.TabIndex = 4;
            this.setExtendedLabel.Text = "Set extended ROM size:";
            // 
            // option64MB
            // 
            this.option64MB.AutoSize = true;
            this.option64MB.Checked = true;
            this.option64MB.Location = new System.Drawing.Point(130, 102);
            this.option64MB.Name = "option64MB";
            this.option64MB.Size = new System.Drawing.Size(56, 17);
            this.option64MB.TabIndex = 3;
            this.option64MB.TabStop = true;
            this.option64MB.Text = "64 MB";
            this.option64MB.UseVisualStyleBackColor = true;
            // 
            // option48MB
            // 
            this.option48MB.AutoSize = true;
            this.option48MB.Location = new System.Drawing.Point(130, 79);
            this.option48MB.Name = "option48MB";
            this.option48MB.Size = new System.Drawing.Size(56, 17);
            this.option48MB.TabIndex = 2;
            this.option48MB.Text = "48 MB";
            this.option48MB.UseVisualStyleBackColor = true;
            // 
            // option32MB
            // 
            this.option32MB.AutoSize = true;
            this.option32MB.Location = new System.Drawing.Point(130, 56);
            this.option32MB.Name = "option32MB";
            this.option32MB.Size = new System.Drawing.Size(56, 17);
            this.option32MB.TabIndex = 1;
            this.option32MB.Text = "32 MB";
            this.option32MB.UseVisualStyleBackColor = true;
            // 
            // option24MB
            // 
            this.option24MB.AutoSize = true;
            this.option24MB.Location = new System.Drawing.Point(130, 33);
            this.option24MB.Name = "option24MB";
            this.option24MB.Size = new System.Drawing.Size(56, 17);
            this.option24MB.TabIndex = 0;
            this.option24MB.Text = "24 MB";
            this.option24MB.UseVisualStyleBackColor = true;
            // 
            // basicButton
            // 
            this.basicButton.AutoSize = true;
            this.basicButton.Checked = true;
            this.basicButton.Location = new System.Drawing.Point(210, 38);
            this.basicButton.Name = "basicButton";
            this.basicButton.Size = new System.Drawing.Size(51, 17);
            this.basicButton.TabIndex = 4;
            this.basicButton.TabStop = true;
            this.basicButton.Text = "Basic";
            this.basicButton.UseVisualStyleBackColor = true;
            this.basicButton.CheckedChanged += new System.EventHandler(this.basicButton_CheckedChanged);
            // 
            // customButton
            // 
            this.customButton.AutoSize = true;
            this.customButton.Location = new System.Drawing.Point(267, 38);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(60, 17);
            this.customButton.TabIndex = 5;
            this.customButton.Text = "Custom";
            this.customButton.UseVisualStyleBackColor = true;
            this.customButton.CheckedChanged += new System.EventHandler(this.customButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Setup:";
            // 
            // extendButton
            // 
            this.extendButton.Location = new System.Drawing.Point(191, 208);
            this.extendButton.Name = "extendButton";
            this.extendButton.Size = new System.Drawing.Size(100, 30);
            this.extendButton.TabIndex = 7;
            this.extendButton.Text = "Extend ROM";
            this.extendButton.UseVisualStyleBackColor = true;
            this.extendButton.Click += new System.EventHandler(this.extendButton_Click);
            // 
            // customPanel
            // 
            this.customPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customPanel.Controls.Add(this.custFillMIO0);
            this.customPanel.Controls.Add(this.custDumpMIO0);
            this.customPanel.Controls.Add(this.custBytePad);
            this.customPanel.Controls.Add(this.custBytePadLabel);
            this.customPanel.Controls.Add(this.custPadMIO0);
            this.customPanel.Controls.Add(this.custPadMIO0Label);
            this.customPanel.Controls.Add(this.custExtRomSize);
            this.customPanel.Controls.Add(this.custExtRomLabel);
            this.customPanel.Location = new System.Drawing.Point(86, 61);
            this.customPanel.Name = "customPanel";
            this.customPanel.Size = new System.Drawing.Size(317, 140);
            this.customPanel.TabIndex = 8;
            this.customPanel.Visible = false;
            // 
            // custPadMIO0
            // 
            this.custPadMIO0.Location = new System.Drawing.Point(235, 35);
            this.custPadMIO0.MaxLength = 4;
            this.custPadMIO0.Name = "custPadMIO0";
            this.custPadMIO0.Size = new System.Drawing.Size(36, 20);
            this.custPadMIO0.TabIndex = 7;
            this.custPadMIO0.Text = "32";
            // 
            // custPadMIO0Label
            // 
            this.custPadMIO0Label.AutoSize = true;
            this.custPadMIO0Label.Location = new System.Drawing.Point(47, 38);
            this.custPadMIO0Label.Name = "custPadMIO0Label";
            this.custPadMIO0Label.Size = new System.Drawing.Size(182, 13);
            this.custPadMIO0Label.TabIndex = 6;
            this.custPadMIO0Label.Text = "Padding between MIO0 blocks (KB): ";
            // 
            // custExtRomSize
            // 
            this.custExtRomSize.Location = new System.Drawing.Point(205, 13);
            this.custExtRomSize.MaxLength = 2;
            this.custExtRomSize.Name = "custExtRomSize";
            this.custExtRomSize.Size = new System.Drawing.Size(24, 20);
            this.custExtRomSize.TabIndex = 5;
            this.custExtRomSize.Text = "64";
            // 
            // custExtRomLabel
            // 
            this.custExtRomLabel.AutoSize = true;
            this.custExtRomLabel.Location = new System.Drawing.Point(95, 16);
            this.custExtRomLabel.Name = "custExtRomLabel";
            this.custExtRomLabel.Size = new System.Drawing.Size(104, 13);
            this.custExtRomLabel.TabIndex = 4;
            this.custExtRomLabel.Text = "Extended ROM size:";
            // 
            // custBytePadLabel
            // 
            this.custBytePadLabel.AutoSize = true;
            this.custBytePadLabel.Location = new System.Drawing.Point(81, 61);
            this.custBytePadLabel.Name = "custBytePadLabel";
            this.custBytePadLabel.Size = new System.Drawing.Size(122, 13);
            this.custBytePadLabel.TabIndex = 8;
            this.custBytePadLabel.Text = "Byte boundary padding: ";
            // 
            // custBytePad
            // 
            this.custBytePad.Location = new System.Drawing.Point(205, 58);
            this.custBytePad.MaxLength = 4;
            this.custBytePad.Name = "custBytePad";
            this.custBytePad.Size = new System.Drawing.Size(34, 20);
            this.custBytePad.TabIndex = 9;
            this.custBytePad.Text = "1";
            // 
            // custDumpMIO0
            // 
            this.custDumpMIO0.AutoSize = true;
            this.custDumpMIO0.Location = new System.Drawing.Point(89, 86);
            this.custDumpMIO0.Name = "custDumpMIO0";
            this.custDumpMIO0.Size = new System.Drawing.Size(150, 17);
            this.custDumpMIO0.TabIndex = 10;
            this.custDumpMIO0.Text = "Dump MIO0 blocks to files";
            this.custDumpMIO0.UseVisualStyleBackColor = true;
            // 
            // custFillMIO0
            // 
            this.custFillMIO0.AutoSize = true;
            this.custFillMIO0.Location = new System.Drawing.Point(81, 110);
            this.custFillMIO0.Name = "custFillMIO0";
            this.custFillMIO0.Size = new System.Drawing.Size(166, 17);
            this.custFillMIO0.TabIndex = 11;
            this.custFillMIO0.Text = "Fill old MIO0 blocks with 0x01";
            this.custFillMIO0.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "SM64Extend was created by queueRAM. This GUI layer was made by davideesk.";
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.extendButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customButton);
            this.Controls.Add(this.basicButton);
            this.Controls.Add(this.romLoc);
            this.Controls.Add(this.romLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.basicPanel);
            this.Controls.Add(this.customPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TitleBar";
            this.Text = "sm64extend GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.basicPanel.ResumeLayout(false);
            this.basicPanel.PerformLayout();
            this.customPanel.ResumeLayout(false);
            this.customPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label romLabel;
        private System.Windows.Forms.TextBox romLoc;
        private System.Windows.Forms.Panel basicPanel;
        private System.Windows.Forms.RadioButton basicButton;
        private System.Windows.Forms.RadioButton customButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button extendButton;
        private System.Windows.Forms.RadioButton option24MB;
        private System.Windows.Forms.RadioButton option64MB;
        private System.Windows.Forms.RadioButton option48MB;
        private System.Windows.Forms.RadioButton option32MB;
        private System.Windows.Forms.Label setExtendedLabel;
        private System.Windows.Forms.Panel customPanel;
        private System.Windows.Forms.Label custExtRomLabel;
        private System.Windows.Forms.TextBox custExtRomSize;
        private System.Windows.Forms.Label custPadMIO0Label;
        private System.Windows.Forms.TextBox custPadMIO0;
        private System.Windows.Forms.TextBox custBytePad;
        private System.Windows.Forms.Label custBytePadLabel;
        private System.Windows.Forms.CheckBox custFillMIO0;
        private System.Windows.Forms.CheckBox custDumpMIO0;
        private System.Windows.Forms.Label label2;
    }
}


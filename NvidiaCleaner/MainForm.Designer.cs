namespace NvidiaCleaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.freeUpSpaceButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cGenerateLog = new System.Windows.Forms.CheckBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.cWindowsDriver = new System.Windows.Forms.CheckBox();
            this.basicSettingsGroup = new System.Windows.Forms.GroupBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cRepository = new System.Windows.Forms.CheckBox();
            this.cDownloaded = new System.Windows.Forms.CheckBox();
            this.cExtracted = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.basicSettingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabSettings);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.groupBox2);
            this.tabMain.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabMain, "tabMain");
            this.tabMain.Name = "tabMain";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.freeUpSpaceButton);
            this.groupBox2.Controls.Add(this.progressBar);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // freeUpSpaceButton
            // 
            resources.ApplyResources(this.freeUpSpaceButton, "freeUpSpaceButton");
            this.freeUpSpaceButton.Name = "freeUpSpaceButton";
            this.freeUpSpaceButton.UseVisualStyleBackColor = true;
            this.freeUpSpaceButton.Click += new System.EventHandler(this.FreeUpSpaceButton_Click);
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textArea);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textArea
            // 
            this.textArea.BackColor = System.Drawing.Color.White;
            this.textArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textArea.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.textArea, "textArea");
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.TabStop = false;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupBox3);
            this.tabSettings.Controls.Add(this.basicSettingsGroup);
            resources.ApplyResources(this.tabSettings, "tabSettings");
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cGenerateLog);
            this.groupBox3.Controls.Add(this.richTextBox4);
            this.groupBox3.Controls.Add(this.cWindowsDriver);
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // cGenerateLog
            // 
            resources.ApplyResources(this.cGenerateLog, "cGenerateLog");
            this.cGenerateLog.ForeColor = System.Drawing.Color.Maroon;
            this.cGenerateLog.Name = "cGenerateLog";
            this.cGenerateLog.UseVisualStyleBackColor = true;
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.White;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.richTextBox4, "richTextBox4");
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.TabStop = false;
            // 
            // cWindowsDriver
            // 
            resources.ApplyResources(this.cWindowsDriver, "cWindowsDriver");
            this.cWindowsDriver.ForeColor = System.Drawing.Color.Maroon;
            this.cWindowsDriver.Name = "cWindowsDriver";
            this.cWindowsDriver.UseVisualStyleBackColor = true;
            this.cWindowsDriver.CheckedChanged += new System.EventHandler(this.CWindowsDriver_CheckedChanged);
            // 
            // basicSettingsGroup
            // 
            this.basicSettingsGroup.Controls.Add(this.richTextBox3);
            this.basicSettingsGroup.Controls.Add(this.richTextBox2);
            this.basicSettingsGroup.Controls.Add(this.richTextBox1);
            this.basicSettingsGroup.Controls.Add(this.cRepository);
            this.basicSettingsGroup.Controls.Add(this.cDownloaded);
            this.basicSettingsGroup.Controls.Add(this.cExtracted);
            resources.ApplyResources(this.basicSettingsGroup, "basicSettingsGroup");
            this.basicSettingsGroup.Name = "basicSettingsGroup";
            this.basicSettingsGroup.TabStop = false;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.White;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox3, "richTextBox3");
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox2, "richTextBox2");
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.TabStop = false;
            // 
            // cRepository
            // 
            resources.ApplyResources(this.cRepository, "cRepository");
            this.cRepository.Name = "cRepository";
            this.cRepository.UseVisualStyleBackColor = true;
            // 
            // cDownloaded
            // 
            resources.ApplyResources(this.cDownloaded, "cDownloaded");
            this.cDownloaded.Name = "cDownloaded";
            this.cDownloaded.UseVisualStyleBackColor = true;
            // 
            // cExtracted
            // 
            resources.ApplyResources(this.cExtracted, "cExtracted");
            this.cExtracted.Name = "cExtracted";
            this.cExtracted.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.basicSettingsGroup.ResumeLayout(false);
            this.basicSettingsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button freeUpSpaceButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.CheckBox cWindowsDriver;
        private System.Windows.Forms.GroupBox basicSettingsGroup;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox cRepository;
        private System.Windows.Forms.CheckBox cDownloaded;
        private System.Windows.Forms.CheckBox cExtracted;
        private System.Windows.Forms.CheckBox cGenerateLog;
    }
}


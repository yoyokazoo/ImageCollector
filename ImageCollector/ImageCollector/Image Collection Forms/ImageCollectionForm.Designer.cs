
namespace ImageCollector
{
    partial class FormImageCollection
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
            this.buttonListProcessNames = new System.Windows.Forms.Button();
            this.buttonTakeTestScreenshot = new System.Windows.Forms.Button();
            this.textBoxProcessName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonScreenshotAllProcesses = new System.Windows.Forms.Button();
            this.buttonTakeTestScreenshotDesktopProcess = new System.Windows.Forms.Button();
            this.buttonTakeTestScreenshotDektop = new System.Windows.Forms.Button();
            this.buttonPrintPropertiesOfProcess = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxWindowOffsetX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWindowOffsetY = new System.Windows.Forms.TextBox();
            this.buttonTakePeriodicScreenshots = new System.Windows.Forms.Button();
            this.buttonImageProcessing = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonListProcessNames
            // 
            this.buttonListProcessNames.Location = new System.Drawing.Point(17, 44);
            this.buttonListProcessNames.Name = "buttonListProcessNames";
            this.buttonListProcessNames.Size = new System.Drawing.Size(142, 58);
            this.buttonListProcessNames.TabIndex = 0;
            this.buttonListProcessNames.Text = "List All Process Names";
            this.buttonListProcessNames.UseVisualStyleBackColor = true;
            this.buttonListProcessNames.Click += new System.EventHandler(this.buttonListProcessNames_Click);
            // 
            // buttonTakeTestScreenshot
            // 
            this.buttonTakeTestScreenshot.Location = new System.Drawing.Point(17, 146);
            this.buttonTakeTestScreenshot.Name = "buttonTakeTestScreenshot";
            this.buttonTakeTestScreenshot.Size = new System.Drawing.Size(142, 55);
            this.buttonTakeTestScreenshot.TabIndex = 1;
            this.buttonTakeTestScreenshot.Text = "Take Test Screenshot of Named Process";
            this.buttonTakeTestScreenshot.UseVisualStyleBackColor = true;
            this.buttonTakeTestScreenshot.Click += new System.EventHandler(this.buttonTakeTestScreenshot_Click);
            // 
            // textBoxProcessName
            // 
            this.textBoxProcessName.Location = new System.Drawing.Point(545, 181);
            this.textBoxProcessName.Name = "textBoxProcessName";
            this.textBoxProcessName.Size = new System.Drawing.Size(144, 20);
            this.textBoxProcessName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Process Name";
            // 
            // buttonScreenshotAllProcesses
            // 
            this.buttonScreenshotAllProcesses.Location = new System.Drawing.Point(165, 44);
            this.buttonScreenshotAllProcesses.Name = "buttonScreenshotAllProcesses";
            this.buttonScreenshotAllProcesses.Size = new System.Drawing.Size(142, 58);
            this.buttonScreenshotAllProcesses.TabIndex = 4;
            this.buttonScreenshotAllProcesses.Text = "Screenshot All Processes";
            this.buttonScreenshotAllProcesses.UseVisualStyleBackColor = true;
            this.buttonScreenshotAllProcesses.Click += new System.EventHandler(this.buttonScreenshotAllProcesses_Click);
            // 
            // buttonTakeTestScreenshotDesktopProcess
            // 
            this.buttonTakeTestScreenshotDesktopProcess.Location = new System.Drawing.Point(165, 146);
            this.buttonTakeTestScreenshotDesktopProcess.Name = "buttonTakeTestScreenshotDesktopProcess";
            this.buttonTakeTestScreenshotDesktopProcess.Size = new System.Drawing.Size(142, 55);
            this.buttonTakeTestScreenshotDesktopProcess.TabIndex = 5;
            this.buttonTakeTestScreenshotDesktopProcess.Text = "Take Test Screenshot of Desktop 3s After Focusing ProcessName";
            this.buttonTakeTestScreenshotDesktopProcess.UseVisualStyleBackColor = true;
            this.buttonTakeTestScreenshotDesktopProcess.Click += new System.EventHandler(this.buttonTakeTestScreenshotDesktopProcess_Click);
            // 
            // buttonTakeTestScreenshotDektop
            // 
            this.buttonTakeTestScreenshotDektop.Location = new System.Drawing.Point(313, 44);
            this.buttonTakeTestScreenshotDektop.Name = "buttonTakeTestScreenshotDektop";
            this.buttonTakeTestScreenshotDektop.Size = new System.Drawing.Size(142, 58);
            this.buttonTakeTestScreenshotDektop.TabIndex = 6;
            this.buttonTakeTestScreenshotDektop.Text = "Take Test Screenshot of Desktop";
            this.buttonTakeTestScreenshotDektop.UseVisualStyleBackColor = true;
            this.buttonTakeTestScreenshotDektop.Click += new System.EventHandler(this.buttonTakeTestScreenshotDesktop_Click);
            // 
            // buttonPrintPropertiesOfProcess
            // 
            this.buttonPrintPropertiesOfProcess.Location = new System.Drawing.Point(313, 146);
            this.buttonPrintPropertiesOfProcess.Name = "buttonPrintPropertiesOfProcess";
            this.buttonPrintPropertiesOfProcess.Size = new System.Drawing.Size(142, 55);
            this.buttonPrintPropertiesOfProcess.TabIndex = 7;
            this.buttonPrintPropertiesOfProcess.Text = "Print Properties of Named Process";
            this.buttonPrintPropertiesOfProcess.UseVisualStyleBackColor = true;
            this.buttonPrintPropertiesOfProcess.Click += new System.EventHandler(this.buttonPrintPropertiesOfProcess_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBoxWindowOffsetX
            // 
            this.textBoxWindowOffsetX.Location = new System.Drawing.Point(545, 207);
            this.textBoxWindowOffsetX.Name = "textBoxWindowOffsetX";
            this.textBoxWindowOffsetX.Size = new System.Drawing.Size(144, 20);
            this.textBoxWindowOffsetX.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "WindowOffsetX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "WindowOffsetY";
            // 
            // textBoxWindowOffsetY
            // 
            this.textBoxWindowOffsetY.Location = new System.Drawing.Point(545, 233);
            this.textBoxWindowOffsetY.Name = "textBoxWindowOffsetY";
            this.textBoxWindowOffsetY.Size = new System.Drawing.Size(144, 20);
            this.textBoxWindowOffsetY.TabIndex = 12;
            // 
            // buttonTakePeriodicScreenshots
            // 
            this.buttonTakePeriodicScreenshots.Location = new System.Drawing.Point(17, 219);
            this.buttonTakePeriodicScreenshots.Name = "buttonTakePeriodicScreenshots";
            this.buttonTakePeriodicScreenshots.Size = new System.Drawing.Size(142, 55);
            this.buttonTakePeriodicScreenshots.TabIndex = 13;
            this.buttonTakePeriodicScreenshots.Text = "Take Periodic Screenshots of Named Process";
            this.buttonTakePeriodicScreenshots.UseVisualStyleBackColor = true;
            this.buttonTakePeriodicScreenshots.Click += new System.EventHandler(this.buttonTakePeriodicScreenshots_Click);
            // 
            // buttonImageProcessing
            // 
            this.buttonImageProcessing.Location = new System.Drawing.Point(12, 509);
            this.buttonImageProcessing.Name = "buttonImageProcessing";
            this.buttonImageProcessing.Size = new System.Drawing.Size(144, 75);
            this.buttonImageProcessing.TabIndex = 14;
            this.buttonImageProcessing.Text = "Image Processing";
            this.buttonImageProcessing.UseVisualStyleBackColor = true;
            this.buttonImageProcessing.Click += new System.EventHandler(this.buttonImageProcessing_Click);
            // 
            // FormImageCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 596);
            this.Controls.Add(this.buttonImageProcessing);
            this.Controls.Add(this.buttonTakePeriodicScreenshots);
            this.Controls.Add(this.textBoxWindowOffsetY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWindowOffsetX);
            this.Controls.Add(this.buttonPrintPropertiesOfProcess);
            this.Controls.Add(this.buttonTakeTestScreenshotDektop);
            this.Controls.Add(this.buttonTakeTestScreenshotDesktopProcess);
            this.Controls.Add(this.buttonScreenshotAllProcesses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProcessName);
            this.Controls.Add(this.buttonTakeTestScreenshot);
            this.Controls.Add(this.buttonListProcessNames);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormImageCollection";
            this.Text = "Image Collection";
            this.Load += new System.EventHandler(this.ImageCollectionForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListProcessNames;
        private System.Windows.Forms.Button buttonTakeTestScreenshot;
        private System.Windows.Forms.TextBox textBoxProcessName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonScreenshotAllProcesses;
        private System.Windows.Forms.Button buttonTakeTestScreenshotDesktopProcess;
        private System.Windows.Forms.Button buttonTakeTestScreenshotDektop;
        private System.Windows.Forms.Button buttonPrintPropertiesOfProcess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxWindowOffsetX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWindowOffsetY;
        private System.Windows.Forms.Button buttonTakePeriodicScreenshots;
        private System.Windows.Forms.Button buttonImageProcessing;
    }
}


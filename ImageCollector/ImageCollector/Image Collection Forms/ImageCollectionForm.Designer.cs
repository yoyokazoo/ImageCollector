namespace ImageCollector
{
    partial class ImageCollectionForm
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
            this.buttonScreenshotAllProcesses = new System.Windows.Forms.Button();
            this.buttonScreenshotDesktop = new System.Windows.Forms.Button();
            this.textBoxProcessName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWindowOffsetX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWindowOffsetY = new System.Windows.Forms.TextBox();
            this.buttonScreenshotNamedProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonListProcessNames
            // 
            this.buttonListProcessNames.Location = new System.Drawing.Point(12, 12);
            this.buttonListProcessNames.Name = "buttonListProcessNames";
            this.buttonListProcessNames.Size = new System.Drawing.Size(144, 82);
            this.buttonListProcessNames.TabIndex = 0;
            this.buttonListProcessNames.Text = "List Process Names";
            this.buttonListProcessNames.UseVisualStyleBackColor = true;
            this.buttonListProcessNames.Click += new System.EventHandler(this.buttonListProcessNames_Click);
            // 
            // buttonScreenshotAllProcesses
            // 
            this.buttonScreenshotAllProcesses.Location = new System.Drawing.Point(162, 12);
            this.buttonScreenshotAllProcesses.Name = "buttonScreenshotAllProcesses";
            this.buttonScreenshotAllProcesses.Size = new System.Drawing.Size(144, 82);
            this.buttonScreenshotAllProcesses.TabIndex = 1;
            this.buttonScreenshotAllProcesses.Text = "Screenshot All Processes";
            this.buttonScreenshotAllProcesses.UseVisualStyleBackColor = true;
            this.buttonScreenshotAllProcesses.Click += new System.EventHandler(this.buttonScreenshotAllProcesses_Click);
            // 
            // buttonScreenshotDesktop
            // 
            this.buttonScreenshotDesktop.Location = new System.Drawing.Point(312, 12);
            this.buttonScreenshotDesktop.Name = "buttonScreenshotDesktop";
            this.buttonScreenshotDesktop.Size = new System.Drawing.Size(144, 82);
            this.buttonScreenshotDesktop.TabIndex = 2;
            this.buttonScreenshotDesktop.Text = "Screenshot Desktop";
            this.buttonScreenshotDesktop.UseVisualStyleBackColor = true;
            this.buttonScreenshotDesktop.Click += new System.EventHandler(this.buttonScreenshotDesktop_Click);
            // 
            // textBoxProcessName
            // 
            this.textBoxProcessName.Location = new System.Drawing.Point(97, 139);
            this.textBoxProcessName.Name = "textBoxProcessName";
            this.textBoxProcessName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProcessName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Process Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "WindowOffsetX";
            // 
            // textBoxWindowOffsetX
            // 
            this.textBoxWindowOffsetX.Location = new System.Drawing.Point(97, 165);
            this.textBoxWindowOffsetX.Name = "textBoxWindowOffsetX";
            this.textBoxWindowOffsetX.Size = new System.Drawing.Size(100, 20);
            this.textBoxWindowOffsetX.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "WindowOffsetY";
            // 
            // textBoxWindowOffsetY
            // 
            this.textBoxWindowOffsetY.Location = new System.Drawing.Point(97, 191);
            this.textBoxWindowOffsetY.Name = "textBoxWindowOffsetY";
            this.textBoxWindowOffsetY.Size = new System.Drawing.Size(100, 20);
            this.textBoxWindowOffsetY.TabIndex = 7;
            // 
            // buttonScreenshotNamedProcess
            // 
            this.buttonScreenshotNamedProcess.Location = new System.Drawing.Point(12, 227);
            this.buttonScreenshotNamedProcess.Name = "buttonScreenshotNamedProcess";
            this.buttonScreenshotNamedProcess.Size = new System.Drawing.Size(144, 82);
            this.buttonScreenshotNamedProcess.TabIndex = 9;
            this.buttonScreenshotNamedProcess.Text = "Screenshot Named Process";
            this.buttonScreenshotNamedProcess.UseVisualStyleBackColor = true;
            this.buttonScreenshotNamedProcess.Click += new System.EventHandler(this.buttonScreenshotNamedProcess_Click);
            // 
            // ImageCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonScreenshotNamedProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWindowOffsetY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWindowOffsetX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProcessName);
            this.Controls.Add(this.buttonScreenshotDesktop);
            this.Controls.Add(this.buttonScreenshotAllProcesses);
            this.Controls.Add(this.buttonListProcessNames);
            this.Name = "ImageCollectionForm";
            this.Text = "ImageCollectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListProcessNames;
        private System.Windows.Forms.Button buttonScreenshotAllProcesses;
        private System.Windows.Forms.Button buttonScreenshotDesktop;
        private System.Windows.Forms.TextBox textBoxProcessName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWindowOffsetX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWindowOffsetY;
        private System.Windows.Forms.Button buttonScreenshotNamedProcess;
    }
}
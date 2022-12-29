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
            this.buttonScreenshotAfterFocusing = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProcessNum = new System.Windows.Forms.TextBox();
            this.buttonScreenshotNumProcess = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWindowHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWindowWidth = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
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
            this.textBoxProcessName.Size = new System.Drawing.Size(171, 20);
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
            this.textBoxWindowOffsetX.Size = new System.Drawing.Size(171, 20);
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
            this.textBoxWindowOffsetY.Size = new System.Drawing.Size(171, 20);
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
            // buttonScreenshotAfterFocusing
            // 
            this.buttonScreenshotAfterFocusing.Location = new System.Drawing.Point(162, 227);
            this.buttonScreenshotAfterFocusing.Name = "buttonScreenshotAfterFocusing";
            this.buttonScreenshotAfterFocusing.Size = new System.Drawing.Size(144, 82);
            this.buttonScreenshotAfterFocusing.TabIndex = 10;
            this.buttonScreenshotAfterFocusing.Text = "Screenshot Desktop After Focusing Named Process";
            this.buttonScreenshotAfterFocusing.UseVisualStyleBackColor = true;
            this.buttonScreenshotAfterFocusing.Click += new System.EventHandler(this.buttonScreenshotAfterFocusing_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 82);
            this.button1.TabIndex = 11;
            this.button1.Text = "Print Properties of Named Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Process Num";
            // 
            // textBoxProcessNum
            // 
            this.textBoxProcessNum.Location = new System.Drawing.Point(356, 135);
            this.textBoxProcessNum.Name = "textBoxProcessNum";
            this.textBoxProcessNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxProcessNum.TabIndex = 12;
            // 
            // buttonScreenshotNumProcess
            // 
            this.buttonScreenshotNumProcess.Location = new System.Drawing.Point(12, 315);
            this.buttonScreenshotNumProcess.Name = "buttonScreenshotNumProcess";
            this.buttonScreenshotNumProcess.Size = new System.Drawing.Size(144, 82);
            this.buttonScreenshotNumProcess.TabIndex = 14;
            this.buttonScreenshotNumProcess.Text = "Screenshot Process Num";
            this.buttonScreenshotNumProcess.UseVisualStyleBackColor = true;
            this.buttonScreenshotNumProcess.Click += new System.EventHandler(this.buttonScreenshotNumProcess_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 82);
            this.button2.TabIndex = 15;
            this.button2.Text = "Print Properties of Process Num";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 82);
            this.button3.TabIndex = 16;
            this.button3.Text = "Screenshot Desktop After Focusing Process Num";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 82);
            this.button4.TabIndex = 17;
            this.button4.Text = "Take Periodic Desktop Screenshots";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Window Height";
            // 
            // textBoxWindowHeight
            // 
            this.textBoxWindowHeight.Location = new System.Drawing.Point(356, 191);
            this.textBoxWindowHeight.Name = "textBoxWindowHeight";
            this.textBoxWindowHeight.Size = new System.Drawing.Size(171, 20);
            this.textBoxWindowHeight.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Window Width";
            // 
            // textBoxWindowWidth
            // 
            this.textBoxWindowWidth.Location = new System.Drawing.Point(356, 165);
            this.textBoxWindowWidth.Name = "textBoxWindowWidth";
            this.textBoxWindowWidth.Size = new System.Drawing.Size(171, 20);
            this.textBoxWindowWidth.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(462, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 82);
            this.button5.TabIndex = 22;
            this.button5.Text = "Move and Resize Named Process";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(462, 315);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 82);
            this.button6.TabIndex = 23;
            this.button6.Text = "Move and Resize Process Num";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 490);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 82);
            this.button7.TabIndex = 24;
            this.button7.Text = "Image Processing Form";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ImageCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxWindowHeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxWindowWidth);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonScreenshotNumProcess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxProcessNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonScreenshotAfterFocusing);
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
        private System.Windows.Forms.Button buttonScreenshotAfterFocusing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProcessNum;
        private System.Windows.Forms.Button buttonScreenshotNumProcess;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWindowHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxWindowWidth;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}
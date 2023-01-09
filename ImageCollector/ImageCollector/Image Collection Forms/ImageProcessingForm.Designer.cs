namespace ImageCollector.Image_Collection_Forms
{
    partial class ImageProcessingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageProcessingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInputFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxSourceImage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxOutputFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOffsetX = new System.Windows.Forms.TextBox();
            this.textBoxOffsetY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxRepeatY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRepeatX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxStepY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxStepX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBoxSlicePrefix = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxBlowAwayFolderContents = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Folder";
            // 
            // textBoxInputFolder
            // 
            this.textBoxInputFolder.Location = new System.Drawing.Point(81, 44);
            this.textBoxInputFolder.Name = "textBoxInputFolder";
            this.textBoxInputFolder.ReadOnly = true;
            this.textBoxInputFolder.Size = new System.Drawing.Size(464, 20);
            this.textBoxInputFolder.TabIndex = 1;
            this.textBoxInputFolder.TextChanged += new System.EventHandler(this.InputFolderPath_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Choose";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSourceImage
            // 
            this.textBoxSourceImage.Location = new System.Drawing.Point(81, 143);
            this.textBoxSourceImage.Name = "textBoxSourceImage";
            this.textBoxSourceImage.ReadOnly = true;
            this.textBoxSourceImage.Size = new System.Drawing.Size(464, 20);
            this.textBoxSourceImage.TabIndex = 4;
            this.textBoxSourceImage.TextChanged += new System.EventHandler(this.SourceImage_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source Image";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "Choose";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxOutputFolder
            // 
            this.textBoxOutputFolder.Location = new System.Drawing.Point(81, 84);
            this.textBoxOutputFolder.Name = "textBoxOutputFolder";
            this.textBoxOutputFolder.ReadOnly = true;
            this.textBoxOutputFolder.Size = new System.Drawing.Size(464, 20);
            this.textBoxOutputFolder.TabIndex = 7;
            this.textBoxOutputFolder.TextChanged += new System.EventHandler(this.OutputFolderPath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output Folder";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 446);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 60);
            this.button4.TabIndex = 9;
            this.button4.Text = "Find Subimage Coordinates";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Offset X";
            // 
            // textBoxOffsetX
            // 
            this.textBoxOffsetX.Location = new System.Drawing.Point(81, 210);
            this.textBoxOffsetX.Name = "textBoxOffsetX";
            this.textBoxOffsetX.Size = new System.Drawing.Size(116, 20);
            this.textBoxOffsetX.TabIndex = 11;
            this.textBoxOffsetX.TextChanged += new System.EventHandler(this.OffsetX_TextChanged);
            // 
            // textBoxOffsetY
            // 
            this.textBoxOffsetY.Location = new System.Drawing.Point(81, 236);
            this.textBoxOffsetY.Name = "textBoxOffsetY";
            this.textBoxOffsetY.Size = new System.Drawing.Size(116, 20);
            this.textBoxOffsetY.TabIndex = 13;
            this.textBoxOffsetY.TextChanged += new System.EventHandler(this.OffsetY_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Offset Y";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(81, 262);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(116, 20);
            this.textBoxWidth.TabIndex = 15;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.Width_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Width";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(81, 288);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(116, 20);
            this.textBoxHeight.TabIndex = 17;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.Height_TestChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Height";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 60);
            this.button5.TabIndex = 18;
            this.button5.Text = "Slice Images";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxRepeatY
            // 
            this.textBoxRepeatY.Location = new System.Drawing.Point(288, 288);
            this.textBoxRepeatY.Name = "textBoxRepeatY";
            this.textBoxRepeatY.Size = new System.Drawing.Size(116, 20);
            this.textBoxRepeatY.TabIndex = 22;
            this.textBoxRepeatY.TextChanged += new System.EventHandler(this.RepeatY_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Repeat Y";
            // 
            // textBoxRepeatX
            // 
            this.textBoxRepeatX.Location = new System.Drawing.Point(288, 262);
            this.textBoxRepeatX.Name = "textBoxRepeatX";
            this.textBoxRepeatX.Size = new System.Drawing.Size(116, 20);
            this.textBoxRepeatX.TabIndex = 20;
            this.textBoxRepeatX.TextChanged += new System.EventHandler(this.RepeatX_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Repeat X";
            // 
            // textBoxStepY
            // 
            this.textBoxStepY.Location = new System.Drawing.Point(288, 239);
            this.textBoxStepY.Name = "textBoxStepY";
            this.textBoxStepY.Size = new System.Drawing.Size(116, 20);
            this.textBoxStepY.TabIndex = 26;
            this.textBoxStepY.TextChanged += new System.EventHandler(this.StepY_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Step Y";
            // 
            // textBoxStepX
            // 
            this.textBoxStepX.Location = new System.Drawing.Point(288, 213);
            this.textBoxStepX.Name = "textBoxStepX";
            this.textBoxStepX.Size = new System.Drawing.Size(116, 20);
            this.textBoxStepX.TabIndex = 24;
            this.textBoxStepX.TextChanged += new System.EventHandler(this.StepX_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Step X";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(147, 380);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 60);
            this.button6.TabIndex = 28;
            this.button6.Text = "Preview";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(147, 446);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 60);
            this.button7.TabIndex = 29;
            this.button7.Text = "Reduce To Unique Bitmaps";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(282, 446);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(129, 60);
            this.button8.TabIndex = 30;
            this.button8.Text = "Find Unique Color Coordinates";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBoxSlicePrefix
            // 
            this.textBoxSlicePrefix.Location = new System.Drawing.Point(491, 210);
            this.textBoxSlicePrefix.Name = "textBoxSlicePrefix";
            this.textBoxSlicePrefix.Size = new System.Drawing.Size(116, 20);
            this.textBoxSlicePrefix.TabIndex = 32;
            this.textBoxSlicePrefix.TextChanged += new System.EventHandler(this.textBoxSlicePrefix_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(422, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Slice Prefix";
            // 
            // checkBoxBlowAwayFolderContents
            // 
            this.checkBoxBlowAwayFolderContents.AutoSize = true;
            this.checkBoxBlowAwayFolderContents.Location = new System.Drawing.Point(425, 238);
            this.checkBoxBlowAwayFolderContents.Name = "checkBoxBlowAwayFolderContents";
            this.checkBoxBlowAwayFolderContents.Size = new System.Drawing.Size(155, 17);
            this.checkBoxBlowAwayFolderContents.TabIndex = 33;
            this.checkBoxBlowAwayFolderContents.Text = "Blow Away Folder Contents";
            this.checkBoxBlowAwayFolderContents.UseVisualStyleBackColor = true;
            this.checkBoxBlowAwayFolderContents.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ImageProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 729);
            this.Controls.Add(this.checkBoxBlowAwayFolderContents);
            this.Controls.Add(this.textBoxSlicePrefix);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBoxStepY);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxStepX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxRepeatY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxRepeatX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxOffsetY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOffsetX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxOutputFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxSourceImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxInputFolder);
            this.Controls.Add(this.label1);
            this.Name = "ImageProcessingForm";
            this.Text = "ImageProcessingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageProcessingForm_FormClosing);
            this.Load += new System.EventHandler(this.ImageProcessingForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInputFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxSourceImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxOutputFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOffsetX;
        private System.Windows.Forms.TextBox textBoxOffsetY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxRepeatY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRepeatX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxStepY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStepX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBoxSlicePrefix;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxBlowAwayFolderContents;
    }
}
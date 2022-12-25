
namespace ImageCollector
{
    partial class FormImageProcessing
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialogInput = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxInputFolder = new System.Windows.Forms.TextBox();
            this.textBoxOutputFolder = new System.Windows.Forms.TextBox();
            this.buttonChooseInputFolder = new System.Windows.Forms.Button();
            this.buttonChooseOutputFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOffsetX = new System.Windows.Forms.TextBox();
            this.textBoxOffsetY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStepY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStepX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRepeatRows = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRepeatColumns = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAltRowY = new System.Windows.Forms.TextBox();
            this.textBoxAltRowX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Folder";
            // 
            // textBoxInputFolder
            // 
            this.textBoxInputFolder.Location = new System.Drawing.Point(123, 49);
            this.textBoxInputFolder.Name = "textBoxInputFolder";
            this.textBoxInputFolder.ReadOnly = true;
            this.textBoxInputFolder.Size = new System.Drawing.Size(584, 20);
            this.textBoxInputFolder.TabIndex = 2;
            // 
            // textBoxOutputFolder
            // 
            this.textBoxOutputFolder.Location = new System.Drawing.Point(123, 80);
            this.textBoxOutputFolder.Name = "textBoxOutputFolder";
            this.textBoxOutputFolder.ReadOnly = true;
            this.textBoxOutputFolder.Size = new System.Drawing.Size(584, 20);
            this.textBoxOutputFolder.TabIndex = 3;
            // 
            // buttonChooseInputFolder
            // 
            this.buttonChooseInputFolder.Location = new System.Drawing.Point(713, 47);
            this.buttonChooseInputFolder.Name = "buttonChooseInputFolder";
            this.buttonChooseInputFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseInputFolder.TabIndex = 4;
            this.buttonChooseInputFolder.Text = "Choose";
            this.buttonChooseInputFolder.UseVisualStyleBackColor = true;
            this.buttonChooseInputFolder.Click += new System.EventHandler(this.buttonChooseInputFolder_Click);
            // 
            // buttonChooseOutputFolder
            // 
            this.buttonChooseOutputFolder.Location = new System.Drawing.Point(713, 80);
            this.buttonChooseOutputFolder.Name = "buttonChooseOutputFolder";
            this.buttonChooseOutputFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseOutputFolder.TabIndex = 5;
            this.buttonChooseOutputFolder.Text = "Choose";
            this.buttonChooseOutputFolder.UseVisualStyleBackColor = true;
            this.buttonChooseOutputFolder.Click += new System.EventHandler(this.buttonChooseOutputFolder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
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
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Offset X";
            // 
            // textBoxOffsetX
            // 
            this.textBoxOffsetX.Location = new System.Drawing.Point(141, 136);
            this.textBoxOffsetX.Name = "textBoxOffsetX";
            this.textBoxOffsetX.Size = new System.Drawing.Size(100, 20);
            this.textBoxOffsetX.TabIndex = 8;
            this.textBoxOffsetX.TextChanged += new System.EventHandler(this.OffsetX_TextChanged);
            // 
            // textBoxOffsetY
            // 
            this.textBoxOffsetY.Location = new System.Drawing.Point(376, 136);
            this.textBoxOffsetY.Name = "textBoxOffsetY";
            this.textBoxOffsetY.Size = new System.Drawing.Size(100, 20);
            this.textBoxOffsetY.TabIndex = 10;
            this.textBoxOffsetY.TextChanged += new System.EventHandler(this.OffsetY_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Offset Y";
            // 
            // textBoxStepY
            // 
            this.textBoxStepY.Location = new System.Drawing.Point(376, 190);
            this.textBoxStepY.Name = "textBoxStepY";
            this.textBoxStepY.Size = new System.Drawing.Size(100, 20);
            this.textBoxStepY.TabIndex = 14;
            this.textBoxStepY.TextChanged += new System.EventHandler(this.StepY_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Step Y";
            // 
            // textBoxStepX
            // 
            this.textBoxStepX.Location = new System.Drawing.Point(141, 190);
            this.textBoxStepX.Name = "textBoxStepX";
            this.textBoxStepX.Size = new System.Drawing.Size(100, 20);
            this.textBoxStepX.TabIndex = 12;
            this.textBoxStepX.TextChanged += new System.EventHandler(this.StepX_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Step X";
            // 
            // textBoxRepeatRows
            // 
            this.textBoxRepeatRows.Location = new System.Drawing.Point(376, 216);
            this.textBoxRepeatRows.Name = "textBoxRepeatRows";
            this.textBoxRepeatRows.Size = new System.Drawing.Size(100, 20);
            this.textBoxRepeatRows.TabIndex = 18;
            this.textBoxRepeatRows.TextChanged += new System.EventHandler(this.RepeatRows_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Repeat Rows";
            // 
            // textBoxRepeatColumns
            // 
            this.textBoxRepeatColumns.Location = new System.Drawing.Point(141, 216);
            this.textBoxRepeatColumns.Name = "textBoxRepeatColumns";
            this.textBoxRepeatColumns.Size = new System.Drawing.Size(100, 20);
            this.textBoxRepeatColumns.TabIndex = 16;
            this.textBoxRepeatColumns.TextChanged += new System.EventHandler(this.RepeatColumns_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Repeat Columns";
            // 
            // textBoxAltRowY
            // 
            this.textBoxAltRowY.Location = new System.Drawing.Point(376, 242);
            this.textBoxAltRowY.Name = "textBoxAltRowY";
            this.textBoxAltRowY.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltRowY.TabIndex = 22;
            this.textBoxAltRowY.TextChanged += new System.EventHandler(this.AlternatingRowOffsetY_TextChanged);
            // 
            // textBoxAltRowX
            // 
            this.textBoxAltRowX.Location = new System.Drawing.Point(141, 242);
            this.textBoxAltRowX.Name = "textBoxAltRowX";
            this.textBoxAltRowX.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltRowX.TabIndex = 20;
            this.textBoxAltRowX.TextChanged += new System.EventHandler(this.AlternatingRowOffsetX_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Alternating Row Offset X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Alternating Row Offset Y";
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(15, 362);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(75, 23);
            this.buttonPreview.TabIndex = 24;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(376, 162);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 28;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Height";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(141, 162);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 26;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Width";
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(15, 391);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonProcess.TabIndex = 29;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // FormImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxAltRowY);
            this.Controls.Add(this.textBoxAltRowX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxRepeatRows);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRepeatColumns);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxStepY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxStepX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxOffsetY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOffsetX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonChooseOutputFolder);
            this.Controls.Add(this.buttonChooseInputFolder);
            this.Controls.Add(this.textBoxOutputFolder);
            this.Controls.Add(this.textBoxInputFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormImageProcessing";
            this.Text = "ImageProcessingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormImageProcessing_FormClosing);
            this.Load += new System.EventHandler(this.ImageProcessingForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogInput;
        private System.Windows.Forms.TextBox textBoxInputFolder;
        private System.Windows.Forms.TextBox textBoxOutputFolder;
        private System.Windows.Forms.Button buttonChooseInputFolder;
        private System.Windows.Forms.Button buttonChooseOutputFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOffsetX;
        private System.Windows.Forms.TextBox textBoxOffsetY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStepY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStepX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRepeatRows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRepeatColumns;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAltRowY;
        private System.Windows.Forms.TextBox textBoxAltRowX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonProcess;
    }
}
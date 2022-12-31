namespace ImageCollector.Image_Collection_Forms
{
    partial class ImageProcessingPreviewForm
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDecrementOffsetX = new System.Windows.Forms.Button();
            this.buttonIncrementOffsetX = new System.Windows.Forms.Button();
            this.buttonIncrementOffsetY = new System.Windows.Forms.Button();
            this.buttonDecrementOffsetY = new System.Windows.Forms.Button();
            this.buttonIncrementHeight = new System.Windows.Forms.Button();
            this.buttonDecrementHeight = new System.Windows.Forms.Button();
            this.buttonIncrementWidth = new System.Windows.Forms.Button();
            this.buttonDecrementWidth = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonIncrementStepY = new System.Windows.Forms.Button();
            this.buttonDecrementStepY = new System.Windows.Forms.Button();
            this.buttonIncrementStepX = new System.Windows.Forms.Button();
            this.buttonDecrementStepX = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonIncrementRepeatY = new System.Windows.Forms.Button();
            this.buttonDecrementRepeatY = new System.Windows.Forms.Button();
            this.buttonIncrementRepeatX = new System.Windows.Forms.Button();
            this.buttonDecrementRepeatX = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(121, 59);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(12, 117);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(1112, 509);
            this.pictureBoxPreview.TabIndex = 1;
            this.pictureBoxPreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Offset X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Offset Y";
            // 
            // buttonDecrementOffsetX
            // 
            this.buttonDecrementOffsetX.Location = new System.Drawing.Point(210, 7);
            this.buttonDecrementOffsetX.Name = "buttonDecrementOffsetX";
            this.buttonDecrementOffsetX.Size = new System.Drawing.Size(30, 30);
            this.buttonDecrementOffsetX.TabIndex = 4;
            this.buttonDecrementOffsetX.Text = "-";
            this.buttonDecrementOffsetX.UseVisualStyleBackColor = true;
            this.buttonDecrementOffsetX.Click += new System.EventHandler(this.buttonDecrementOffsetX_Click);
            // 
            // buttonIncrementOffsetX
            // 
            this.buttonIncrementOffsetX.Location = new System.Drawing.Point(246, 7);
            this.buttonIncrementOffsetX.Name = "buttonIncrementOffsetX";
            this.buttonIncrementOffsetX.Size = new System.Drawing.Size(30, 30);
            this.buttonIncrementOffsetX.TabIndex = 5;
            this.buttonIncrementOffsetX.Text = "+";
            this.buttonIncrementOffsetX.UseVisualStyleBackColor = true;
            this.buttonIncrementOffsetX.Click += new System.EventHandler(this.buttonIncrementOffsetX_Click);
            // 
            // buttonIncrementOffsetY
            // 
            this.buttonIncrementOffsetY.Location = new System.Drawing.Point(246, 49);
            this.buttonIncrementOffsetY.Name = "buttonIncrementOffsetY";
            this.buttonIncrementOffsetY.Size = new System.Drawing.Size(30, 30);
            this.buttonIncrementOffsetY.TabIndex = 7;
            this.buttonIncrementOffsetY.Text = "+";
            this.buttonIncrementOffsetY.UseVisualStyleBackColor = true;
            this.buttonIncrementOffsetY.Click += new System.EventHandler(this.buttonIncrementOffsetY_Click);
            // 
            // buttonDecrementOffsetY
            // 
            this.buttonDecrementOffsetY.Location = new System.Drawing.Point(210, 49);
            this.buttonDecrementOffsetY.Name = "buttonDecrementOffsetY";
            this.buttonDecrementOffsetY.Size = new System.Drawing.Size(30, 30);
            this.buttonDecrementOffsetY.TabIndex = 6;
            this.buttonDecrementOffsetY.Text = "-";
            this.buttonDecrementOffsetY.UseVisualStyleBackColor = true;
            this.buttonDecrementOffsetY.Click += new System.EventHandler(this.buttonDecrementOffsetY_Click);
            // 
            // buttonIncrementHeight
            // 
            this.buttonIncrementHeight.Location = new System.Drawing.Point(397, 49);
            this.buttonIncrementHeight.Name = "buttonIncrementHeight";
            this.buttonIncrementHeight.Size = new System.Drawing.Size(30, 30);
            this.buttonIncrementHeight.TabIndex = 13;
            this.buttonIncrementHeight.Text = "+";
            this.buttonIncrementHeight.UseVisualStyleBackColor = true;
            this.buttonIncrementHeight.Click += new System.EventHandler(this.buttonIncrementHeight_Click);
            // 
            // buttonDecrementHeight
            // 
            this.buttonDecrementHeight.Location = new System.Drawing.Point(361, 49);
            this.buttonDecrementHeight.Name = "buttonDecrementHeight";
            this.buttonDecrementHeight.Size = new System.Drawing.Size(30, 30);
            this.buttonDecrementHeight.TabIndex = 12;
            this.buttonDecrementHeight.Text = "-";
            this.buttonDecrementHeight.UseVisualStyleBackColor = true;
            this.buttonDecrementHeight.Click += new System.EventHandler(this.buttonDecrementHeight_Click);
            // 
            // buttonIncrementWidth
            // 
            this.buttonIncrementWidth.Location = new System.Drawing.Point(397, 7);
            this.buttonIncrementWidth.Name = "buttonIncrementWidth";
            this.buttonIncrementWidth.Size = new System.Drawing.Size(30, 30);
            this.buttonIncrementWidth.TabIndex = 11;
            this.buttonIncrementWidth.Text = "+";
            this.buttonIncrementWidth.UseVisualStyleBackColor = true;
            this.buttonIncrementWidth.Click += new System.EventHandler(this.buttonIncrementWidth_Click);
            // 
            // buttonDecrementWidth
            // 
            this.buttonDecrementWidth.Location = new System.Drawing.Point(361, 7);
            this.buttonDecrementWidth.Name = "buttonDecrementWidth";
            this.buttonDecrementWidth.Size = new System.Drawing.Size(30, 30);
            this.buttonDecrementWidth.TabIndex = 10;
            this.buttonDecrementWidth.Text = "-";
            this.buttonDecrementWidth.UseVisualStyleBackColor = true;
            this.buttonDecrementWidth.Click += new System.EventHandler(this.buttonDecrementWidth_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Width";
            // 
            // buttonIncrementStepY
            // 
            this.buttonIncrementStepY.Location = new System.Drawing.Point(552, 49);
            this.buttonIncrementStepY.Name = "buttonIncrementStepY";
            this.buttonIncrementStepY.Size = new System.Drawing.Size(30, 30);
            this.buttonIncrementStepY.TabIndex = 19;
            this.buttonIncrementStepY.Text = "+";
            this.buttonIncrementStepY.UseVisualStyleBackColor = true;
            this.buttonIncrementStepY.Click += new System.EventHandler(this.buttonIncrementStepY_Click);
            // 
            // buttonDecrementStepY
            // 
            this.buttonDecrementStepY.Location = new System.Drawing.Point(516, 49);
            this.buttonDecrementStepY.Name = "buttonDecrementStepY";
            this.buttonDecrementStepY.Size = new System.Drawing.Size(30, 30);
            this.buttonDecrementStepY.TabIndex = 18;
            this.buttonDecrementStepY.Text = "-";
            this.buttonDecrementStepY.UseVisualStyleBackColor = true;
            this.buttonDecrementStepY.Click += new System.EventHandler(this.buttonDecrementStepY_Click);
            // 
            // buttonIncrementStepX
            // 
            this.buttonIncrementStepX.Location = new System.Drawing.Point(552, 7);
            this.buttonIncrementStepX.Name = "buttonIncrementStepX";
            this.buttonIncrementStepX.Size = new System.Drawing.Size(30, 30);
            this.buttonIncrementStepX.TabIndex = 17;
            this.buttonIncrementStepX.Text = "+";
            this.buttonIncrementStepX.UseVisualStyleBackColor = true;
            this.buttonIncrementStepX.Click += new System.EventHandler(this.buttonIncrementStepX_Click);
            // 
            // buttonDecrementStepX
            // 
            this.buttonDecrementStepX.Location = new System.Drawing.Point(516, 7);
            this.buttonDecrementStepX.Name = "buttonDecrementStepX";
            this.buttonDecrementStepX.Size = new System.Drawing.Size(30, 30);
            this.buttonDecrementStepX.TabIndex = 16;
            this.buttonDecrementStepX.Text = "-";
            this.buttonDecrementStepX.UseVisualStyleBackColor = true;
            this.buttonDecrementStepX.Click += new System.EventHandler(this.buttonDecrementStepX_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Step Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Step X";
            // 
            // buttonIncrementRepeatY
            // 
            this.buttonIncrementRepeatY.Location = new System.Drawing.Point(706, 49);
            this.buttonIncrementRepeatY.Name = "buttonIncrementRepeatY";
            this.buttonIncrementRepeatY.Size = new System.Drawing.Size(30, 30);
            this.buttonIncrementRepeatY.TabIndex = 25;
            this.buttonIncrementRepeatY.Text = "+";
            this.buttonIncrementRepeatY.UseVisualStyleBackColor = true;
            this.buttonIncrementRepeatY.Click += new System.EventHandler(this.buttonIncrementRepeatY_Click);
            // 
            // buttonDecrementRepeatY
            // 
            this.buttonDecrementRepeatY.Location = new System.Drawing.Point(670, 49);
            this.buttonDecrementRepeatY.Name = "buttonDecrementRepeatY";
            this.buttonDecrementRepeatY.Size = new System.Drawing.Size(30, 30);
            this.buttonDecrementRepeatY.TabIndex = 24;
            this.buttonDecrementRepeatY.Text = "-";
            this.buttonDecrementRepeatY.UseVisualStyleBackColor = true;
            this.buttonDecrementRepeatY.Click += new System.EventHandler(this.buttonDecrementRepeatY_Click);
            // 
            // buttonIncrementRepeatX
            // 
            this.buttonIncrementRepeatX.Location = new System.Drawing.Point(706, 7);
            this.buttonIncrementRepeatX.Name = "buttonIncrementRepeatX";
            this.buttonIncrementRepeatX.Size = new System.Drawing.Size(30, 30);
            this.buttonIncrementRepeatX.TabIndex = 23;
            this.buttonIncrementRepeatX.Text = "+";
            this.buttonIncrementRepeatX.UseVisualStyleBackColor = true;
            this.buttonIncrementRepeatX.Click += new System.EventHandler(this.buttonIncrementRepeatX_Click);
            // 
            // buttonDecrementRepeatX
            // 
            this.buttonDecrementRepeatX.Location = new System.Drawing.Point(670, 7);
            this.buttonDecrementRepeatX.Name = "buttonDecrementRepeatX";
            this.buttonDecrementRepeatX.Size = new System.Drawing.Size(30, 30);
            this.buttonDecrementRepeatX.TabIndex = 22;
            this.buttonDecrementRepeatX.Text = "-";
            this.buttonDecrementRepeatX.UseVisualStyleBackColor = true;
            this.buttonDecrementRepeatX.Click += new System.EventHandler(this.buttonDecrementRepeatX_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Repeat Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(619, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Repeat X";
            // 
            // ImageProcessingPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 660);
            this.Controls.Add(this.buttonIncrementRepeatY);
            this.Controls.Add(this.buttonDecrementRepeatY);
            this.Controls.Add(this.buttonIncrementRepeatX);
            this.Controls.Add(this.buttonDecrementRepeatX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonIncrementStepY);
            this.Controls.Add(this.buttonDecrementStepY);
            this.Controls.Add(this.buttonIncrementStepX);
            this.Controls.Add(this.buttonDecrementStepX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonIncrementHeight);
            this.Controls.Add(this.buttonDecrementHeight);
            this.Controls.Add(this.buttonIncrementWidth);
            this.Controls.Add(this.buttonDecrementWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonIncrementOffsetY);
            this.Controls.Add(this.buttonDecrementOffsetY);
            this.Controls.Add(this.buttonIncrementOffsetX);
            this.Controls.Add(this.buttonDecrementOffsetX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.buttonRefresh);
            this.Name = "ImageProcessingPreviewForm";
            this.Text = "ImageProcessingPreviewForm";
            this.Load += new System.EventHandler(this.ImageProcessingPreviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDecrementOffsetX;
        private System.Windows.Forms.Button buttonIncrementOffsetX;
        private System.Windows.Forms.Button buttonIncrementOffsetY;
        private System.Windows.Forms.Button buttonDecrementOffsetY;
        private System.Windows.Forms.Button buttonIncrementHeight;
        private System.Windows.Forms.Button buttonDecrementHeight;
        private System.Windows.Forms.Button buttonIncrementWidth;
        private System.Windows.Forms.Button buttonDecrementWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonIncrementStepY;
        private System.Windows.Forms.Button buttonDecrementStepY;
        private System.Windows.Forms.Button buttonIncrementStepX;
        private System.Windows.Forms.Button buttonDecrementStepX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonIncrementRepeatY;
        private System.Windows.Forms.Button buttonDecrementRepeatY;
        private System.Windows.Forms.Button buttonIncrementRepeatX;
        private System.Windows.Forms.Button buttonDecrementRepeatX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
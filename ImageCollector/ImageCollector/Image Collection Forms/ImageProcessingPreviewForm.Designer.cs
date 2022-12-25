
namespace ImageCollector
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
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonIncrementOffsetX = new System.Windows.Forms.Button();
            this.buttonDecrementOffsetX = new System.Windows.Forms.Button();
            this.buttonDecrementWidth = new System.Windows.Forms.Button();
            this.buttonIncrementWidth = new System.Windows.Forms.Button();
            this.buttonDecrementStepX = new System.Windows.Forms.Button();
            this.buttonIncrementStepX = new System.Windows.Forms.Button();
            this.buttonDecrementAlternatingOffsetX = new System.Windows.Forms.Button();
            this.buttonIncrementAlternatingOffsetX = new System.Windows.Forms.Button();
            this.buttonDecrementOffsetY = new System.Windows.Forms.Button();
            this.buttonIncrementOffsetY = new System.Windows.Forms.Button();
            this.buttonDecrementHeight = new System.Windows.Forms.Button();
            this.buttonIncrementHeight = new System.Windows.Forms.Button();
            this.buttonDecrementStepY = new System.Windows.Forms.Button();
            this.buttonIncrementStepY = new System.Windows.Forms.Button();
            this.buttonDecrementAlternatingOffsetY = new System.Windows.Forms.Button();
            this.buttonIncrementAlternatingOffsetY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(12, 84);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(1960, 1325);
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Offset X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alternating Offset X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alternating Offset Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Step Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Offset Y";
            // 
            // buttonIncrementOffsetX
            // 
            this.buttonIncrementOffsetX.Location = new System.Drawing.Point(249, 12);
            this.buttonIncrementOffsetX.Name = "buttonIncrementOffsetX";
            this.buttonIncrementOffsetX.Size = new System.Drawing.Size(24, 24);
            this.buttonIncrementOffsetX.TabIndex = 10;
            this.buttonIncrementOffsetX.Text = "+";
            this.buttonIncrementOffsetX.UseVisualStyleBackColor = true;
            this.buttonIncrementOffsetX.Click += new System.EventHandler(this.buttonIncrementOffsetX_Click);
            // 
            // buttonDecrementOffsetX
            // 
            this.buttonDecrementOffsetX.Location = new System.Drawing.Point(219, 12);
            this.buttonDecrementOffsetX.Name = "buttonDecrementOffsetX";
            this.buttonDecrementOffsetX.Size = new System.Drawing.Size(24, 24);
            this.buttonDecrementOffsetX.TabIndex = 11;
            this.buttonDecrementOffsetX.Text = "-";
            this.buttonDecrementOffsetX.UseVisualStyleBackColor = true;
            this.buttonDecrementOffsetX.Click += new System.EventHandler(this.buttonDecrementOffsetX_Click);
            // 
            // buttonDecrementWidth
            // 
            this.buttonDecrementWidth.Location = new System.Drawing.Point(361, 11);
            this.buttonDecrementWidth.Name = "buttonDecrementWidth";
            this.buttonDecrementWidth.Size = new System.Drawing.Size(24, 24);
            this.buttonDecrementWidth.TabIndex = 13;
            this.buttonDecrementWidth.Text = "-";
            this.buttonDecrementWidth.UseVisualStyleBackColor = true;
            this.buttonDecrementWidth.Click += new System.EventHandler(this.buttonDecrementWidth_Click);
            // 
            // buttonIncrementWidth
            // 
            this.buttonIncrementWidth.Location = new System.Drawing.Point(391, 11);
            this.buttonIncrementWidth.Name = "buttonIncrementWidth";
            this.buttonIncrementWidth.Size = new System.Drawing.Size(24, 24);
            this.buttonIncrementWidth.TabIndex = 12;
            this.buttonIncrementWidth.Text = "+";
            this.buttonIncrementWidth.UseVisualStyleBackColor = true;
            this.buttonIncrementWidth.Click += new System.EventHandler(this.buttonIncrementWidth_Click);
            // 
            // buttonDecrementStepX
            // 
            this.buttonDecrementStepX.Location = new System.Drawing.Point(520, 11);
            this.buttonDecrementStepX.Name = "buttonDecrementStepX";
            this.buttonDecrementStepX.Size = new System.Drawing.Size(24, 24);
            this.buttonDecrementStepX.TabIndex = 15;
            this.buttonDecrementStepX.Text = "-";
            this.buttonDecrementStepX.UseVisualStyleBackColor = true;
            this.buttonDecrementStepX.Click += new System.EventHandler(this.buttonDecrementStepX_Click);
            // 
            // buttonIncrementStepX
            // 
            this.buttonIncrementStepX.Location = new System.Drawing.Point(550, 11);
            this.buttonIncrementStepX.Name = "buttonIncrementStepX";
            this.buttonIncrementStepX.Size = new System.Drawing.Size(24, 24);
            this.buttonIncrementStepX.TabIndex = 14;
            this.buttonIncrementStepX.Text = "+";
            this.buttonIncrementStepX.UseVisualStyleBackColor = true;
            this.buttonIncrementStepX.Click += new System.EventHandler(this.buttonIncrementStepX_Click);
            // 
            // buttonDecrementAlternatingOffsetX
            // 
            this.buttonDecrementAlternatingOffsetX.Location = new System.Drawing.Point(724, 11);
            this.buttonDecrementAlternatingOffsetX.Name = "buttonDecrementAlternatingOffsetX";
            this.buttonDecrementAlternatingOffsetX.Size = new System.Drawing.Size(24, 24);
            this.buttonDecrementAlternatingOffsetX.TabIndex = 17;
            this.buttonDecrementAlternatingOffsetX.Text = "-";
            this.buttonDecrementAlternatingOffsetX.UseVisualStyleBackColor = true;
            this.buttonDecrementAlternatingOffsetX.Click += new System.EventHandler(this.buttonDecrementAlternatingOffsetX_Click);
            // 
            // buttonIncrementAlternatingOffsetX
            // 
            this.buttonIncrementAlternatingOffsetX.Location = new System.Drawing.Point(754, 11);
            this.buttonIncrementAlternatingOffsetX.Name = "buttonIncrementAlternatingOffsetX";
            this.buttonIncrementAlternatingOffsetX.Size = new System.Drawing.Size(24, 24);
            this.buttonIncrementAlternatingOffsetX.TabIndex = 16;
            this.buttonIncrementAlternatingOffsetX.Text = "+";
            this.buttonIncrementAlternatingOffsetX.UseVisualStyleBackColor = true;
            this.buttonIncrementAlternatingOffsetX.Click += new System.EventHandler(this.buttonIncrementAlternatingOffsetX_Click);
            // 
            // buttonDecrementOffsetY
            // 
            this.buttonDecrementOffsetY.Location = new System.Drawing.Point(219, 42);
            this.buttonDecrementOffsetY.Name = "buttonDecrementOffsetY";
            this.buttonDecrementOffsetY.Size = new System.Drawing.Size(24, 24);
            this.buttonDecrementOffsetY.TabIndex = 19;
            this.buttonDecrementOffsetY.Text = "-";
            this.buttonDecrementOffsetY.UseVisualStyleBackColor = true;
            this.buttonDecrementOffsetY.Click += new System.EventHandler(this.buttonDecrementOffsetY_Click);
            // 
            // buttonIncrementOffsetY
            // 
            this.buttonIncrementOffsetY.Location = new System.Drawing.Point(249, 42);
            this.buttonIncrementOffsetY.Name = "buttonIncrementOffsetY";
            this.buttonIncrementOffsetY.Size = new System.Drawing.Size(24, 24);
            this.buttonIncrementOffsetY.TabIndex = 18;
            this.buttonIncrementOffsetY.Text = "+";
            this.buttonIncrementOffsetY.UseVisualStyleBackColor = true;
            this.buttonIncrementOffsetY.Click += new System.EventHandler(this.buttonIncrementOffsetY_Click);
            // 
            // buttonDecrementHeight
            // 
            this.buttonDecrementHeight.Location = new System.Drawing.Point(361, 42);
            this.buttonDecrementHeight.Name = "buttonDecrementHeight";
            this.buttonDecrementHeight.Size = new System.Drawing.Size(24, 24);
            this.buttonDecrementHeight.TabIndex = 21;
            this.buttonDecrementHeight.Text = "-";
            this.buttonDecrementHeight.UseVisualStyleBackColor = true;
            this.buttonDecrementHeight.Click += new System.EventHandler(this.buttonDecrementHeight_Click);
            // 
            // buttonIncrementHeight
            // 
            this.buttonIncrementHeight.Location = new System.Drawing.Point(391, 42);
            this.buttonIncrementHeight.Name = "buttonIncrementHeight";
            this.buttonIncrementHeight.Size = new System.Drawing.Size(24, 24);
            this.buttonIncrementHeight.TabIndex = 20;
            this.buttonIncrementHeight.Text = "+";
            this.buttonIncrementHeight.UseVisualStyleBackColor = true;
            this.buttonIncrementHeight.Click += new System.EventHandler(this.buttonIncrementHeight_Click);
            // 
            // buttonDecrementStepY
            // 
            this.buttonDecrementStepY.Location = new System.Drawing.Point(520, 42);
            this.buttonDecrementStepY.Name = "buttonDecrementStepY";
            this.buttonDecrementStepY.Size = new System.Drawing.Size(24, 24);
            this.buttonDecrementStepY.TabIndex = 23;
            this.buttonDecrementStepY.Text = "-";
            this.buttonDecrementStepY.UseVisualStyleBackColor = true;
            this.buttonDecrementStepY.Click += new System.EventHandler(this.buttonDecrementStepY_Click);
            // 
            // buttonIncrementStepY
            // 
            this.buttonIncrementStepY.Location = new System.Drawing.Point(550, 42);
            this.buttonIncrementStepY.Name = "buttonIncrementStepY";
            this.buttonIncrementStepY.Size = new System.Drawing.Size(24, 24);
            this.buttonIncrementStepY.TabIndex = 22;
            this.buttonIncrementStepY.Text = "+";
            this.buttonIncrementStepY.UseVisualStyleBackColor = true;
            this.buttonIncrementStepY.Click += new System.EventHandler(this.buttonIncrementStepY_Click);
            // 
            // buttonDecrementAlternatingOffsetY
            // 
            this.buttonDecrementAlternatingOffsetY.Location = new System.Drawing.Point(724, 42);
            this.buttonDecrementAlternatingOffsetY.Name = "buttonDecrementAlternatingOffsetY";
            this.buttonDecrementAlternatingOffsetY.Size = new System.Drawing.Size(24, 24);
            this.buttonDecrementAlternatingOffsetY.TabIndex = 25;
            this.buttonDecrementAlternatingOffsetY.Text = "-";
            this.buttonDecrementAlternatingOffsetY.UseVisualStyleBackColor = true;
            this.buttonDecrementAlternatingOffsetY.Click += new System.EventHandler(this.buttonDecrementAlternatingOffsetY_Click);
            // 
            // buttonIncrementAlternatingOffsetY
            // 
            this.buttonIncrementAlternatingOffsetY.Location = new System.Drawing.Point(754, 42);
            this.buttonIncrementAlternatingOffsetY.Name = "buttonIncrementAlternatingOffsetY";
            this.buttonIncrementAlternatingOffsetY.Size = new System.Drawing.Size(24, 24);
            this.buttonIncrementAlternatingOffsetY.TabIndex = 24;
            this.buttonIncrementAlternatingOffsetY.Text = "+";
            this.buttonIncrementAlternatingOffsetY.UseVisualStyleBackColor = true;
            this.buttonIncrementAlternatingOffsetY.Click += new System.EventHandler(this.buttonIncrementAlternatingOffsetY_Click);
            // 
            // ImageProcessingPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1984, 1421);
            this.Controls.Add(this.buttonDecrementAlternatingOffsetY);
            this.Controls.Add(this.buttonIncrementAlternatingOffsetY);
            this.Controls.Add(this.buttonDecrementStepY);
            this.Controls.Add(this.buttonIncrementStepY);
            this.Controls.Add(this.buttonDecrementHeight);
            this.Controls.Add(this.buttonIncrementHeight);
            this.Controls.Add(this.buttonDecrementOffsetY);
            this.Controls.Add(this.buttonIncrementOffsetY);
            this.Controls.Add(this.buttonDecrementAlternatingOffsetX);
            this.Controls.Add(this.buttonIncrementAlternatingOffsetX);
            this.Controls.Add(this.buttonDecrementStepX);
            this.Controls.Add(this.buttonIncrementStepX);
            this.Controls.Add(this.buttonDecrementWidth);
            this.Controls.Add(this.buttonIncrementWidth);
            this.Controls.Add(this.buttonDecrementOffsetX);
            this.Controls.Add(this.buttonIncrementOffsetX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.pictureBoxPreview);
            this.Name = "ImageProcessingPreviewForm";
            this.Text = "ImageProcessingPreviewForm";
            this.Load += new System.EventHandler(this.ImageProcessingPreviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonIncrementOffsetX;
        private System.Windows.Forms.Button buttonDecrementOffsetX;
        private System.Windows.Forms.Button buttonDecrementWidth;
        private System.Windows.Forms.Button buttonIncrementWidth;
        private System.Windows.Forms.Button buttonDecrementStepX;
        private System.Windows.Forms.Button buttonIncrementStepX;
        private System.Windows.Forms.Button buttonDecrementAlternatingOffsetX;
        private System.Windows.Forms.Button buttonIncrementAlternatingOffsetX;
        private System.Windows.Forms.Button buttonDecrementOffsetY;
        private System.Windows.Forms.Button buttonIncrementOffsetY;
        private System.Windows.Forms.Button buttonDecrementHeight;
        private System.Windows.Forms.Button buttonIncrementHeight;
        private System.Windows.Forms.Button buttonDecrementStepY;
        private System.Windows.Forms.Button buttonIncrementStepY;
        private System.Windows.Forms.Button buttonDecrementAlternatingOffsetY;
        private System.Windows.Forms.Button buttonIncrementAlternatingOffsetY;
    }
}
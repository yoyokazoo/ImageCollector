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
            // ImageCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonListProcessNames);
            this.Name = "ImageCollectionForm";
            this.Text = "ImageCollectionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListProcessNames;
    }
}
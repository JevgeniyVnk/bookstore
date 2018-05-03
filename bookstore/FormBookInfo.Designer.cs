namespace bookstore
{
    partial class FormBookInfo
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
            this.pb_BookImage = new System.Windows.Forms.PictureBox();
            this.lbl_BookDescribtion = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_BookImage
            // 
            this.pb_BookImage.Location = new System.Drawing.Point(299, 65);
            this.pb_BookImage.Name = "pb_BookImage";
            this.pb_BookImage.Size = new System.Drawing.Size(268, 320);
            this.pb_BookImage.TabIndex = 0;
            this.pb_BookImage.TabStop = false;
            // 
            // lbl_BookDescribtion
            // 
            this.lbl_BookDescribtion.AutoSize = true;
            this.lbl_BookDescribtion.Location = new System.Drawing.Point(42, 51);
            this.lbl_BookDescribtion.Name = "lbl_BookDescribtion";
            this.lbl_BookDescribtion.Size = new System.Drawing.Size(82, 13);
            this.lbl_BookDescribtion.TabIndex = 1;
            this.lbl_BookDescribtion.Text = "Инфа по книге";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(30, 362);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Закрыть";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // FormBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 406);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_BookDescribtion);
            this.Controls.Add(this.pb_BookImage);
            this.Name = "FormBookInfo";
            this.Text = "FormBookInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pb_BookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_BookImage;
        private System.Windows.Forms.Label lbl_BookDescribtion;
        private System.Windows.Forms.Button btn_Close;
    }
}
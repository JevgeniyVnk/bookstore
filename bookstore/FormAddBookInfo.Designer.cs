namespace bookstore
{
    partial class FormAddBookInfo
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
            this.tb_BookName = new System.Windows.Forms.TextBox();
            this.tb_BookCount = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tb_BookAuthor = new System.Windows.Forms.TextBox();
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_BookPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_WriteBookInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_BookName
            // 
            this.tb_BookName.Location = new System.Drawing.Point(70, 46);
            this.tb_BookName.Name = "tb_BookName";
            this.tb_BookName.Size = new System.Drawing.Size(100, 20);
            this.tb_BookName.TabIndex = 0;
            // 
            // tb_BookCount
            // 
            this.tb_BookCount.Location = new System.Drawing.Point(70, 188);
            this.tb_BookCount.Name = "tb_BookCount";
            this.tb_BookCount.Size = new System.Drawing.Size(100, 20);
            this.tb_BookCount.TabIndex = 1;
            this.tb_BookCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_BookCount_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(70, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // tb_BookAuthor
            // 
            this.tb_BookAuthor.Location = new System.Drawing.Point(70, 96);
            this.tb_BookAuthor.Name = "tb_BookAuthor";
            this.tb_BookAuthor.Size = new System.Drawing.Size(100, 20);
            this.tb_BookAuthor.TabIndex = 4;
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.Location = new System.Drawing.Point(70, 27);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(89, 13);
            this.lbl_BookName.TabIndex = 5;
            this.lbl_BookName.Text = "Название книги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Автор книги";
            // 
            // lbl_BookPrice
            // 
            this.lbl_BookPrice.AutoSize = true;
            this.lbl_BookPrice.Location = new System.Drawing.Point(70, 121);
            this.lbl_BookPrice.Name = "lbl_BookPrice";
            this.lbl_BookPrice.Size = new System.Drawing.Size(65, 13);
            this.lbl_BookPrice.TabIndex = 7;
            this.lbl_BookPrice.Text = "Цена книги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Кол-во экземпляров на складе";
            // 
            // btn_WriteBookInfo
            // 
            this.btn_WriteBookInfo.Location = new System.Drawing.Point(70, 247);
            this.btn_WriteBookInfo.Name = "btn_WriteBookInfo";
            this.btn_WriteBookInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_WriteBookInfo.TabIndex = 9;
            this.btn_WriteBookInfo.Text = "Добавить";
            this.btn_WriteBookInfo.UseVisualStyleBackColor = true;
            this.btn_WriteBookInfo.Click += new System.EventHandler(this.btn_WriteBookInfo_Click);
            // 
            // FormAddBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_WriteBookInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_BookPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_BookName);
            this.Controls.Add(this.tb_BookAuthor);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tb_BookCount);
            this.Controls.Add(this.tb_BookName);
            this.Name = "FormAddBookInfo";
            this.Text = "FormAddBookInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_BookName;
        private System.Windows.Forms.TextBox tb_BookCount;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tb_BookAuthor;
        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_BookPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_WriteBookInfo;
    }
}
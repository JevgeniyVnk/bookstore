﻿namespace bookstore
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tb_SearchBook = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.panelDescribtion = new System.Windows.Forms.Panel();
            this.lbl_Describtion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ts_OrderBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_SellBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Statistics = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ChangeDb = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_UpdateDb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsItem_UpdateBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.базаПроданныхКнигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДляЗаказчикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelDescribtion.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(400, 42);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(398, 408);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.Leave += new System.EventHandler(this.dataGridView_Leave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openStorageDialog";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(9, 425);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(130, 425);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(236, 423);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(317, 423);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Выйти";
            this.btn_Logout.UseMnemonic = false;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(400, 418);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(398, 32);
            this.progressBar.TabIndex = 7;
            // 
            // tb_SearchBook
            // 
            this.tb_SearchBook.Location = new System.Drawing.Point(9, 58);
            this.tb_SearchBook.Name = "tb_SearchBook";
            this.tb_SearchBook.Size = new System.Drawing.Size(265, 20);
            this.tb_SearchBook.TabIndex = 8;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(6, 40);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(107, 13);
            this.lbl_Search.TabIndex = 9;
            this.lbl_Search.Text = "Поиск книги в базе";
            // 
            // panelDescribtion
            // 
            this.panelDescribtion.BackColor = System.Drawing.SystemColors.Info;
            this.panelDescribtion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDescribtion.Controls.Add(this.lbl_Describtion);
            this.panelDescribtion.Location = new System.Drawing.Point(12, 94);
            this.panelDescribtion.Name = "panelDescribtion";
            this.panelDescribtion.Size = new System.Drawing.Size(369, 292);
            this.panelDescribtion.TabIndex = 10;
            // 
            // lbl_Describtion
            // 
            this.lbl_Describtion.AutoSize = true;
            this.lbl_Describtion.Location = new System.Drawing.Point(19, 9);
            this.lbl_Describtion.Name = "lbl_Describtion";
            this.lbl_Describtion.Size = new System.Drawing.Size(0, 13);
            this.lbl_Describtion.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_OrderBooks,
            this.ts_SellBooks,
            this.ts_Statistics,
            this.ts_ChangeDb,
            this.ts_UpdateDb});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip";
            // 
            // ts_OrderBooks
            // 
            this.ts_OrderBooks.Name = "ts_OrderBooks";
            this.ts_OrderBooks.Size = new System.Drawing.Size(77, 20);
            this.ts_OrderBooks.Text = "Заказ книг";
            this.ts_OrderBooks.Click += new System.EventHandler(this.ts_OrderBooks_Click);
            // 
            // ts_SellBooks
            // 
            this.ts_SellBooks.Name = "ts_SellBooks";
            this.ts_SellBooks.Size = new System.Drawing.Size(104, 20);
            this.ts_SellBooks.Text = "Продажа книги";
            this.ts_SellBooks.Click += new System.EventHandler(this.ts_SellBooks_Click);
            // 
            // ts_Statistics
            // 
            this.ts_Statistics.Name = "ts_Statistics";
            this.ts_Statistics.Size = new System.Drawing.Size(80, 20);
            this.ts_Statistics.Text = "Статистика";
            this.ts_Statistics.Click += new System.EventHandler(this.ts_Statistics_Click);
            // 
            // ts_ChangeDb
            // 
            this.ts_ChangeDb.Name = "ts_ChangeDb";
            this.ts_ChangeDb.Size = new System.Drawing.Size(114, 20);
            this.ts_ChangeDb.Text = "Смена бд(админ)";
            // 
            // ts_UpdateDb
            // 
            this.ts_UpdateDb.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsItem_UpdateBooks,
            this.базаПроданныхКнигToolStripMenuItem,
            this.базаДляЗаказчикаToolStripMenuItem});
            this.ts_UpdateDb.Name = "ts_UpdateDb";
            this.ts_UpdateDb.Size = new System.Drawing.Size(100, 20);
            this.ts_UpdateDb.Text = "Обновить базу";
            this.ts_UpdateDb.Click += new System.EventHandler(this.ts_UpdateDb_Click);
            // 
            // tsItem_UpdateBooks
            // 
            this.tsItem_UpdateBooks.Name = "tsItem_UpdateBooks";
            this.tsItem_UpdateBooks.Size = new System.Drawing.Size(190, 22);
            this.tsItem_UpdateBooks.Text = "База магазина";
            this.tsItem_UpdateBooks.Click += new System.EventHandler(this.tsItem_UpdateBooks_Click);
            // 
            // базаПроданныхКнигToolStripMenuItem
            // 
            this.базаПроданныхКнигToolStripMenuItem.Name = "базаПроданныхКнигToolStripMenuItem";
            this.базаПроданныхКнигToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.базаПроданныхКнигToolStripMenuItem.Text = "База проданных книг";
            // 
            // базаДляЗаказчикаToolStripMenuItem
            // 
            this.базаДляЗаказчикаToolStripMenuItem.Name = "базаДляЗаказчикаToolStripMenuItem";
            this.базаДляЗаказчикаToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.базаДляЗаказчикаToolStripMenuItem.Text = "База для заказчика";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(306, 56);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "Искать";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.panelDescribtion);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.tb_SearchBook);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главная форма(временно)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelDescribtion.ResumeLayout(false);
            this.panelDescribtion.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox tb_SearchBook;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Panel panelDescribtion;
        private System.Windows.Forms.Label lbl_Describtion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ts_OrderBooks;
        private System.Windows.Forms.ToolStripMenuItem ts_SellBooks;
        private System.Windows.Forms.ToolStripMenuItem ts_Statistics;
        private System.Windows.Forms.ToolStripMenuItem ts_ChangeDb;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ToolStripMenuItem ts_UpdateDb;
        private System.Windows.Forms.ToolStripMenuItem tsItem_UpdateBooks;
        private System.Windows.Forms.ToolStripMenuItem базаПроданныхКнигToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаДляЗаказчикаToolStripMenuItem;
    }
}


namespace bookstore
{
    partial class OrderBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderBooks));
            this.navigationMenu = new System.Windows.Forms.MenuStrip();
            this.наГлавнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажаКнигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toExcelBtTool = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toExcelItTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.orderPostBtTool = new System.Windows.Forms.ToolStripMenuItem();
            this.orderBtTool = new System.Windows.Forms.ToolStripMenuItem();
            this.addBtTool = new System.Windows.Forms.ToolStripButton();
            this.deleteBtTool = new System.Windows.Forms.ToolStripButton();
            this.currentListLbTool = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.orderList = new System.Windows.Forms.DataGridView();
            this.navigationMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationMenu
            // 
            this.navigationMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navigationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наГлавнуюToolStripMenuItem,
            this.продажаКнигToolStripMenuItem,
            this.статистикаToolStripMenuItem});
            this.navigationMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.navigationMenu.Location = new System.Drawing.Point(0, 0);
            this.navigationMenu.Name = "navigationMenu";
            this.navigationMenu.Size = new System.Drawing.Size(800, 24);
            this.navigationMenu.TabIndex = 0;
            this.navigationMenu.Text = "menuStrip1";
            // 
            // наГлавнуюToolStripMenuItem
            // 
            this.наГлавнуюToolStripMenuItem.Name = "наГлавнуюToolStripMenuItem";
            this.наГлавнуюToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.наГлавнуюToolStripMenuItem.Text = "На главную";
            // 
            // продажаКнигToolStripMenuItem
            // 
            this.продажаКнигToolStripMenuItem.Name = "продажаКнигToolStripMenuItem";
            this.продажаКнигToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.продажаКнигToolStripMenuItem.Text = "Продажа книг";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBtTool,
            this.deleteBtTool,
            this.toolStripSeparator1,
            this.toExcelBtTool,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripDropDownButton2,
            this.currentListLbTool});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toExcelBtTool
            // 
            this.toExcelBtTool.Name = "toExcelBtTool";
            this.toExcelBtTool.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toExcelItTool});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(106, 24);
            this.toolStripDropDownButton1.Text = "Выгрузить в";
            // 
            // toExcelItTool
            // 
            this.toExcelItTool.Name = "toExcelItTool";
            this.toExcelItTool.Size = new System.Drawing.Size(152, 24);
            this.toExcelItTool.Text = "Excel";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderBtTool,
            this.orderPostBtTool});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(130, 24);
            this.toolStripDropDownButton2.Text = "Список заказов";
            // 
            // orderPostBtTool
            // 
            this.orderPostBtTool.Name = "orderPostBtTool";
            this.orderPostBtTool.Size = new System.Drawing.Size(232, 24);
            this.orderPostBtTool.Text = "Заказ поставщику";
            this.orderPostBtTool.Click += new System.EventHandler(this.orderPostBtTool_Click);
            // 
            // orderBtTool
            // 
            this.orderBtTool.Name = "orderBtTool";
            this.orderBtTool.Size = new System.Drawing.Size(232, 24);
            this.orderBtTool.Text = "Заказ потенциальный";
            this.orderBtTool.Click += new System.EventHandler(this.orderBtTool_Click);
            // 
            // addBtTool
            // 
            this.addBtTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addBtTool.Image = ((System.Drawing.Image)(resources.GetObject("addBtTool.Image")));
            this.addBtTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBtTool.Name = "addBtTool";
            this.addBtTool.Size = new System.Drawing.Size(80, 24);
            this.addBtTool.Text = "Добавить";
            // 
            // deleteBtTool
            // 
            this.deleteBtTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteBtTool.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtTool.Image")));
            this.deleteBtTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtTool.Name = "deleteBtTool";
            this.deleteBtTool.Size = new System.Drawing.Size(69, 24);
            this.deleteBtTool.Text = "Удалить";
            // 
            // currentListLbTool
            // 
            this.currentListLbTool.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.currentListLbTool.BackColor = System.Drawing.SystemColors.Control;
            this.currentListLbTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.currentListLbTool.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.currentListLbTool.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentListLbTool.Name = "currentListLbTool";
            this.currentListLbTool.Size = new System.Drawing.Size(140, 24);
            this.currentListLbTool.Text = "Заказ поставщику";
            this.currentListLbTool.Click += new System.EventHandler(this.currentListLbTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // orderList
            // 
            this.orderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderList.Location = new System.Drawing.Point(0, 51);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(800, 399);
            this.orderList.TabIndex = 2;
            // 
            // OrderBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.navigationMenu);
            this.MainMenuStrip = this.navigationMenu;
            this.Name = "OrderBooks";
            this.Text = "OrderBooks";
            this.navigationMenu.ResumeLayout(false);
            this.navigationMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navigationMenu;
        private System.Windows.Forms.ToolStripMenuItem наГлавнуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажаКнигToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toExcelBtTool;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem orderBtTool;
        private System.Windows.Forms.ToolStripMenuItem orderPostBtTool;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toExcelItTool;
        private System.Windows.Forms.ToolStripButton addBtTool;
        private System.Windows.Forms.ToolStripButton deleteBtTool;
        private System.Windows.Forms.ToolStripLabel currentListLbTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView orderList;
    }
}
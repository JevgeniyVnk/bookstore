using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore
{
    public partial class MainForm : Form
    {
        private Provider _provider;
        public MainForm()
        {
            InitializeComponent();
            _provider = new Provider();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task LoginAsync(IProgress<int> progress)
        {
            progress?.Report(0);
            try
            {
                string pathToDb = Application.StartupPath + @"\storages\BooksStorage.xml";
                await _provider.ReadDbData(tbName.Text, tbPassword.Text, pathToDb);
                DataSet dataset = _provider.GetDataSet();
                dataGridView.DataSource = dataset.Tables[0];
                dataGridView.Update();
                UsersHelper.IsLogged = true;
            }
            finally
            { 
                progress.Report(100);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(value =>
            {
                progressBar.Value = value;
            });

            Task.Run(async () => await LoginAsync(progress));
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            UsersHelper.IsLogged = false;
        }

        private void ts_OrderBooks_Click(object sender, EventArgs e)
        {

        }

        private void ts_SellBooks_Click(object sender, EventArgs e)
        {

        }

        private void ts_Statistics_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                //подправить
                if(row.Cells["name"].Value.ToString().Contains(tb_SearchBook.Text)) {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //вывести описание книги
        }
    }
}

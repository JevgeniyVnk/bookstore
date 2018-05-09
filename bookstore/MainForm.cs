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
            dataGridView.BackgroundColor = dataGridView.DefaultCellStyle.BackColor;
            panelDescribtion.Hide();
            btn_Logout.Enabled = false;
        }

        private async Task LoginAsync(IProgress<int> progress)
        {
            progress?.Report(0);
            try
            {
                //TODO хранить где нибудь залониненного пользователя
                if (!UsersHelper.IsAdmin(tbName.Text, tbPassword.Text) ||
                    !UsersHelper.IsUser(tbName.Text, tbPassword.Text))
                {
                    MessageBox.Show("Не удалось авторизоваться");
                    return;
                }
                btnLogin.Enabled = false;
                string pathToDb = Application.StartupPath + @"\storages\BooksStorage.xml";
                await _provider.ReadDbData(tbName.Text, tbPassword.Text, pathToDb);
                DataSet dataset = _provider.GetDataSet();
                dataGridView.BeginInvoke((MethodInvoker)(() => 
                {
                    dataGridView.DataSource = dataset.Tables[0];
                    dataGridView.Columns["describtion"].Visible = false;
                    dataGridView.Update();
                    UsersHelper.IsLogged = true;
                }));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
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
            btnLogin.Enabled = true;
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
                    FillDescribtion(row.Index);
                    break;
                }
            }
        }

        private void FillDescribtion(int rowIndex)
        {
            Book selectedBook = _provider.GetBook(rowIndex);
            string describtion = "";
            if (selectedBook == null)
            {
                panelDescribtion.Hide();
                return;
            }
            panelDescribtion.Show();
            describtion = String.Format
            (
                "Название: {0} \n" +
                "Автор: {1} \n" +
                "Цена: {2} \n" +
                "Количество экземпляров: {3} \n" +
                "Описание книги: {4} \n",
                selectedBook.Name, selectedBook.Author,
                selectedBook.Price, selectedBook.Count,
                selectedBook.Describtion
            );

            lbl_Describtion.Text = describtion;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //вывести описание книги
            FillDescribtion(e.RowIndex);
        }

        private void dataGridView_Leave(object sender, EventArgs e)
        {
            panelDescribtion.Hide();
        }

        private void ts_UpdateDb_Click(object sender, EventArgs e)
        {
            //можно выпилить в принципе
        }

        private void tsItem_UpdateBooks_Click(object sender, EventArgs e)
        {
            //выбор бд, которую хотим засейвить и сейв через провайдер
        }
    }
}

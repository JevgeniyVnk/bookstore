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
    public partial class OrderBooks : Form
    {
        Provider _order;
        Provider _orderPotencial;

        public OrderBooks()
        {
            InitializeComponent();
            _order = new Provider();
            _orderPotencial = new Provider();
            currentListLbTool.Text = "-";
            orderList.Font = new Font("Tahoma", 10);

        }

        private void orderBtTool_Click(object sender, EventArgs e)
        {
           


            Task<bool> loadOrderPotential = Task.Run(async () => await loadOrderPoteintialAsync());
            loadOrderPotential.Wait();

            currentListLbTool.Text = "Заказ потенциальный";
        }

        private void orderPostBtTool_Click(object sender, EventArgs e)
        {
         

            Task<bool> loadOrder = Task.Run(async () => await loadOrderAsync());
            loadOrder.Wait();

            currentListLbTool.Text = "Заказ поставщику";
        }

        private void deleteBtTool_Click(object sender, EventArgs e)
        {

        }

        private void currentListLbTool_Click(object sender, EventArgs e)
        {

        }


        private async Task<bool> loadOrderAsync()
        {
          
            try
            {

                string pathToDb = Application.StartupPath + @"\storages\Order.xml";
                await _order.ReadDbData("TyotaZina", "123123", pathToDb);
                DataSet dataset = _order.GetDataSet();
                orderList.BeginInvoke((MethodInvoker)(() =>
                {
                   
                    orderList.DataSource = dataset.Tables[0];
                    orderList.Columns["describtion"].Visible = false;
                    orderList.Update();
                   
                }));

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return true;
        }

        private async Task<bool> loadOrderPoteintialAsync()
        {
        
            try
            {
               
                string pathToDb = Application.StartupPath + @"\storages\PotentialOrder.xml";
                await _orderPotencial.ReadDbData("TyotaZina", "123123", pathToDb);
                DataSet dataset = _orderPotencial.GetDataSet();
                orderList.BeginInvoke((MethodInvoker)(() =>
                {
                 
                    orderList.DataSource = dataset.Tables[0];
                    orderList.Columns["describtion"].Visible = false;
                    orderList.Update();
                    
                }));

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return true;
        }
    }
}

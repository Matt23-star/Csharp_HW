using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OrderService;

namespace OrderForms
{
    public partial class FormShowOrder : Form
    {
        public String SearchMassage { get; set; }
        
        public FormShowOrder()
        {
            InitializeComponent();
            Cargo cargo1 = new Cargo("鱼肉", "001", 23.3);
            Cargo cargo2 = new Cargo("白菜", "002", 2.3);
            Cargo[] cargos = { cargo1, cargo2 };
            OrderService.OrderService.AddOrder(new Order(001, new Client("张三", "1111", "武汉大学")).AddOrderDetails(new OrderDetails(cargos[0], 3))
                .AddOrderDetails(new OrderDetails(cargos[1], 4)));
            OrderService.OrderService.AddOrder(new Order(002, new Client("李四", "2222", "武汉大学")).AddOrderDetails(new OrderDetails(cargos[0], 5)));
            OrderService.OrderService.AddOrder(new Order(003, new Client("王五", "3333", "武汉大学")).AddOrderDetails(new OrderDetails(cargos[1], 4)));
            this.searchWay.SelectedIndex = 0;
            orderBindingSource.DataSource = OrderService.OrderService.orderList;
            this.textBoxMessage.DataBindings.Add("Text", this, "SearchMassage");
        }
            

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            switch (this.searchWay.SelectedIndex)
            {
                case 0:
                    orderBindingSource.DataSource = OrderService.OrderService.orderList;
                    break;
                case 1: long.TryParse(SearchMassage, out long number);
                    orderBindingSource.DataSource = OrderService.OrderService.QueryByNumber(number);
                    if (orderBindingSource.DataSource == null)
                    {
                        MessageBox.Show("没找到订单");
                    }
                    break;
                case 2:
                    orderBindingSource.DataSource = OrderService.OrderService.QueryByClientName(SearchMassage);
                    if (orderBindingSource.DataSource == null)
                    {
                        MessageBox.Show("没找到订单");
                    }
                    break;
                case 3:
                    orderBindingSource.DataSource = OrderService.OrderService.QueryByCargoName(SearchMassage);
                    if (orderBindingSource.DataSource == null)
                    {
                        MessageBox.Show("没找到订单");
                    }
                    break;
                case 4:
                    double.TryParse(SearchMassage, out double totalHigh);
                    orderBindingSource.DataSource = OrderService.OrderService.SuperThanTotal(totalHigh);
                    if (orderBindingSource.DataSource == null)
                    {
                        MessageBox.Show("没找到订单");
                    }
                    break;
                case 5:
                    double.TryParse(SearchMassage, out double totalLow);
                    orderBindingSource.DataSource = OrderService.OrderService.LowerThanTotal(totalLow);
                    if (orderBindingSource.DataSource == null)
                    {
                        MessageBox.Show("没找到订单");
                    }
                    break;
                default:
                    break;
            }
            orderBindingSource.ResetBindings(false);
            this.textBoxMessage.Text = "";
        }

        private void modify_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            FormAddOrder formAddOrder = new FormAddOrder(order);
            formAddOrder.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            if(order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            OrderService.OrderService.DeleteOrder(order.OrderNumber);
            orderBindingSource.ResetBindings(false);
        }

        private void 添加订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddOrder formAddOrder = new FormAddOrder(new Order());
            formAddOrder.Show();
            orderBindingSource.DataSource = OrderService.OrderService.orderList;
        }
    }
}

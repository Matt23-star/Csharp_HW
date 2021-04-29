using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderService;

namespace OrderForms
{
    public partial class FormAddOrder : Form
    {
        public Order Order { get; set; }
        public Client[] Clients { get; set; } = { new Client("张三", "1111", "武汉大学") ,
            new Client("李四", "2222", "武汉大学"),
            new Client("王五", "3333", "武汉大学")
        };
        public FormAddOrder(Order order)
        {
            InitializeComponent();
            clientBindingSource.Add(new Client("张三", "1111", "武汉大学"));
            clientBindingSource.Add(new Client("李四", "2222", "武汉大学"));
            clientBindingSource.Add(new Client("王五", "3333", "武汉大学"));
            Order = order;
            if (Order.Equals(null))
            {
                this.OrderId.Text = Order.OrderNumber.ToString();
            }
            orderBindingSource.Add(Order);
            clients.ValueMember = "Name";
        }

        private void addDetail_Click(object sender, EventArgs e)
        {
            FormAddDetail formAddDetail = new FormAddDetail();
            formAddDetail.Visible = false;
            formAddDetail.Show();
            try
            {
                if (formAddDetail.Visible)
                {
                    formAddDetail.Visible = false;
                    if (formAddDetail.ShowDialog() == DialogResult.OK)
                    {
                        Order.AddOrderDetails(formAddDetail.OrderDetails);
                    }
                }
                detailsBindingSource.ResetBindings(false);
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void saveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order.Client = this.Clients[clients.SelectedIndex];
                Order.OrderNumber = long.Parse(OrderId.Text);
                OrderService.OrderService.AddOrder(Order);
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("请将信息填写完整");
            }
        }

        private void deleteDetail_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = detailsBindingSource.Current as OrderDetails;
            if (orderDetails == null)
            {
                MessageBox.Show("请选择订单明细进行删除");
                return;
            }
            Order.DeleteOrderDetails(orderDetails.Cargo);
            orderBindingSource.ResetBindings(false);
        }
    }
}

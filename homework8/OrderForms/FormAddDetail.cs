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
    public partial class FormAddDetail : Form
    {
        private String salesVolume =" ";
        Cargo[] cargos = { new Cargo("白菜", "002", 2.3), new Cargo("鱼肉", "001", 23.3) };
        public OrderDetails OrderDetails { get; set; }
        public FormAddDetail()
        {
            InitializeComponent();
            cargoBindingSource.Add(cargos[0]);
            cargoBindingSource.Add(cargos[1]);
            cargo.ValueMember = "CargoName";
        }

        private void saveDetail_Click(object sender, EventArgs e)
        {
            salesVolume = this.SalesVolume.Text;
            OrderDetails = new OrderDetails(cargos[cargo.SelectedIndex], int.Parse(salesVolume));
            this.Close();
        }

        private void cargoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

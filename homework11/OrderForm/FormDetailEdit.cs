using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderFunction;

namespace OrderForm {
  public partial class FormDetailEdit : Form {
    public OrderDetails Detail { get; set; }

    public FormDetailEdit() {
      InitializeComponent();
    }

    public FormDetailEdit(OrderDetails detail):this() {
      this.Detail = detail;
      this.bdsDetail.DataSource = detail;
      using (OrderContext context = new OrderContext()) {
        bdsGoods.DataSource = context.Cargos.ToList();
      }
    }

  }
}

using OrderFunction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm {
  public partial class FormEdit : Form {
    private OrderService orderService;
    private bool editModel;

    public Order CurrentOrder { get; set; }
    public Action<FormEdit> CloseEditFrom { get; set; }

    public FormEdit(Order order, bool model, OrderService orderService) {
      InitializeComponent();
      using (OrderContext ctx =new OrderContext()) {
        bdsCustomers.DataSource= ctx.Clients.ToList(); 
      }
      this.orderService = orderService;
      this.editModel = model;

      //TODO 如果想实现不点保存只关窗口后订单不变化，需要把order深克隆给CurrentOrder
      this.CurrentOrder = order;
      bdsOrders.DataSource = CurrentOrder;
      
      txtOrderId.Enabled = !model;
      if (!model) {
        CurrentOrder.Client = (Client)bdsCustomers.Current;
      }
    }

    private void btnAddItem_Click(object sender, EventArgs e) {
      FormDetailEdit formItemEdit = new FormDetailEdit(new OrderDetails());
      try {
        if (formItemEdit.ShowDialog() == DialogResult.OK) {
          int index = 0;
          if (CurrentOrder.OrderDetailsList.Count != 0) {
            index = CurrentOrder.OrderDetailsList.Max(i => i.Index) + 1;
          }
          formItemEdit.Detail.Index = index;
          CurrentOrder.AddOrderDetails(formItemEdit.Detail);
          bdsDetails.ResetBindings(false);
        }
      }catch (Exception e2) {
        MessageBox.Show(e2.Message);
      }
    }

    private void btnSave_Click(object sender, EventArgs e) {
      try {
        if (this.editModel) {
        }else {
          OrderService.AddOrder(CurrentOrder);
        }
        CloseEditFrom(this);
      }catch (Exception e1) {
        MessageBox.Show(e1.InnerException.Message);
      }

    }

    private void btnEditItem_Click(object sender, EventArgs e) {
      EditDetail();
    }

    private void dgvItems_DoubleClick(object sender, EventArgs e) {
      EditDetail();
    }

    private void EditDetail() {
      OrderDetails detail = bdsDetails.Current as OrderDetails;
      if (detail == null) {
        MessageBox.Show("请选择一个订单项进行修改");
        return;
      }
      FormDetailEdit formDetailEdit = new FormDetailEdit(detail);
      if (formDetailEdit.ShowDialog() == DialogResult.OK) {
        bdsDetails.ResetBindings(false);
      }
    }

    private void btnDeleteItem_Click(object sender, EventArgs e) {
      OrderDetails detail = bdsDetails.Current as OrderDetails;
      if (detail == null) {
        MessageBox.Show("请选择一个订单项进行删除");
        return;
      }
      CurrentOrder.DeleteOrderDetails(detail.Cargo);
      bdsDetails.ResetBindings(false);
    }

    
  }
}

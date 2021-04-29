
namespace OrderForms
{
    partial class FormAddOrder
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clients = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.cargoNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoUnitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteDetail = new System.Windows.Forms.Button();
            this.addDetail = new System.Windows.Forms.Button();
            this.saveOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1174, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.clients, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OrderId, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 34);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1162, 160);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // clients
            // 
            this.clients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clients.DataSource = this.clientBindingSource;
            this.clients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clients.FormattingEnabled = true;
            this.clients.Location = new System.Drawing.Point(238, 104);
            this.clients.Margin = new System.Windows.Forms.Padding(6);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(918, 32);
            this.clients.TabIndex = 1;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(OrderService.Client);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(144, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 80);
            this.label2.TabIndex = 7;
            this.label2.Text = "订单号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(168, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 80);
            this.label1.TabIndex = 6;
            this.label1.Text = "客户";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderId
            // 
            this.OrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderId.Location = new System.Drawing.Point(238, 22);
            this.OrderId.Margin = new System.Windows.Forms.Padding(6);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(918, 35);
            this.OrderId.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvItems);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 200);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1174, 379);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单明细";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cargoNameDataGridViewTextBoxColumn,
            this.salesVolumeDataGridViewTextBoxColumn,
            this.cargoUnitPriceDataGridViewTextBoxColumn,
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn});
            this.dgvItems.DataSource = this.detailsBindingSource;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(6, 34);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(6);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 82;
            this.dgvItems.RowTemplate.Height = 23;
            this.dgvItems.Size = new System.Drawing.Size(1162, 339);
            this.dgvItems.TabIndex = 0;
            // 
            // cargoNameDataGridViewTextBoxColumn
            // 
            this.cargoNameDataGridViewTextBoxColumn.DataPropertyName = "CargoName";
            this.cargoNameDataGridViewTextBoxColumn.HeaderText = "货物名";
            this.cargoNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cargoNameDataGridViewTextBoxColumn.Name = "cargoNameDataGridViewTextBoxColumn";
            this.cargoNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargoNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // salesVolumeDataGridViewTextBoxColumn
            // 
            this.salesVolumeDataGridViewTextBoxColumn.DataPropertyName = "SalesVolume";
            this.salesVolumeDataGridViewTextBoxColumn.HeaderText = "数量";
            this.salesVolumeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.salesVolumeDataGridViewTextBoxColumn.Name = "salesVolumeDataGridViewTextBoxColumn";
            this.salesVolumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesVolumeDataGridViewTextBoxColumn.Width = 130;
            // 
            // cargoUnitPriceDataGridViewTextBoxColumn
            // 
            this.cargoUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "CargoUnitPrice";
            this.cargoUnitPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.cargoUnitPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cargoUnitPriceDataGridViewTextBoxColumn.Name = "cargoUnitPriceDataGridViewTextBoxColumn";
            this.cargoUnitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargoUnitPriceDataGridViewTextBoxColumn.Width = 130;
            // 
            // totalOrderDetailsAmountDataGridViewTextBoxColumn
            // 
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalOrderDetailsAmount";
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn.Name = "totalOrderDetailsAmountDataGridViewTextBoxColumn";
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn.Width = 130;
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "OrderDetailsList";
            this.detailsBindingSource.DataSource = this.orderBindingSource;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderService.Order);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteDetail);
            this.panel1.Controls.Add(this.addDetail);
            this.panel1.Controls.Add(this.saveOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 503);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 76);
            this.panel1.TabIndex = 7;
            // 
            // deleteDetail
            // 
            this.deleteDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteDetail.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDetail.Location = new System.Drawing.Point(212, 12);
            this.deleteDetail.Margin = new System.Windows.Forms.Padding(6);
            this.deleteDetail.Name = "deleteDetail";
            this.deleteDetail.Size = new System.Drawing.Size(150, 46);
            this.deleteDetail.TabIndex = 6;
            this.deleteDetail.Text = "删除明细";
            this.deleteDetail.UseVisualStyleBackColor = true;
            this.deleteDetail.Click += new System.EventHandler(this.deleteDetail_Click);
            // 
            // addDetail
            // 
            this.addDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addDetail.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDetail.Location = new System.Drawing.Point(50, 12);
            this.addDetail.Margin = new System.Windows.Forms.Padding(6);
            this.addDetail.Name = "addDetail";
            this.addDetail.Size = new System.Drawing.Size(150, 46);
            this.addDetail.TabIndex = 5;
            this.addDetail.Text = "添加明细";
            this.addDetail.UseVisualStyleBackColor = true;
            this.addDetail.Click += new System.EventHandler(this.addDetail_Click);
            // 
            // saveOrder
            // 
            this.saveOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveOrder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveOrder.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.saveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveOrder.Location = new System.Drawing.Point(890, 12);
            this.saveOrder.Margin = new System.Windows.Forms.Padding(6);
            this.saveOrder.Name = "saveOrder";
            this.saveOrder.Size = new System.Drawing.Size(252, 46);
            this.saveOrder.TabIndex = 4;
            this.saveOrder.Text = "保存订单";
            this.saveOrder.UseVisualStyleBackColor = false;
            this.saveOrder.Click += new System.EventHandler(this.saveOrder_Click);
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAddOrder";
            this.Text = "FormAddOrder";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrderId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoUnitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOrderDetailsAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteDetail;
        private System.Windows.Forms.Button addDetail;
        private System.Windows.Forms.Button saveOrder;
        private System.Windows.Forms.ComboBox clients;
        private System.Windows.Forms.BindingSource clientBindingSource;
    }
}
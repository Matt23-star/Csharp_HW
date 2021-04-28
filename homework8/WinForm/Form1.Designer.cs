
namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.订单操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsListBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.订单操作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1456, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            // 
            // 订单操作ToolStripMenuItem
            // 
            this.订单操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询订单ToolStripMenuItem,
            this.新建ToolStripMenuItem});
            this.订单操作ToolStripMenuItem.Name = "订单操作ToolStripMenuItem";
            this.订单操作ToolStripMenuItem.Size = new System.Drawing.Size(130, 42);
            this.订单操作ToolStripMenuItem.Text = "订单操作";
            // 
            // 查询订单ToolStripMenuItem
            // 
            this.查询订单ToolStripMenuItem.Name = "查询订单ToolStripMenuItem";
            this.查询订单ToolStripMenuItem.Size = new System.Drawing.Size(195, 44);
            this.查询订单ToolStripMenuItem.Text = "查询";
            this.查询订单ToolStripMenuItem.Click += new System.EventHandler(this.查询订单ToolStripMenuItem_Click);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(195, 44);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cargoDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.salesVolumeDataGridViewTextBoxColumn,
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderDetailsListBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1456, 251);
            this.dataGridView1.TabIndex = 1;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cargoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cargoDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // salesVolumeDataGridViewTextBoxColumn
            // 
            this.salesVolumeDataGridViewTextBoxColumn.DataPropertyName = "SalesVolume";
            this.salesVolumeDataGridViewTextBoxColumn.HeaderText = "SalesVolume";
            this.salesVolumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salesVolumeDataGridViewTextBoxColumn.Name = "salesVolumeDataGridViewTextBoxColumn";
            this.salesVolumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalOrderDetailsAmountDataGridViewTextBoxColumn
            // 
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalOrderDetailsAmount";
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn.HeaderText = "TotalOrderDetailsAmount";
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn.Name = "totalOrderDetailsAmountDataGridViewTextBoxColumn";
            this.totalOrderDetailsAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDetailsListBindingSource
            // 
            this.orderDetailsListBindingSource.DataMember = "OrderDetailsList";
            this.orderDetailsListBindingSource.DataSource = this.OrderbindingSource;
            // 
            // OrderbindingSource
            // 
            this.OrderbindingSource.DataSource = typeof(OrderFunction.Order);
            this.OrderbindingSource.CurrentChanged += new System.EventHandler(this.OrderbindingSource_CurrentChanged);
            // 
            // orderDetailsListBindingSource1
            // 
            this.orderDetailsListBindingSource1.DataMember = "OrderDetailsList";
            this.orderDetailsListBindingSource1.DataSource = this.OrderbindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 720);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Order";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsListBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 订单操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        public System.Windows.Forms.BindingSource OrderbindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderDetailsListBindingSource;
        private System.Windows.Forms.BindingSource orderDetailsListBindingSource1;
        private System.Windows.Forms.DataGridViewImageColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOrderDetailsAmountDataGridViewTextBoxColumn;
    }
}


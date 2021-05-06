
namespace Crawler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Webs = new System.Windows.Forms.GroupBox();
            this.urlListBox = new System.Windows.Forms.ListBox();
            this.urlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urlListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messagesSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stateListBox = new System.Windows.Forms.ListBox();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.stopButton = new System.Windows.Forms.Button();
            this.sendURL = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Webs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urlListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateListBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 667);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.Webs, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1150, 505);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // Webs
            // 
            this.Webs.Controls.Add(this.urlListBox);
            this.Webs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Webs.Location = new System.Drawing.Point(3, 3);
            this.Webs.Name = "Webs";
            this.Webs.Size = new System.Drawing.Size(799, 499);
            this.Webs.TabIndex = 0;
            this.Webs.TabStop = false;
            this.Webs.Text = "爬取网址";
            // 
            // urlListBox
            // 
            this.urlListBox.DataSource = this.urlBindingSource;
            this.urlListBox.DisplayMember = "url";
            this.urlListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlListBox.FormattingEnabled = true;
            this.urlListBox.ItemHeight = 24;
            this.urlListBox.Location = new System.Drawing.Point(3, 31);
            this.urlListBox.MaximumSize = new System.Drawing.Size(793, 465);
            this.urlListBox.MinimumSize = new System.Drawing.Size(793, 465);
            this.urlListBox.Name = "urlListBox";
            this.urlListBox.Size = new System.Drawing.Size(793, 465);
            this.urlListBox.TabIndex = 2;
            // 
            // urlBindingSource
            // 
            this.urlBindingSource.DataSource = this.urlListBindingSource;
            // 
            // urlListBindingSource
            // 
            this.urlListBindingSource.DataMember = "urlList";
            this.urlListBindingSource.DataSource = this.messagesSource;
            // 
            // messagesSource
            // 
            this.messagesSource.DataSource = typeof(Crawler.SimpleCrawler);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stateListBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(808, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 499);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "爬取状态";
            // 
            // stateListBox
            // 
            this.stateListBox.DataSource = this.stateBindingSource;
            this.stateListBox.DisplayMember = "state";
            this.stateListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateListBox.FormattingEnabled = true;
            this.stateListBox.ItemHeight = 24;
            this.stateListBox.Location = new System.Drawing.Point(3, 31);
            this.stateListBox.MaximumSize = new System.Drawing.Size(333, 465);
            this.stateListBox.MinimumSize = new System.Drawing.Size(333, 465);
            this.stateListBox.Name = "stateListBox";
            this.stateListBox.Size = new System.Drawing.Size(333, 465);
            this.stateListBox.TabIndex = 0;
            this.stateListBox.SelectedIndexChanged += new System.EventHandler(this.stateListBox_SelectedIndexChanged);
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = this.stateListBindingSource;
            // 
            // stateListBindingSource
            // 
            this.stateListBindingSource.DataMember = "stateList";
            this.stateListBindingSource.DataSource = this.messagesSource;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 505);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1150, 162);
            this.panel4.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 162);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.stopButton);
            this.panel5.Controls.Add(this.sendURL);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(808, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 93);
            this.panel5.TabIndex = 3;
            // 
            // stopButton
            // 
            this.stopButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.stopButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stopButton.Location = new System.Drawing.Point(0, 53);
            this.stopButton.MaximumSize = new System.Drawing.Size(339, 40);
            this.stopButton.MinimumSize = new System.Drawing.Size(339, 40);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(339, 40);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "暂停";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // sendURL
            // 
            this.sendURL.AutoSize = true;
            this.sendURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.sendURL.Location = new System.Drawing.Point(0, 0);
            this.sendURL.MaximumSize = new System.Drawing.Size(339, 40);
            this.sendURL.MinimumSize = new System.Drawing.Size(339, 40);
            this.sendURL.Name = "sendURL";
            this.sendURL.Size = new System.Drawing.Size(339, 40);
            this.sendURL.TabIndex = 0;
            this.sendURL.Text = "确认";
            this.sendURL.UseVisualStyleBackColor = true;
            this.sendURL.Click += new System.EventHandler(this.sendURL_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.urlTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 156);
            this.panel3.TabIndex = 4;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.urlTextBox.Location = new System.Drawing.Point(0, 121);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(799, 35);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL自定义";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 0);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AcceptButton = this.sendURL;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 667);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(1176, 738);
            this.MaximumSize = new System.Drawing.Size(1176, 738);
            this.MinimumSize = new System.Drawing.Size(1176, 738);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Webs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urlListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateListBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button sendURL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox Webs;
        private System.Windows.Forms.BindingSource messagesSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource urlBindingSource;
        private System.Windows.Forms.BindingSource urlListBindingSource;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.BindingSource stateListBindingSource;
        private System.Windows.Forms.ListBox urlListBox;
        private System.Windows.Forms.ListBox stateListBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button stopButton;
    }
}


namespace 淘宝店铺
{
    partial class FormMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.店铺名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.等级DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否在线DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.店铺地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.旺旺名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.旺旺地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.店铺数据BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLine = new System.Windows.Forms.CheckBox();
            this.chkContact = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.店铺数据BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始抓取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(146, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.店铺名称DataGridViewTextBoxColumn,
            this.等级DataGridViewTextBoxColumn,
            this.商品数量DataGridViewTextBoxColumn,
            this.销量DataGridViewTextBoxColumn,
            this.是否在线DataGridViewTextBoxColumn,
            this.联系时间DataGridViewTextBoxColumn,
            this.店铺地址DataGridViewTextBoxColumn,
            this.旺旺名称DataGridViewTextBoxColumn,
            this.旺旺地址DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.店铺数据BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(969, 625);
            this.dataGridView1.TabIndex = 3;
            // 
            // 店铺名称DataGridViewTextBoxColumn
            // 
            this.店铺名称DataGridViewTextBoxColumn.DataPropertyName = "店铺名称";
            this.店铺名称DataGridViewTextBoxColumn.HeaderText = "店铺名称";
            this.店铺名称DataGridViewTextBoxColumn.Name = "店铺名称DataGridViewTextBoxColumn";
            this.店铺名称DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 等级DataGridViewTextBoxColumn
            // 
            this.等级DataGridViewTextBoxColumn.DataPropertyName = "等级";
            this.等级DataGridViewTextBoxColumn.HeaderText = "等级";
            this.等级DataGridViewTextBoxColumn.Name = "等级DataGridViewTextBoxColumn";
            this.等级DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 商品数量DataGridViewTextBoxColumn
            // 
            this.商品数量DataGridViewTextBoxColumn.DataPropertyName = "商品数量";
            this.商品数量DataGridViewTextBoxColumn.HeaderText = "商品数量";
            this.商品数量DataGridViewTextBoxColumn.Name = "商品数量DataGridViewTextBoxColumn";
            this.商品数量DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 销量DataGridViewTextBoxColumn
            // 
            this.销量DataGridViewTextBoxColumn.DataPropertyName = "销量";
            this.销量DataGridViewTextBoxColumn.HeaderText = "销量";
            this.销量DataGridViewTextBoxColumn.Name = "销量DataGridViewTextBoxColumn";
            this.销量DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 是否在线DataGridViewTextBoxColumn
            // 
            this.是否在线DataGridViewTextBoxColumn.DataPropertyName = "是否在线";
            this.是否在线DataGridViewTextBoxColumn.HeaderText = "是否在线";
            this.是否在线DataGridViewTextBoxColumn.Name = "是否在线DataGridViewTextBoxColumn";
            this.是否在线DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 联系时间DataGridViewTextBoxColumn
            // 
            this.联系时间DataGridViewTextBoxColumn.DataPropertyName = "联系时间";
            this.联系时间DataGridViewTextBoxColumn.HeaderText = "联系时间";
            this.联系时间DataGridViewTextBoxColumn.Name = "联系时间DataGridViewTextBoxColumn";
            this.联系时间DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 店铺地址DataGridViewTextBoxColumn
            // 
            this.店铺地址DataGridViewTextBoxColumn.DataPropertyName = "店铺地址";
            this.店铺地址DataGridViewTextBoxColumn.HeaderText = "店铺地址";
            this.店铺地址DataGridViewTextBoxColumn.Name = "店铺地址DataGridViewTextBoxColumn";
            this.店铺地址DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 旺旺名称DataGridViewTextBoxColumn
            // 
            this.旺旺名称DataGridViewTextBoxColumn.DataPropertyName = "旺旺名称";
            this.旺旺名称DataGridViewTextBoxColumn.HeaderText = "旺旺名称";
            this.旺旺名称DataGridViewTextBoxColumn.Name = "旺旺名称DataGridViewTextBoxColumn";
            this.旺旺名称DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 旺旺地址DataGridViewTextBoxColumn
            // 
            this.旺旺地址DataGridViewTextBoxColumn.DataPropertyName = "旺旺地址";
            this.旺旺地址DataGridViewTextBoxColumn.HeaderText = "旺旺地址";
            this.旺旺地址DataGridViewTextBoxColumn.Name = "旺旺地址DataGridViewTextBoxColumn";
            this.旺旺地址DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 店铺数据BindingSource
            // 
            this.店铺数据BindingSource.DataSource = typeof(淘宝店铺.店铺数据);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLine);
            this.groupBox1.Controls.Add(this.chkContact);
            this.groupBox1.Location = new System.Drawing.Point(338, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "根据查询结果筛选";
            // 
            // chkLine
            // 
            this.chkLine.AutoSize = true;
            this.chkLine.Location = new System.Drawing.Point(137, 25);
            this.chkLine.Name = "chkLine";
            this.chkLine.Size = new System.Drawing.Size(72, 16);
            this.chkLine.TabIndex = 1;
            this.chkLine.Text = "筛选在线";
            this.chkLine.UseVisualStyleBackColor = true;
            this.chkLine.CheckedChanged += new System.EventHandler(this.chkLine_CheckedChanged);
            // 
            // chkContact
            // 
            this.chkContact.AutoSize = true;
            this.chkContact.Location = new System.Drawing.Point(15, 25);
            this.chkContact.Name = "chkContact";
            this.chkContact.Size = new System.Drawing.Size(84, 16);
            this.chkContact.TabIndex = 0;
            this.chkContact.Text = "筛选未联系";
            this.chkContact.UseVisualStyleBackColor = true;
            this.chkContact.CheckedChanged += new System.EventHandler(this.chkContact_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(635, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "【筛选在线】勾选后，每30秒程序获取一次所有店铺在线状态";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(170, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 21);
            this.textBox1.TabIndex = 6;
            this.textBox1.Tag = "请输入关键字";
            this.textBox1.Text = "请输入关键字";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "开始抓取";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 694);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.店铺数据BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 店铺名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 等级DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否在线DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 店铺地址DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 旺旺名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 旺旺地址DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 店铺数据BindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkLine;
        private System.Windows.Forms.CheckBox chkContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}


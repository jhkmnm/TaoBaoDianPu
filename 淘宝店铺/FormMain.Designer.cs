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
            this.colShopID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col店铺名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col等级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col商品数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col销量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col是否在线 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col联系时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col店铺地址 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col旺旺名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col旺旺地址 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chkLine = new System.Windows.Forms.CheckBox();
            this.chkContact = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShopID,
            this.col店铺名称,
            this.col等级,
            this.col商品数量,
            this.col销量,
            this.col是否在线,
            this.col联系时间,
            this.col店铺地址,
            this.col旺旺名称,
            this.col旺旺地址});
            this.dataGridView1.Location = new System.Drawing.Point(4, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(969, 625);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colShopID
            // 
            this.colShopID.DataPropertyName = "ShopID";
            this.colShopID.HeaderText = "ShopID";
            this.colShopID.Name = "colShopID";
            this.colShopID.ReadOnly = true;
            this.colShopID.Visible = false;
            // 
            // col店铺名称
            // 
            this.col店铺名称.DataPropertyName = "店铺名称";
            this.col店铺名称.HeaderText = "店铺名称";
            this.col店铺名称.Name = "col店铺名称";
            this.col店铺名称.ReadOnly = true;
            // 
            // col等级
            // 
            this.col等级.DataPropertyName = "等级";
            this.col等级.HeaderText = "等级";
            this.col等级.Name = "col等级";
            this.col等级.ReadOnly = true;
            this.col等级.Width = 60;
            // 
            // col商品数量
            // 
            this.col商品数量.DataPropertyName = "商品数量";
            this.col商品数量.HeaderText = "商品数量";
            this.col商品数量.Name = "col商品数量";
            this.col商品数量.ReadOnly = true;
            this.col商品数量.Width = 80;
            // 
            // col销量
            // 
            this.col销量.DataPropertyName = "销量";
            this.col销量.HeaderText = "销量";
            this.col销量.Name = "col销量";
            this.col销量.ReadOnly = true;
            this.col销量.Width = 60;
            // 
            // col是否在线
            // 
            this.col是否在线.DataPropertyName = "是否在线";
            this.col是否在线.HeaderText = "是否在线";
            this.col是否在线.Name = "col是否在线";
            this.col是否在线.ReadOnly = true;
            // 
            // col联系时间
            // 
            this.col联系时间.DataPropertyName = "联系时间";
            this.col联系时间.HeaderText = "联系时间";
            this.col联系时间.Name = "col联系时间";
            this.col联系时间.ReadOnly = true;
            // 
            // col店铺地址
            // 
            this.col店铺地址.DataPropertyName = "店铺地址";
            this.col店铺地址.HeaderText = "店铺地址";
            this.col店铺地址.Name = "col店铺地址";
            this.col店铺地址.ReadOnly = true;
            this.col店铺地址.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col店铺地址.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col旺旺名称
            // 
            this.col旺旺名称.DataPropertyName = "旺旺名称";
            this.col旺旺名称.HeaderText = "旺旺名称";
            this.col旺旺名称.Name = "col旺旺名称";
            this.col旺旺名称.ReadOnly = true;
            // 
            // col旺旺地址
            // 
            this.col旺旺地址.DataPropertyName = "旺旺地址";
            this.col旺旺地址.HeaderText = "旺旺地址";
            this.col旺旺地址.Name = "col旺旺地址";
            this.col旺旺地址.ReadOnly = true;
            this.col旺旺地址.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col旺旺地址.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.chkLine);
            this.groupBox1.Controls.Add(this.chkContact);
            this.groupBox1.Location = new System.Drawing.Point(338, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "根据查询结果筛选";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(205, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.Tag = "间隔时间/秒";
            this.textBox2.Text = "间隔时间/秒";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // chkLine
            // 
            this.chkLine.AutoSize = true;
            this.chkLine.Location = new System.Drawing.Point(128, 25);
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
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(635, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "【筛选在线】勾选后，按指定时间查询在线状态，如果指定的不是数字程序默认30秒";
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
            this.button2.Location = new System.Drawing.Point(865, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "用户列表";
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkLine;
        private System.Windows.Forms.CheckBox chkContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShopID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col店铺名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn col等级;
        private System.Windows.Forms.DataGridViewTextBoxColumn col商品数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn col销量;
        private System.Windows.Forms.DataGridViewTextBoxColumn col是否在线;
        private System.Windows.Forms.DataGridViewTextBoxColumn col联系时间;
        private System.Windows.Forms.DataGridViewLinkColumn col店铺地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn col旺旺名称;
        private System.Windows.Forms.DataGridViewLinkColumn col旺旺地址;
    }
}


namespace servicestation
{
    partial class Purchase
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
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.product_id = new System.Windows.Forms.TextBox();
            this.pro_name = new System.Windows.Forms.TextBox();
            this.unit_price = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.order_quantity = new System.Windows.Forms.TextBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ttl_excise = new System.Windows.Forms.TextBox();
            this.grand_ttl = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.masterDataSet2 = new servicestation.masterDataSet2();
            this.sparepartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sparepartsTableAdapter = new servicestation.masterDataSet2TableAdapters.sparepartsTableAdapter();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pronameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.masterDataSet3 = new servicestation.masterDataSet3();
            this.purchasepartyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasepartyTableAdapter = new servicestation.masterDataSet3TableAdapters.purchasepartyTableAdapter();
            this.masterDataSet4 = new servicestation.masterDataSet4();
            this.exciseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exciseTableAdapter = new servicestation.masterDataSet4TableAdapters.exciseTableAdapter();
            this.masterDataSet5 = new servicestation.masterDataSet5();
            this.vatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vatTableAdapter = new servicestation.masterDataSet5TableAdapters.vatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasepartyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exciseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(236, 27);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(162, 20);
            this.search.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(445, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(567, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Display All";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.pronameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sparepartsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(210, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkKhaki;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Products To Be Ordered";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.size);
            this.panel1.Controls.Add(this.unit_price);
            this.panel1.Controls.Add(this.pro_name);
            this.panel1.Controls.Add(this.product_id);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(28, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 253);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Uint Price";
            // 
            // product_id
            // 
            this.product_id.Location = new System.Drawing.Point(129, 20);
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(100, 20);
            this.product_id.TabIndex = 5;
            // 
            // pro_name
            // 
            this.pro_name.Location = new System.Drawing.Point(129, 63);
            this.pro_name.Name = "pro_name";
            this.pro_name.Size = new System.Drawing.Size(154, 20);
            this.pro_name.TabIndex = 6;
            // 
            // unit_price
            // 
            this.unit_price.Location = new System.Drawing.Point(129, 222);
            this.unit_price.Name = "unit_price";
            this.unit_price.Size = new System.Drawing.Size(107, 20);
            this.unit_price.TabIndex = 7;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(129, 178);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(107, 20);
            this.size.TabIndex = 8;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(129, 99);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(154, 73);
            this.description.TabIndex = 9;
            this.description.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.grand_ttl);
            this.panel2.Controls.Add(this.ttl_excise);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.amount);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.rate);
            this.panel2.Controls.Add(this.order_quantity);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(394, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 319);
            this.panel2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(569, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Purchase Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Purchase From";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Order Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Rate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Excise%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "Vat%";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.purchasepartyBindingSource;
            this.comboBox1.DisplayMember = "party_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "party_name";
            // 
            // order_quantity
            // 
            this.order_quantity.Location = new System.Drawing.Point(138, 68);
            this.order_quantity.Name = "order_quantity";
            this.order_quantity.Size = new System.Drawing.Size(132, 20);
            this.order_quantity.TabIndex = 6;
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(138, 120);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(132, 20);
            this.rate.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(319, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 18);
            this.label15.TabIndex = 10;
            this.label15.Text = "Amount";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(322, 47);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(121, 20);
            this.amount.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(322, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 18);
            this.label16.TabIndex = 12;
            this.label16.Text = "Total Excise";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(325, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 18);
            this.label17.TabIndex = 13;
            this.label17.Text = "Grand Total";
            // 
            // ttl_excise
            // 
            this.ttl_excise.Location = new System.Drawing.Point(328, 126);
            this.ttl_excise.Name = "ttl_excise";
            this.ttl_excise.Size = new System.Drawing.Size(115, 20);
            this.ttl_excise.TabIndex = 14;
            // 
            // grand_ttl
            // 
            this.grand_ttl.Location = new System.Drawing.Point(328, 212);
            this.grand_ttl.Name = "grand_ttl";
            this.grand_ttl.Size = new System.Drawing.Size(115, 20);
            this.grand_ttl.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(167, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 40);
            this.button3.TabIndex = 16;
            this.button3.Text = "Calculate/Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(303, 654);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // masterDataSet2
            // 
            this.masterDataSet2.DataSetName = "masterDataSet2";
            this.masterDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sparepartsBindingSource
            // 
            this.sparepartsBindingSource.DataMember = "spareparts";
            this.sparepartsBindingSource.DataSource = this.masterDataSet2;
            // 
            // sparepartsTableAdapter
            // 
            this.sparepartsTableAdapter.ClearBeforeFill = true;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            // 
            // pronameDataGridViewTextBoxColumn
            // 
            this.pronameDataGridViewTextBoxColumn.DataPropertyName = "pro_name";
            this.pronameDataGridViewTextBoxColumn.HeaderText = "pro_name";
            this.pronameDataGridViewTextBoxColumn.Name = "pronameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            this.unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unit_price";
            this.unitpriceDataGridViewTextBoxColumn.HeaderText = "unit_price";
            this.unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.exciseBindingSource;
            this.comboBox2.DisplayMember = "excise";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(138, 190);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "excise";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.vatBindingSource;
            this.comboBox3.DisplayMember = "vat";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(138, 232);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(132, 21);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.ValueMember = "vat";
            // 
            // masterDataSet3
            // 
            this.masterDataSet3.DataSetName = "masterDataSet3";
            this.masterDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasepartyBindingSource
            // 
            this.purchasepartyBindingSource.DataMember = "purchaseparty";
            this.purchasepartyBindingSource.DataSource = this.masterDataSet3;
            // 
            // purchasepartyTableAdapter
            // 
            this.purchasepartyTableAdapter.ClearBeforeFill = true;
            // 
            // masterDataSet4
            // 
            this.masterDataSet4.DataSetName = "masterDataSet4";
            this.masterDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exciseBindingSource
            // 
            this.exciseBindingSource.DataMember = "excise";
            this.exciseBindingSource.DataSource = this.masterDataSet4;
            // 
            // exciseTableAdapter
            // 
            this.exciseTableAdapter.ClearBeforeFill = true;
            // 
            // masterDataSet5
            // 
            this.masterDataSet5.DataSetName = "masterDataSet5";
            this.masterDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vatBindingSource
            // 
            this.vatBindingSource.DataMember = "vat";
            this.vatBindingSource.DataSource = this.masterDataSet5;
            // 
            // vatTableAdapter
            // 
            this.vatTableAdapter.ClearBeforeFill = true;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(906, 700);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasepartyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exciseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox unit_price;
        private System.Windows.Forms.TextBox pro_name;
        private System.Windows.Forms.TextBox product_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox grand_ttl;
        private System.Windows.Forms.TextBox ttl_excise;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox order_quantity;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private masterDataSet2 masterDataSet2;
        private System.Windows.Forms.BindingSource sparepartsBindingSource;
        private masterDataSet2TableAdapters.sparepartsTableAdapter sparepartsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pronameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private masterDataSet3 masterDataSet3;
        private System.Windows.Forms.BindingSource purchasepartyBindingSource;
        private masterDataSet3TableAdapters.purchasepartyTableAdapter purchasepartyTableAdapter;
        private masterDataSet4 masterDataSet4;
        private System.Windows.Forms.BindingSource exciseBindingSource;
        private masterDataSet4TableAdapters.exciseTableAdapter exciseTableAdapter;
        private masterDataSet5 masterDataSet5;
        private System.Windows.Forms.BindingSource vatBindingSource;
        private masterDataSet5TableAdapters.vatTableAdapter vatTableAdapter;
    }
}
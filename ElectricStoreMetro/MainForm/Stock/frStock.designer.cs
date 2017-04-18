namespace ElectricStoreMetro.MainForm.Stock
{
    partial class frStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frStock));
            this.dgv = new ns1.BunifuCustomDataGrid();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtCat = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel4 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel5 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.numAddStock = new System.Windows.Forms.NumericUpDown();
            this.txtSearchName = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel6 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel7 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel8 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.numRem = new System.Windows.Forms.NumericUpDown();
            this.txtSearchCat = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQueryHigh = new MetroFramework.Controls.MetroButton();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.txtQueryHigh = new System.Windows.Forms.TextBox();
            this.btnQueryUnder = new MetroFramework.Controls.MetroButton();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.txtQueryUnder = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DoubleBuffered = true;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.HeaderBgColor = System.Drawing.Color.White;
            this.dgv.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv.Location = new System.Drawing.Point(263, 160);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(749, 277);
            this.dgv.TabIndex = 0;
            this.metroToolTip1.SetToolTip(this.dgv, "Selected Stock");
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(24, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htmlLabel1.Location = new System.Drawing.Point(9, 160);
            this.htmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(48, 28);
            this.htmlLabel1.TabIndex = 1;
            this.htmlLabel1.Text = "ID:";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Enabled = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(87, 160);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PromptText = "Product id";
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(167, 28);
            this.txtID.TabIndex = 2;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMark = "Product id";
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.txtName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Enabled = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(87, 209);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "product name";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(168, 28);
            this.txtName.TabIndex = 4;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "product name";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(42, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htmlLabel2.Location = new System.Drawing.Point(9, 209);
            this.htmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(69, 28);
            this.htmlLabel2.TabIndex = 3;
            this.htmlLabel2.Text = "Name:";
            // 
            // txtCat
            // 
            // 
            // 
            // 
            this.txtCat.CustomButton.Image = null;
            this.txtCat.CustomButton.Location = new System.Drawing.Point(163, 2);
            this.txtCat.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCat.CustomButton.Name = "";
            this.txtCat.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCat.CustomButton.TabIndex = 1;
            this.txtCat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCat.CustomButton.UseSelectable = true;
            this.txtCat.CustomButton.Visible = false;
            this.txtCat.Enabled = false;
            this.txtCat.Lines = new string[0];
            this.txtCat.Location = new System.Drawing.Point(65, 260);
            this.txtCat.Margin = new System.Windows.Forms.Padding(4);
            this.txtCat.MaxLength = 32767;
            this.txtCat.Name = "txtCat";
            this.txtCat.PasswordChar = '\0';
            this.txtCat.PromptText = "Product category";
            this.txtCat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCat.SelectedText = "";
            this.txtCat.SelectionLength = 0;
            this.txtCat.SelectionStart = 0;
            this.txtCat.ShortcutsEnabled = true;
            this.txtCat.Size = new System.Drawing.Size(189, 28);
            this.txtCat.TabIndex = 6;
            this.txtCat.UseSelectable = true;
            this.txtCat.WaterMark = "Product category";
            this.txtCat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(30, 23);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htmlLabel3.Location = new System.Drawing.Point(9, 260);
            this.htmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(48, 28);
            this.htmlLabel3.TabIndex = 5;
            this.htmlLabel3.Text = "Cat:";
            // 
            // htmlLabel4
            // 
            this.htmlLabel4.AutoScroll = true;
            this.htmlLabel4.AutoScrollMinSize = new System.Drawing.Size(41, 23);
            this.htmlLabel4.AutoSize = false;
            this.htmlLabel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htmlLabel4.Location = new System.Drawing.Point(9, 295);
            this.htmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.htmlLabel4.Name = "htmlLabel4";
            this.htmlLabel4.Size = new System.Drawing.Size(69, 28);
            this.htmlLabel4.TabIndex = 7;
            this.htmlLabel4.Text = "Stock:";
            // 
            // htmlLabel5
            // 
            this.htmlLabel5.AutoScroll = true;
            this.htmlLabel5.AutoScrollMinSize = new System.Drawing.Size(63, 23);
            this.htmlLabel5.AutoSize = false;
            this.htmlLabel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htmlLabel5.Location = new System.Drawing.Point(9, 359);
            this.htmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.htmlLabel5.Name = "htmlLabel5";
            this.htmlLabel5.Size = new System.Drawing.Size(87, 28);
            this.htmlLabel5.TabIndex = 9;
            this.htmlLabel5.Text = "Add Stock:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::ElectricStoreMetro.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(87, 395);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 28);
            this.btnSave.TabIndex = 11;
            this.metroToolTip1.SetToolTip(this.btnSave, "Click to save changes..");
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numStock
            // 
            this.numStock.Enabled = false;
            this.numStock.Location = new System.Drawing.Point(87, 295);
            this.numStock.Margin = new System.Windows.Forms.Padding(4);
            this.numStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(160, 23);
            this.numStock.TabIndex = 12;
            // 
            // numAddStock
            // 
            this.numAddStock.Location = new System.Drawing.Point(87, 359);
            this.numAddStock.Margin = new System.Windows.Forms.Padding(4);
            this.numAddStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAddStock.Name = "numAddStock";
            this.numAddStock.Size = new System.Drawing.Size(160, 23);
            this.numAddStock.TabIndex = 12;
            this.numAddStock.ValueChanged += new System.EventHandler(this.numAddStock_ValueChanged);
            // 
            // txtSearchName
            // 
            // 
            // 
            // 
            this.txtSearchName.CustomButton.Image = null;
            this.txtSearchName.CustomButton.Location = new System.Drawing.Point(329, 2);
            this.txtSearchName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchName.CustomButton.Name = "";
            this.txtSearchName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSearchName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchName.CustomButton.TabIndex = 1;
            this.txtSearchName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchName.CustomButton.UseSelectable = true;
            this.txtSearchName.Lines = new string[0];
            this.txtSearchName.Location = new System.Drawing.Point(83, 23);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchName.MaxLength = 32767;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.PasswordChar = '\0';
            this.txtSearchName.PromptText = "Search by name";
            this.txtSearchName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchName.SelectedText = "";
            this.txtSearchName.SelectionLength = 0;
            this.txtSearchName.SelectionStart = 0;
            this.txtSearchName.ShortcutsEnabled = true;
            this.txtSearchName.ShowButton = true;
            this.txtSearchName.ShowClearButton = true;
            this.txtSearchName.Size = new System.Drawing.Size(355, 28);
            this.txtSearchName.TabIndex = 14;
            this.metroToolTip1.SetToolTip(this.txtSearchName, "Seach by item name");
            this.txtSearchName.UseSelectable = true;
            this.txtSearchName.WaterMark = "Search by name";
            this.txtSearchName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            this.txtSearchName.Click += new System.EventHandler(this.txtSearchName_Click);
            // 
            // htmlLabel6
            // 
            this.htmlLabel6.AutoScroll = true;
            this.htmlLabel6.AutoScrollMinSize = new System.Drawing.Size(42, 23);
            this.htmlLabel6.AutoSize = false;
            this.htmlLabel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htmlLabel6.Location = new System.Drawing.Point(8, 23);
            this.htmlLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.htmlLabel6.Name = "htmlLabel6";
            this.htmlLabel6.Size = new System.Drawing.Size(67, 28);
            this.htmlLabel6.TabIndex = 13;
            this.htmlLabel6.Text = "Name:";
            // 
            // htmlLabel7
            // 
            this.htmlLabel7.AutoScroll = true;
            this.htmlLabel7.AutoScrollMinSize = new System.Drawing.Size(30, 23);
            this.htmlLabel7.AutoSize = false;
            this.htmlLabel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htmlLabel7.Location = new System.Drawing.Point(443, 23);
            this.htmlLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.htmlLabel7.Name = "htmlLabel7";
            this.htmlLabel7.Size = new System.Drawing.Size(49, 28);
            this.htmlLabel7.TabIndex = 14;
            this.htmlLabel7.Text = "Cat:";
            // 
            // htmlLabel8
            // 
            this.htmlLabel8.AutoScroll = true;
            this.htmlLabel8.AutoScrollMinSize = new System.Drawing.Size(36, 23);
            this.htmlLabel8.AutoSize = false;
            this.htmlLabel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htmlLabel8.Location = new System.Drawing.Point(9, 324);
            this.htmlLabel8.Margin = new System.Windows.Forms.Padding(4);
            this.htmlLabel8.Name = "htmlLabel8";
            this.htmlLabel8.Size = new System.Drawing.Size(69, 28);
            this.htmlLabel8.TabIndex = 7;
            this.htmlLabel8.Text = "Rem:";
            // 
            // numRem
            // 
            this.numRem.Enabled = false;
            this.numRem.Location = new System.Drawing.Point(87, 324);
            this.numRem.Margin = new System.Windows.Forms.Padding(4);
            this.numRem.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRem.Name = "numRem";
            this.numRem.Size = new System.Drawing.Size(160, 23);
            this.numRem.TabIndex = 12;
            // 
            // txtSearchCat
            // 
            // 
            // 
            // 
            this.txtSearchCat.CustomButton.Image = null;
            this.txtSearchCat.CustomButton.Location = new System.Drawing.Point(221, 2);
            this.txtSearchCat.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCat.CustomButton.Name = "";
            this.txtSearchCat.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSearchCat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchCat.CustomButton.TabIndex = 1;
            this.txtSearchCat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchCat.CustomButton.UseSelectable = true;
            this.txtSearchCat.Lines = new string[0];
            this.txtSearchCat.Location = new System.Drawing.Point(500, 23);
            this.txtSearchCat.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCat.MaxLength = 32767;
            this.txtSearchCat.Name = "txtSearchCat";
            this.txtSearchCat.PasswordChar = '\0';
            this.txtSearchCat.PromptText = "Search by category";
            this.txtSearchCat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchCat.SelectedText = "";
            this.txtSearchCat.SelectionLength = 0;
            this.txtSearchCat.SelectionStart = 0;
            this.txtSearchCat.ShortcutsEnabled = true;
            this.txtSearchCat.ShowButton = true;
            this.txtSearchCat.ShowClearButton = true;
            this.txtSearchCat.Size = new System.Drawing.Size(247, 28);
            this.txtSearchCat.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.txtSearchCat, "Search by category name");
            this.txtSearchCat.UseSelectable = true;
            this.txtSearchCat.WaterMark = "Search by category";
            this.txtSearchCat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchCat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchCat.TextChanged += new System.EventHandler(this.txtSearchCat_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.htmlLabel7);
            this.groupBox1.Controls.Add(this.txtSearchName);
            this.groupBox1.Controls.Add(this.htmlLabel6);
            this.groupBox1.Controls.Add(this.txtSearchCat);
            this.groupBox1.Location = new System.Drawing.Point(16, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(995, 65);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searcing";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQueryHigh);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox2.Controls.Add(this.txtQueryHigh);
            this.groupBox2.Controls.Add(this.btnQueryUnder);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox2.Controls.Add(this.txtQueryUnder);
            this.groupBox2.Location = new System.Drawing.Point(19, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(992, 68);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Query Stock";
            // 
            // btnQueryHigh
            // 
            this.btnQueryHigh.Location = new System.Drawing.Point(387, 38);
            this.btnQueryHigh.Name = "btnQueryHigh";
            this.btnQueryHigh.Size = new System.Drawing.Size(75, 23);
            this.btnQueryHigh.TabIndex = 5;
            this.btnQueryHigh.Text = "Apply Query";
            this.metroToolTip1.SetToolTip(this.btnQueryHigh, "Click to apply filter");
            this.btnQueryHigh.UseSelectable = true;
            this.btnQueryHigh.Click += new System.EventHandler(this.btnQueryHigh_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 41);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(272, 16);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Show stock with quantity greater than:";
            // 
            // txtQueryHigh
            // 
            this.txtQueryHigh.Location = new System.Drawing.Point(280, 38);
            this.txtQueryHigh.Name = "txtQueryHigh";
            this.txtQueryHigh.Size = new System.Drawing.Size(100, 23);
            this.txtQueryHigh.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.txtQueryHigh, "Value");
            this.txtQueryHigh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQueryUnder_KeyPress);
            // 
            // btnQueryUnder
            // 
            this.btnQueryUnder.Location = new System.Drawing.Point(387, 14);
            this.btnQueryUnder.Name = "btnQueryUnder";
            this.btnQueryUnder.Size = new System.Drawing.Size(75, 23);
            this.btnQueryUnder.TabIndex = 2;
            this.btnQueryUnder.Text = "Apply Query";
            this.metroToolTip1.SetToolTip(this.btnQueryUnder, "Click to apply filter");
            this.btnQueryUnder.UseSelectable = true;
            this.btnQueryUnder.Click += new System.EventHandler(this.btnQueryUnder_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(8, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(241, 16);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Show stock that is under quantity:";
            // 
            // txtQueryUnder
            // 
            this.txtQueryUnder.Location = new System.Drawing.Point(280, 14);
            this.txtQueryUnder.Name = "txtQueryUnder";
            this.txtQueryUnder.Size = new System.Drawing.Size(100, 23);
            this.txtQueryUnder.TabIndex = 0;
            this.metroToolTip1.SetToolTip(this.txtQueryUnder, "Value");
            this.txtQueryUnder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQueryUnder_KeyPress);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(913, 23);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Refresh";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1035, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numAddStock);
            this.Controls.Add(this.numRem);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.htmlLabel5);
            this.Controls.Add(this.htmlLabel8);
            this.Controls.Add(this.htmlLabel4);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.htmlLabel3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create and Manage Stock";
            this.Load += new System.EventHandler(this.frStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCustomDataGrid dgv;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroTextBox txtCat;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel5;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numAddStock;
        private MetroFramework.Controls.MetroTextBox txtSearchName;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel6;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel7;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel8;
        private System.Windows.Forms.NumericUpDown numRem;
        private MetroFramework.Controls.MetroTextBox txtSearchCat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txtQueryUnder;
        private MetroFramework.Controls.MetroButton btnQueryHigh;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox txtQueryHigh;
        private MetroFramework.Controls.MetroButton btnQueryUnder;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}
namespace ElectricStoreMetro.MainForm.Product
{
    partial class frProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new ns1.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.numDPercent = new System.Windows.Forms.NumericUpDown();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.cbCat = new MetroFramework.Controls.MetroComboBox();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtSPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtPPrice = new MetroFramework.Controls.MetroTextBox();
            this.tbDesc = new MetroFramework.Controls.MetroTextBox();
            this.tip = new MetroFramework.Components.MetroToolTip();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bunifuDropdown1 = new ns1.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CausesValidation = false;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DoubleBuffered = true;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv.HeaderBgColor = System.Drawing.Color.White;
            this.dgv.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv.Location = new System.Drawing.Point(411, 362);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.ShowCellErrors = false;
            this.dgv.ShowRowErrors = false;
            this.dgv.Size = new System.Drawing.Size(491, 166);
            this.dgv.TabIndex = 0;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.metroButton3);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Location = new System.Drawing.Point(670, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 171);
            this.panel1.TabIndex = 5;
            // 
            // metroButton3
            // 
            this.metroButton3.BackgroundImage = global::ElectricStoreMetro.Properties.Resources.delete;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton3.Location = new System.Drawing.Point(26, 117);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 36);
            this.metroButton3.TabIndex = 2;
            this.tip.SetToolTip(this.metroButton3, "Delete");
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::ElectricStoreMetro.Properties.Resources.update;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Location = new System.Drawing.Point(26, 66);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 37);
            this.metroButton2.TabIndex = 1;
            this.tip.SetToolTip(this.metroButton2, "Update");
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::ElectricStoreMetro.Properties.Resources.save;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(26, 11);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 39);
            this.metroButton1.TabIndex = 0;
            this.tip.SetToolTip(this.metroButton1, "Save");
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.numDPercent);
            this.groupBox1.Controls.Add(this.numQty);
            this.groupBox1.Controls.Add(this.cbCat);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(10, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(302, 23);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(68, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Category:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(360, 94);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(35, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Qty:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Enabled = false;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(462, 94);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Discount %";
            this.metroLabel4.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(6, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Name:";
            // 
            // numDPercent
            // 
            this.numDPercent.Enabled = false;
            this.numDPercent.Location = new System.Drawing.Point(462, 117);
            this.numDPercent.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numDPercent.Name = "numDPercent";
            this.numDPercent.ReadOnly = true;
            this.numDPercent.Size = new System.Drawing.Size(93, 20);
            this.numDPercent.TabIndex = 6;
            this.numDPercent.Visible = false;
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(360, 117);
            this.numQty.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.ReadOnly = true;
            this.numQty.Size = new System.Drawing.Size(96, 20);
            this.numQty.TabIndex = 4;
            this.tip.SetToolTip(this.numQty, "Stock Quantity [Required]");
            // 
            // cbCat
            // 
            this.cbCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCat.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.ItemHeight = 19;
            this.cbCat.Location = new System.Drawing.Point(268, 43);
            this.cbCat.Name = "cbCat";
            this.cbCat.PromptText = "Select Category";
            this.cbCat.Size = new System.Drawing.Size(188, 25);
            this.cbCat.TabIndex = 1;
            this.cbCat.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tip.SetToolTip(this.cbCat, "Product Category [Required]");
            this.cbCat.UseSelectable = true;
            this.cbCat.UseStyleColors = true;
            this.cbCat.UseWaitCursor = true;
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCat_SelectedIndexChanged);
            this.cbCat.Click += new System.EventHandler(this.cbCat_Click);
            // 
            // tbName
            // 
            this.tbName.CausesValidation = false;
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.DisplayIcon = true;
            this.tbName.IconRight = true;
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(6, 45);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PromptText = "Item name";
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.ShowButton = true;
            this.tbName.ShowClearButton = true;
            this.tbName.Size = new System.Drawing.Size(256, 23);
            this.tbName.Style = MetroFramework.MetroColorStyle.Green;
            this.tbName.TabIndex = 0;
            this.tbName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tip.SetToolTip(this.tbName, "Item Name [Required]");
            this.tbName.UseSelectable = true;
            this.tbName.WaterMark = "Item name";
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(6, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "S/Price:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(6, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "P/Price:";
            // 
            // txtSPrice
            // 
            this.txtSPrice.CausesValidation = false;
            this.txtSPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtSPrice.CustomButton.Image = null;
            this.txtSPrice.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.txtSPrice.CustomButton.Name = "";
            this.txtSPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSPrice.CustomButton.TabIndex = 1;
            this.txtSPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSPrice.CustomButton.UseSelectable = true;
            this.txtSPrice.DisplayIcon = true;
            this.txtSPrice.IconRight = true;
            this.txtSPrice.Lines = new string[0];
            this.txtSPrice.Location = new System.Drawing.Point(6, 96);
            this.txtSPrice.MaxLength = 32767;
            this.txtSPrice.Name = "txtSPrice";
            this.txtSPrice.PasswordChar = '\0';
            this.txtSPrice.PromptText = "Sale";
            this.txtSPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSPrice.SelectedText = "";
            this.txtSPrice.SelectionLength = 0;
            this.txtSPrice.SelectionStart = 0;
            this.txtSPrice.ShortcutsEnabled = true;
            this.txtSPrice.ShowButton = true;
            this.txtSPrice.ShowClearButton = true;
            this.txtSPrice.Size = new System.Drawing.Size(124, 23);
            this.txtSPrice.Style = MetroFramework.MetroColorStyle.Green;
            this.txtSPrice.TabIndex = 3;
            this.txtSPrice.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tip.SetToolTip(this.txtSPrice, "Sale Price [Required]");
            this.txtSPrice.UseSelectable = true;
            this.txtSPrice.WaterMark = "Sale";
            this.txtSPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSPrice.TextChanged += new System.EventHandler(this.txtSPrice_TextChanged);
            // 
            // txtPPrice
            // 
            this.txtPPrice.CausesValidation = false;
            this.txtPPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtPPrice.CustomButton.Image = null;
            this.txtPPrice.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.txtPPrice.CustomButton.Name = "";
            this.txtPPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPPrice.CustomButton.TabIndex = 1;
            this.txtPPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPPrice.CustomButton.UseSelectable = true;
            this.txtPPrice.DisplayIcon = true;
            this.txtPPrice.IconRight = true;
            this.txtPPrice.Lines = new string[0];
            this.txtPPrice.Location = new System.Drawing.Point(6, 45);
            this.txtPPrice.MaxLength = 32767;
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.PasswordChar = '\0';
            this.txtPPrice.PromptText = "Purchase";
            this.txtPPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPPrice.SelectedText = "";
            this.txtPPrice.SelectionLength = 0;
            this.txtPPrice.SelectionStart = 0;
            this.txtPPrice.ShortcutsEnabled = true;
            this.txtPPrice.ShowButton = true;
            this.txtPPrice.ShowClearButton = true;
            this.txtPPrice.Size = new System.Drawing.Size(124, 23);
            this.txtPPrice.Style = MetroFramework.MetroColorStyle.Green;
            this.txtPPrice.TabIndex = 2;
            this.txtPPrice.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tip.SetToolTip(this.txtPPrice, "Purchase Price [Required]");
            this.txtPPrice.UseSelectable = true;
            this.txtPPrice.WaterMark = "Purchase";
            this.txtPPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPPrice.TextChanged += new System.EventHandler(this.txtPPrice_TextChanged);
            this.txtPPrice.Click += new System.EventHandler(this.txtPPrice_Click);
            // 
            // tbDesc
            // 
            // 
            // 
            // 
            this.tbDesc.CustomButton.Image = null;
            this.tbDesc.CustomButton.Location = new System.Drawing.Point(321, 1);
            this.tbDesc.CustomButton.Name = "";
            this.tbDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDesc.CustomButton.TabIndex = 1;
            this.tbDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDesc.CustomButton.UseSelectable = true;
            this.tbDesc.Lines = new string[0];
            this.tbDesc.Location = new System.Drawing.Point(126, 215);
            this.tbDesc.MaxLength = 32767;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.PasswordChar = '\0';
            this.tbDesc.PromptText = "some description";
            this.tbDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDesc.SelectedText = "";
            this.tbDesc.SelectionLength = 0;
            this.tbDesc.SelectionStart = 0;
            this.tbDesc.ShortcutsEnabled = true;
            this.tbDesc.ShowButton = true;
            this.tbDesc.ShowClearButton = true;
            this.tbDesc.Size = new System.Drawing.Size(343, 23);
            this.tbDesc.Style = MetroFramework.MetroColorStyle.Green;
            this.tbDesc.TabIndex = 0;
            this.tbDesc.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tip.SetToolTip(this.tbDesc, "Description [Not Required]");
            this.tbDesc.UseSelectable = true;
            this.tbDesc.WaterMark = "some description";
            this.tbDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tip
            // 
            this.tip.Style = MetroFramework.MetroColorStyle.Blue;
            this.tip.StyleManager = null;
            this.tip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton4
            // 
            this.metroButton4.BackgroundImage = global::ElectricStoreMetro.Properties.Resources.shudown;
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton4.Location = new System.Drawing.Point(574, 20);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 37);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton4.TabIndex = 1;
            this.tip.SetToolTip(this.metroButton4, "Close");
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(9, 215);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(81, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Description:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSPrice);
            this.groupBox2.Controls.Add(this.txtPPrice);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Location = new System.Drawing.Point(24, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 127);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bunifuDropdown1);
            this.groupBox3.Location = new System.Drawing.Point(24, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 127);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Measurements";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(4, 19);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown1.TabIndex = 0;
            // 
            // frProduct
            // 
            this.AcceptButton = this.metroButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 541);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Name = "frProduct";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Create / Manage Product";
            this.TransparencyKey = System.Drawing.Color.RoyalBlue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frProduct_FormClosing);
            this.Load += new System.EventHandler(this.frProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomDataGrid dgv;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cbCat;
        private MetroFramework.Controls.MetroTextBox tbName;
        private System.Windows.Forms.NumericUpDown numQty;
        private MetroFramework.Components.MetroToolTip tip;
        private MetroFramework.Controls.MetroTextBox tbDesc;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.ErrorProvider error;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSPrice;
        private MetroFramework.Controls.MetroTextBox txtPPrice;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.NumericUpDown numDPercent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private ns1.BunifuDropdown bunifuDropdown1;
    }
}
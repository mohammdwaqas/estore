namespace ElectricStoreMetro.MainForm.Return
{
    partial class frReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frReturn));
            this.txtOrderNo = new MetroFramework.Controls.MetroTextBox();
            this.btnGet = new MetroFramework.Controls.MetroButton();
            this.dgvProducts = new ns1.BunifuCustomDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelSelectQty = new System.Windows.Forms.Panel();
            this.btnSelectQty = new MetroFramework.Controls.MetroButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPaymentDue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalToPay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInvDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOriginalAmt = new MetroFramework.Controls.MetroTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOrderItemID = new MetroFramework.Controls.MetroTextBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOrder = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConvertedQty = new MetroFramework.Controls.MetroTextBox();
            this.lblConvertedQty = new System.Windows.Forms.Label();
            this.txtUnit = new MetroFramework.Controls.MetroTextBox();
            this.cboMeasurement = new System.Windows.Forms.ComboBox();
            this.txtTotalAmt = new MetroFramework.Controls.MetroTextBox();
            this.txtItemID = new MetroFramework.Controls.MetroTextBox();
            this.txtUnitPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtItemName = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.txtQtyToRemove = new System.Windows.Forms.TextBox();
            this.btnUpdateOrder = new MetroFramework.Controls.MetroButton();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelSelectQty.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrderNo
            // 
            // 
            // 
            // 
            this.txtOrderNo.CustomButton.Image = null;
            this.txtOrderNo.CustomButton.Location = new System.Drawing.Point(327, 2);
            this.txtOrderNo.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderNo.CustomButton.Name = "";
            this.txtOrderNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtOrderNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrderNo.CustomButton.TabIndex = 1;
            this.txtOrderNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrderNo.CustomButton.UseSelectable = true;
            this.txtOrderNo.DisplayIcon = true;
            this.txtOrderNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOrderNo.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtOrderNo.IconRight = true;
            this.txtOrderNo.Lines = new string[0];
            this.txtOrderNo.Location = new System.Drawing.Point(16, 15);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderNo.MaxLength = 32767;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.PasswordChar = '\0';
            this.txtOrderNo.PromptText = "Order No..";
            this.txtOrderNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderNo.SelectedText = "";
            this.txtOrderNo.SelectionLength = 0;
            this.txtOrderNo.SelectionStart = 0;
            this.txtOrderNo.ShortcutsEnabled = true;
            this.txtOrderNo.ShowButton = true;
            this.txtOrderNo.ShowClearButton = true;
            this.txtOrderNo.Size = new System.Drawing.Size(353, 28);
            this.txtOrderNo.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.txtOrderNo, "Please enter valid order no here");
            this.txtOrderNo.UseSelectable = true;
            this.txtOrderNo.WaterMark = "Order No..";
            this.txtOrderNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrderNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(889, 15);
            this.btnGet.Margin = new System.Windows.Forms.Padding(4);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 28);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Get Order";
            this.btnGet.UseSelectable = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.DoubleBuffered = true;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvProducts.HeaderForeColor = System.Drawing.Color.White;
            this.dgvProducts.Location = new System.Drawing.Point(16, 73);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(973, 185);
            this.dgvProducts.TabIndex = 3;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelSelectQty);
            this.groupBox1.Controls.Add(this.lblPaymentDue);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblTotalPayment);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblDiscount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTotalToPay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblInvDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(632, 266);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(357, 234);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Info:";
            // 
            // panelSelectQty
            // 
            this.panelSelectQty.Controls.Add(this.btnSelectQty);
            this.panelSelectQty.Controls.Add(this.label7);
            this.panelSelectQty.Location = new System.Drawing.Point(23, 83);
            this.panelSelectQty.Name = "panelSelectQty";
            this.panelSelectQty.Size = new System.Drawing.Size(155, 100);
            this.panelSelectQty.TabIndex = 13;
            this.metroToolTip1.SetToolTip(this.panelSelectQty, "Select Quantity");
            // 
            // btnSelectQty
            // 
            this.btnSelectQty.Location = new System.Drawing.Point(15, 65);
            this.btnSelectQty.Name = "btnSelectQty";
            this.btnSelectQty.Size = new System.Drawing.Size(120, 23);
            this.btnSelectQty.TabIndex = 2;
            this.btnSelectQty.Text = "OK";
            this.btnSelectQty.UseSelectable = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Select Quantity:";
            // 
            // lblPaymentDue
            // 
            this.lblPaymentDue.AutoSize = true;
            this.lblPaymentDue.Location = new System.Drawing.Point(113, 185);
            this.lblPaymentDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentDue.Name = "lblPaymentDue";
            this.lblPaymentDue.Size = new System.Drawing.Size(95, 16);
            this.lblPaymentDue.TabIndex = 7;
            this.lblPaymentDue.Text = "Due Payment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Payment Due:";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Location = new System.Drawing.Point(113, 144);
            this.lblTotalPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(104, 16);
            this.lblTotalPayment.TabIndex = 5;
            this.lblTotalPayment.Text = "Total Payment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Payment:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(113, 101);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(65, 16);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doscount:";
            // 
            // lblTotalToPay
            // 
            this.lblTotalToPay.AutoSize = true;
            this.lblTotalToPay.Location = new System.Drawing.Point(112, 64);
            this.lblTotalToPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalToPay.Name = "lblTotalToPay";
            this.lblTotalToPay.Size = new System.Drawing.Size(42, 16);
            this.lblTotalToPay.TabIndex = 1;
            this.lblTotalToPay.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total To pay:";
            // 
            // lblInvDate
            // 
            this.lblInvDate.AutoSize = true;
            this.lblInvDate.Location = new System.Drawing.Point(112, 25);
            this.lblInvDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvDate.Name = "lblInvDate";
            this.lblInvDate.Size = new System.Drawing.Size(98, 16);
            this.lblInvDate.TabIndex = 0;
            this.lblInvDate.Text = "Invoice Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Invoice Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cart Items";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(17, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 280);
            this.panel1.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtOriginalAmt);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtQty);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtOrderItemID);
            this.groupBox3.Controls.Add(this.numQty);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtOrder);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtConvertedQty);
            this.groupBox3.Controls.Add(this.lblConvertedQty);
            this.groupBox3.Controls.Add(this.txtUnit);
            this.groupBox3.Controls.Add(this.cboMeasurement);
            this.groupBox3.Controls.Add(this.txtTotalAmt);
            this.groupBox3.Controls.Add(this.txtItemID);
            this.groupBox3.Controls.Add(this.txtUnitPrice);
            this.groupBox3.Controls.Add(this.txtItemName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(5, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(488, 272);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Details:";
            // 
            // txtOriginalAmt
            // 
            // 
            // 
            // 
            this.txtOriginalAmt.CustomButton.Image = null;
            this.txtOriginalAmt.CustomButton.Location = new System.Drawing.Point(101, 2);
            this.txtOriginalAmt.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtOriginalAmt.CustomButton.Name = "";
            this.txtOriginalAmt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtOriginalAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOriginalAmt.CustomButton.TabIndex = 1;
            this.txtOriginalAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOriginalAmt.CustomButton.UseSelectable = true;
            this.txtOriginalAmt.CustomButton.Visible = false;
            this.txtOriginalAmt.Lines = new string[0];
            this.txtOriginalAmt.Location = new System.Drawing.Point(351, 185);
            this.txtOriginalAmt.Margin = new System.Windows.Forms.Padding(4);
            this.txtOriginalAmt.MaxLength = 32767;
            this.txtOriginalAmt.Name = "txtOriginalAmt";
            this.txtOriginalAmt.PasswordChar = '\0';
            this.txtOriginalAmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOriginalAmt.SelectedText = "";
            this.txtOriginalAmt.SelectionLength = 0;
            this.txtOriginalAmt.SelectionStart = 0;
            this.txtOriginalAmt.ShortcutsEnabled = true;
            this.txtOriginalAmt.Size = new System.Drawing.Size(127, 28);
            this.txtOriginalAmt.TabIndex = 50;
            this.txtOriginalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOriginalAmt.UseSelectable = true;
            this.txtOriginalAmt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOriginalAmt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(245, 197);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 16);
            this.label16.TabIndex = 49;
            this.label16.Text = "Original Amt:";
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.CustomButton.Image = null;
            this.txtQty.CustomButton.Location = new System.Drawing.Point(89, 2);
            this.txtQty.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.CustomButton.Name = "";
            this.txtQty.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQty.CustomButton.TabIndex = 1;
            this.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQty.CustomButton.UseSelectable = true;
            this.txtQty.CustomButton.Visible = false;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(122, 185);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.MaxLength = 32767;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(115, 28);
            this.txtQty.TabIndex = 48;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.UseSelectable = true;
            this.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQty.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 197);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 16);
            this.label15.TabIndex = 47;
            this.label15.Text = "Original Qty";
            // 
            // txtOrderItemID
            // 
            // 
            // 
            // 
            this.txtOrderItemID.CustomButton.Image = null;
            this.txtOrderItemID.CustomButton.Location = new System.Drawing.Point(334, 2);
            this.txtOrderItemID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderItemID.CustomButton.Name = "";
            this.txtOrderItemID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtOrderItemID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrderItemID.CustomButton.TabIndex = 1;
            this.txtOrderItemID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrderItemID.CustomButton.UseSelectable = true;
            this.txtOrderItemID.CustomButton.Visible = false;
            this.txtOrderItemID.Lines = new string[0];
            this.txtOrderItemID.Location = new System.Drawing.Point(122, 61);
            this.txtOrderItemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderItemID.MaxLength = 32767;
            this.txtOrderItemID.Name = "txtOrderItemID";
            this.txtOrderItemID.PasswordChar = '\0';
            this.txtOrderItemID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderItemID.SelectedText = "";
            this.txtOrderItemID.SelectionLength = 0;
            this.txtOrderItemID.SelectionStart = 0;
            this.txtOrderItemID.ShortcutsEnabled = true;
            this.txtOrderItemID.Size = new System.Drawing.Size(360, 28);
            this.txtOrderItemID.TabIndex = 46;
            this.txtOrderItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOrderItemID.UseSelectable = true;
            this.txtOrderItemID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrderItemID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // numQty
            // 
            this.numQty.Enabled = false;
            this.numQty.Location = new System.Drawing.Point(84, 161);
            this.numQty.Name = "numQty";
            this.numQty.ReadOnly = true;
            this.numQty.Size = new System.Drawing.Size(154, 23);
            this.numQty.TabIndex = 1;
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 66);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 16);
            this.label14.TabIndex = 45;
            this.label14.Text = "OrderItemID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(251, 104);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 16);
            this.label13.TabIndex = 44;
            this.label13.Text = "ID:";
            // 
            // txtOrder
            // 
            // 
            // 
            // 
            this.txtOrder.CustomButton.Image = null;
            this.txtOrder.CustomButton.Location = new System.Drawing.Point(368, 2);
            this.txtOrder.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrder.CustomButton.Name = "";
            this.txtOrder.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtOrder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrder.CustomButton.TabIndex = 1;
            this.txtOrder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrder.CustomButton.UseSelectable = true;
            this.txtOrder.CustomButton.Visible = false;
            this.txtOrder.Lines = new string[0];
            this.txtOrder.Location = new System.Drawing.Point(88, 25);
            this.txtOrder.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrder.MaxLength = 32767;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.PasswordChar = '\0';
            this.txtOrder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrder.SelectedText = "";
            this.txtOrder.SelectionLength = 0;
            this.txtOrder.SelectionStart = 0;
            this.txtOrder.ShortcutsEnabled = true;
            this.txtOrder.Size = new System.Drawing.Size(394, 28);
            this.txtOrder.TabIndex = 43;
            this.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOrder.UseSelectable = true;
            this.txtOrder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Order#:";
            // 
            // txtConvertedQty
            // 
            // 
            // 
            // 
            this.txtConvertedQty.CustomButton.Image = null;
            this.txtConvertedQty.CustomButton.Location = new System.Drawing.Point(55, 2);
            this.txtConvertedQty.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtConvertedQty.CustomButton.Name = "";
            this.txtConvertedQty.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConvertedQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConvertedQty.CustomButton.TabIndex = 1;
            this.txtConvertedQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConvertedQty.CustomButton.UseSelectable = true;
            this.txtConvertedQty.CustomButton.Visible = false;
            this.txtConvertedQty.Lines = new string[0];
            this.txtConvertedQty.Location = new System.Drawing.Point(65, 228);
            this.txtConvertedQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtConvertedQty.MaxLength = 32767;
            this.txtConvertedQty.Name = "txtConvertedQty";
            this.txtConvertedQty.PasswordChar = '\0';
            this.txtConvertedQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConvertedQty.SelectedText = "";
            this.txtConvertedQty.SelectionLength = 0;
            this.txtConvertedQty.SelectionStart = 0;
            this.txtConvertedQty.ShortcutsEnabled = true;
            this.txtConvertedQty.Size = new System.Drawing.Size(81, 28);
            this.txtConvertedQty.TabIndex = 41;
            this.txtConvertedQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConvertedQty.UseSelectable = true;
            this.txtConvertedQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConvertedQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblConvertedQty
            // 
            this.lblConvertedQty.AutoSize = true;
            this.lblConvertedQty.Location = new System.Drawing.Point(20, 237);
            this.lblConvertedQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConvertedQty.Name = "lblConvertedQty";
            this.lblConvertedQty.Size = new System.Drawing.Size(32, 16);
            this.lblConvertedQty.TabIndex = 40;
            this.lblConvertedQty.Text = "Qty";
            // 
            // txtUnit
            // 
            // 
            // 
            // 
            this.txtUnit.CustomButton.Image = null;
            this.txtUnit.CustomButton.Location = new System.Drawing.Point(210, 2);
            this.txtUnit.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnit.CustomButton.Name = "";
            this.txtUnit.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtUnit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnit.CustomButton.TabIndex = 1;
            this.txtUnit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnit.CustomButton.UseSelectable = true;
            this.txtUnit.CustomButton.Visible = false;
            this.txtUnit.Lines = new string[0];
            this.txtUnit.Location = new System.Drawing.Point(246, 127);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnit.MaxLength = 32767;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PasswordChar = '\0';
            this.txtUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnit.SelectedText = "";
            this.txtUnit.SelectionLength = 0;
            this.txtUnit.SelectionStart = 0;
            this.txtUnit.ShortcutsEnabled = true;
            this.txtUnit.Size = new System.Drawing.Size(236, 28);
            this.txtUnit.TabIndex = 38;
            this.txtUnit.UseSelectable = true;
            this.txtUnit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboMeasurement
            // 
            this.cboMeasurement.Enabled = false;
            this.cboMeasurement.FormattingEnabled = true;
            this.cboMeasurement.Location = new System.Drawing.Point(244, 161);
            this.cboMeasurement.Name = "cboMeasurement";
            this.cboMeasurement.Size = new System.Drawing.Size(236, 24);
            this.cboMeasurement.TabIndex = 36;
            // 
            // txtTotalAmt
            // 
            // 
            // 
            // 
            this.txtTotalAmt.CustomButton.Image = null;
            this.txtTotalAmt.CustomButton.Location = new System.Drawing.Point(117, 2);
            this.txtTotalAmt.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmt.CustomButton.Name = "";
            this.txtTotalAmt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTotalAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalAmt.CustomButton.TabIndex = 1;
            this.txtTotalAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalAmt.CustomButton.UseSelectable = true;
            this.txtTotalAmt.CustomButton.Visible = false;
            this.txtTotalAmt.Lines = new string[0];
            this.txtTotalAmt.Location = new System.Drawing.Point(244, 225);
            this.txtTotalAmt.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmt.MaxLength = 32767;
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.PasswordChar = '\0';
            this.txtTotalAmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalAmt.SelectedText = "";
            this.txtTotalAmt.SelectionLength = 0;
            this.txtTotalAmt.SelectionStart = 0;
            this.txtTotalAmt.ShortcutsEnabled = true;
            this.txtTotalAmt.Size = new System.Drawing.Size(143, 28);
            this.txtTotalAmt.TabIndex = 6;
            this.txtTotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalAmt.UseSelectable = true;
            this.txtTotalAmt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalAmt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtItemID
            // 
            // 
            // 
            // 
            this.txtItemID.CustomButton.Image = null;
            this.txtItemID.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtItemID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemID.CustomButton.Name = "";
            this.txtItemID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtItemID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemID.CustomButton.TabIndex = 1;
            this.txtItemID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemID.CustomButton.UseSelectable = true;
            this.txtItemID.CustomButton.Visible = false;
            this.txtItemID.Lines = new string[0];
            this.txtItemID.Location = new System.Drawing.Point(286, 97);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemID.MaxLength = 32767;
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.PasswordChar = '\0';
            this.txtItemID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemID.SelectedText = "";
            this.txtItemID.SelectionLength = 0;
            this.txtItemID.SelectionStart = 0;
            this.txtItemID.ShortcutsEnabled = true;
            this.txtItemID.Size = new System.Drawing.Size(192, 28);
            this.txtItemID.TabIndex = 6;
            this.txtItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemID.UseSelectable = true;
            this.txtItemID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUnitPrice
            // 
            // 
            // 
            // 
            this.txtUnitPrice.CustomButton.Image = null;
            this.txtUnitPrice.CustomButton.Location = new System.Drawing.Point(133, 2);
            this.txtUnitPrice.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.CustomButton.Name = "";
            this.txtUnitPrice.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtUnitPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnitPrice.CustomButton.TabIndex = 1;
            this.txtUnitPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnitPrice.CustomButton.UseSelectable = true;
            this.txtUnitPrice.CustomButton.Visible = false;
            this.txtUnitPrice.Lines = new string[] {
        "0"};
            this.txtUnitPrice.Location = new System.Drawing.Point(84, 127);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.MaxLength = 32767;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PasswordChar = '\0';
            this.txtUnitPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnitPrice.SelectedText = "";
            this.txtUnitPrice.SelectionLength = 0;
            this.txtUnitPrice.SelectionStart = 0;
            this.txtUnitPrice.ShortcutsEnabled = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(159, 28);
            this.txtUnitPrice.TabIndex = 6;
            this.txtUnitPrice.Text = "0";
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnitPrice.UseSelectable = true;
            this.txtUnitPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnitPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtItemName
            // 
            // 
            // 
            // 
            this.txtItemName.CustomButton.Image = null;
            this.txtItemName.CustomButton.Location = new System.Drawing.Point(133, 2);
            this.txtItemName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.CustomButton.Name = "";
            this.txtItemName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemName.CustomButton.TabIndex = 1;
            this.txtItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemName.CustomButton.UseSelectable = true;
            this.txtItemName.CustomButton.Visible = false;
            this.txtItemName.Lines = new string[0];
            this.txtItemName.Location = new System.Drawing.Point(84, 97);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.MaxLength = 32767;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemName.SelectedText = "";
            this.txtItemName.SelectionLength = 0;
            this.txtItemName.SelectionStart = 0;
            this.txtItemName.ShortcutsEnabled = true;
            this.txtItemName.Size = new System.Drawing.Size(159, 28);
            this.txtItemName.TabIndex = 6;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemName.UseSelectable = true;
            this.txtItemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 237);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total Amt:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Required:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Price:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 102);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Name:";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(910, 507);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 25);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtQtyToRemove
            // 
            this.txtQtyToRemove.Location = new System.Drawing.Point(390, 20);
            this.txtQtyToRemove.Name = "txtQtyToRemove";
            this.txtQtyToRemove.Size = new System.Drawing.Size(144, 23);
            this.txtQtyToRemove.TabIndex = 12;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(632, 508);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(142, 23);
            this.btnUpdateOrder.TabIndex = 13;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseSelectable = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            // 
            // frReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1005, 558);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.txtQtyToRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtOrderNo);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return products or Remove products from order";
            this.Load += new System.EventHandler(this.frReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelSelectQty.ResumeLayout(false);
            this.panelSelectQty.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtOrderNo;
        private MetroFramework.Controls.MetroButton btnGet;
        private ns1.BunifuCustomDataGrid dgvProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalToPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInvDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPaymentDue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroButton btnClose;
        private System.Windows.Forms.TextBox txtQtyToRemove;
        private System.Windows.Forms.Panel panelSelectQty;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroButton btnSelectQty;
        private System.Windows.Forms.GroupBox groupBox3;
        public MetroFramework.Controls.MetroTextBox txtConvertedQty;
        private System.Windows.Forms.Label lblConvertedQty;
        public MetroFramework.Controls.MetroTextBox txtUnit;
        private System.Windows.Forms.ComboBox cboMeasurement;
        public MetroFramework.Controls.MetroTextBox txtTotalAmt;
        public MetroFramework.Controls.MetroTextBox txtItemID;
        public MetroFramework.Controls.MetroTextBox txtUnitPrice;
        public MetroFramework.Controls.MetroTextBox txtItemName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public MetroFramework.Controls.MetroTextBox txtOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        public MetroFramework.Controls.MetroTextBox txtOrderItemID;
        private System.Windows.Forms.Label label14;
        private MetroFramework.Controls.MetroButton btnUpdateOrder;
        public MetroFramework.Controls.MetroTextBox txtQty;
        private System.Windows.Forms.Label label15;
        public MetroFramework.Controls.MetroTextBox txtOriginalAmt;
        private System.Windows.Forms.Label label16;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
    }
}
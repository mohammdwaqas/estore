namespace ElectricStoreMetro.MainForm.Sale
{
    partial class frUpdateOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frUpdateOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderNo = new MetroFramework.Controls.MetroTextBox();
            this.dgv = new ns1.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPaymentDue = new MetroFramework.Controls.MetroTextBox();
            this.txtTotalPayment = new MetroFramework.Controls.MetroTextBox();
            this.txtGrandTotal = new MetroFramework.Controls.MetroTextBox();
            this.txtDiscount = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalToPay = new System.Windows.Forms.Label();
            this.btnFetchOrder = new MetroFramework.Controls.MetroButton();
            this.brnProcess = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.panelQucikLinks = new System.Windows.Forms.Panel();
            this.btnReturnTransaction = new ns1.BunifuTileButton();
            this.btnCreateNewSale = new ns1.BunifuTileButton();
            this.btnCreateUserAccount = new ns1.BunifuTileButton();
            this.btnCreateNewProduct = new ns1.BunifuTileButton();
            this.btnCreateProductCategories = new ns1.BunifuTileButton();
            this.panelGuides = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelQucikLinks.SuspendLayout();
            this.panelGuides.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order No..";
            // 
            // txtOrderNo
            // 
            // 
            // 
            // 
            this.txtOrderNo.CustomButton.Image = null;
            this.txtOrderNo.CustomButton.Location = new System.Drawing.Point(230, 2);
            this.txtOrderNo.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderNo.CustomButton.Name = "";
            this.txtOrderNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtOrderNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrderNo.CustomButton.TabIndex = 1;
            this.txtOrderNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrderNo.CustomButton.UseSelectable = true;
            this.txtOrderNo.CustomButton.Visible = false;
            this.txtOrderNo.Lines = new string[0];
            this.txtOrderNo.Location = new System.Drawing.Point(488, 36);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderNo.MaxLength = 32767;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.PasswordChar = '\0';
            this.txtOrderNo.PromptText = "Valid order no..";
            this.txtOrderNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderNo.SelectedText = "";
            this.txtOrderNo.SelectionLength = 0;
            this.txtOrderNo.SelectionStart = 0;
            this.txtOrderNo.ShortcutsEnabled = true;
            this.txtOrderNo.Size = new System.Drawing.Size(256, 28);
            this.txtOrderNo.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.txtOrderNo, "Type order no here");
            this.txtOrderNo.UseSelectable = true;
            this.txtOrderNo.WaterMark = "Valid order no..";
            this.txtOrderNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrderNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.dgv.Location = new System.Drawing.Point(488, 100);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.Size = new System.Drawing.Size(636, 193);
            this.dgv.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPaymentDue);
            this.panel1.Controls.Add(this.txtTotalPayment);
            this.panel1.Controls.Add(this.txtGrandTotal);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblTotalToPay);
            this.panel1.Location = new System.Drawing.Point(857, 306);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 177);
            this.panel1.TabIndex = 3;
            // 
            // txtPaymentDue
            // 
            // 
            // 
            // 
            this.txtPaymentDue.CustomButton.Image = null;
            this.txtPaymentDue.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.txtPaymentDue.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentDue.CustomButton.Name = "";
            this.txtPaymentDue.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPaymentDue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentDue.CustomButton.TabIndex = 1;
            this.txtPaymentDue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentDue.CustomButton.UseSelectable = true;
            this.txtPaymentDue.CustomButton.Visible = false;
            this.txtPaymentDue.Enabled = false;
            this.txtPaymentDue.Lines = new string[0];
            this.txtPaymentDue.Location = new System.Drawing.Point(120, 114);
            this.txtPaymentDue.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentDue.MaxLength = 32767;
            this.txtPaymentDue.Name = "txtPaymentDue";
            this.txtPaymentDue.PasswordChar = '\0';
            this.txtPaymentDue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentDue.SelectedText = "";
            this.txtPaymentDue.SelectionLength = 0;
            this.txtPaymentDue.SelectionStart = 0;
            this.txtPaymentDue.ShortcutsEnabled = true;
            this.txtPaymentDue.Size = new System.Drawing.Size(135, 28);
            this.txtPaymentDue.TabIndex = 8;
            this.txtPaymentDue.UseSelectable = true;
            this.txtPaymentDue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentDue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTotalPayment
            // 
            // 
            // 
            // 
            this.txtTotalPayment.CustomButton.Image = null;
            this.txtTotalPayment.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.txtTotalPayment.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPayment.CustomButton.Name = "";
            this.txtTotalPayment.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTotalPayment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalPayment.CustomButton.TabIndex = 1;
            this.txtTotalPayment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalPayment.CustomButton.UseSelectable = true;
            this.txtTotalPayment.CustomButton.Visible = false;
            this.txtTotalPayment.Lines = new string[] {
        "0"};
            this.txtTotalPayment.Location = new System.Drawing.Point(120, 86);
            this.txtTotalPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPayment.MaxLength = 32767;
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.PasswordChar = '\0';
            this.txtTotalPayment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalPayment.SelectedText = "";
            this.txtTotalPayment.SelectionLength = 0;
            this.txtTotalPayment.SelectionStart = 0;
            this.txtTotalPayment.ShortcutsEnabled = true;
            this.txtTotalPayment.Size = new System.Drawing.Size(135, 28);
            this.txtTotalPayment.TabIndex = 7;
            this.txtTotalPayment.Text = "0";
            this.metroToolTip1.SetToolTip(this.txtTotalPayment, "Total Payment");
            this.txtTotalPayment.UseSelectable = true;
            this.txtTotalPayment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalPayment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalPayment.TextChanged += new System.EventHandler(this.txtTotalPayment_TextChanged);
            // 
            // txtGrandTotal
            // 
            // 
            // 
            // 
            this.txtGrandTotal.CustomButton.Image = null;
            this.txtGrandTotal.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.txtGrandTotal.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrandTotal.CustomButton.Name = "";
            this.txtGrandTotal.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtGrandTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGrandTotal.CustomButton.TabIndex = 1;
            this.txtGrandTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrandTotal.CustomButton.UseSelectable = true;
            this.txtGrandTotal.CustomButton.Visible = false;
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Lines = new string[0];
            this.txtGrandTotal.Location = new System.Drawing.Point(120, 58);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrandTotal.MaxLength = 32767;
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.PasswordChar = '\0';
            this.txtGrandTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrandTotal.SelectedText = "";
            this.txtGrandTotal.SelectionLength = 0;
            this.txtGrandTotal.SelectionStart = 0;
            this.txtGrandTotal.ShortcutsEnabled = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(135, 28);
            this.txtGrandTotal.TabIndex = 7;
            this.txtGrandTotal.UseSelectable = true;
            this.txtGrandTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrandTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDiscount
            // 
            // 
            // 
            // 
            this.txtDiscount.CustomButton.Image = null;
            this.txtDiscount.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.txtDiscount.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.CustomButton.Name = "";
            this.txtDiscount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscount.CustomButton.TabIndex = 1;
            this.txtDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscount.CustomButton.UseSelectable = true;
            this.txtDiscount.CustomButton.Visible = false;
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Lines = new string[] {
        "0"};
            this.txtDiscount.Location = new System.Drawing.Point(120, 30);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.MaxLength = 32767;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionLength = 0;
            this.txtDiscount.SelectionStart = 0;
            this.txtDiscount.ShortcutsEnabled = true;
            this.txtDiscount.Size = new System.Drawing.Size(135, 28);
            this.txtDiscount.TabIndex = 7;
            this.txtDiscount.Text = "0";
            this.txtDiscount.UseSelectable = true;
            this.txtDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Payment Due:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Total Payment:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Grand Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Discount";
            // 
            // lblTotalToPay
            // 
            this.lblTotalToPay.BackColor = System.Drawing.Color.White;
            this.lblTotalToPay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalToPay.Enabled = false;
            this.lblTotalToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalToPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalToPay.Location = new System.Drawing.Point(0, 0);
            this.lblTotalToPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalToPay.Name = "lblTotalToPay";
            this.lblTotalToPay.Size = new System.Drawing.Size(264, 25);
            this.lblTotalToPay.TabIndex = 0;
            this.lblTotalToPay.Text = "0.00";
            this.lblTotalToPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFetchOrder
            // 
            this.btnFetchOrder.BackgroundImage = global::ElectricStoreMetro.Properties.Resources.ok;
            this.btnFetchOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFetchOrder.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFetchOrder.Highlight = true;
            this.btnFetchOrder.Location = new System.Drawing.Point(844, 36);
            this.btnFetchOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnFetchOrder.Name = "btnFetchOrder";
            this.btnFetchOrder.Size = new System.Drawing.Size(280, 28);
            this.btnFetchOrder.Style = MetroFramework.MetroColorStyle.Black;
            this.btnFetchOrder.TabIndex = 4;
            this.btnFetchOrder.Text = "                                      Fetch Order";
            this.metroToolTip1.SetToolTip(this.btnFetchOrder, "Get Order from database");
            this.btnFetchOrder.UseSelectable = true;
            this.btnFetchOrder.Click += new System.EventHandler(this.btnFetchOrder_Click);
            // 
            // brnProcess
            // 
            this.brnProcess.AutoSize = true;
            this.brnProcess.BackgroundImage = global::ElectricStoreMetro.Properties.Resources.ok;
            this.brnProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.brnProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnProcess.DisplayFocus = true;
            this.brnProcess.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.brnProcess.Highlight = true;
            this.brnProcess.Location = new System.Drawing.Point(857, 483);
            this.brnProcess.Margin = new System.Windows.Forms.Padding(4);
            this.brnProcess.Name = "brnProcess";
            this.brnProcess.Size = new System.Drawing.Size(267, 36);
            this.brnProcess.Style = MetroFramework.MetroColorStyle.Black;
            this.brnProcess.TabIndex = 5;
            this.brnProcess.Text = "Process Trans..";
            this.brnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnProcess.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.brnProcess, "Process transaction..");
            this.brnProcess.UseSelectable = true;
            this.brnProcess.Click += new System.EventHandler(this.brnProcess_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ElectricStoreMetro.Properties.Resources.shudown;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(1024, 527);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelQucikLinks
            // 
            this.panelQucikLinks.Controls.Add(this.btnReturnTransaction);
            this.panelQucikLinks.Controls.Add(this.btnCreateNewSale);
            this.panelQucikLinks.Controls.Add(this.btnCreateUserAccount);
            this.panelQucikLinks.Controls.Add(this.btnCreateNewProduct);
            this.panelQucikLinks.Controls.Add(this.btnCreateProductCategories);
            this.panelQucikLinks.Location = new System.Drawing.Point(16, 15);
            this.panelQucikLinks.Margin = new System.Windows.Forms.Padding(4);
            this.panelQucikLinks.Name = "panelQucikLinks";
            this.panelQucikLinks.Size = new System.Drawing.Size(464, 254);
            this.panelQucikLinks.TabIndex = 7;
            // 
            // btnReturnTransaction
            // 
            this.btnReturnTransaction.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReturnTransaction.color = System.Drawing.Color.SeaGreen;
            this.btnReturnTransaction.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnReturnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnTransaction.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnReturnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnReturnTransaction.Image = global::ElectricStoreMetro.Properties.Resources.return2;
            this.btnReturnTransaction.ImagePosition = 20;
            this.btnReturnTransaction.ImageZoom = 40;
            this.btnReturnTransaction.LabelPosition = 41;
            this.btnReturnTransaction.LabelText = "Return";
            this.btnReturnTransaction.Location = new System.Drawing.Point(251, 127);
            this.btnReturnTransaction.Margin = new System.Windows.Forms.Padding(6);
            this.btnReturnTransaction.Name = "btnReturnTransaction";
            this.btnReturnTransaction.Size = new System.Drawing.Size(175, 118);
            this.btnReturnTransaction.TabIndex = 1;
            this.btnReturnTransaction.Click += new System.EventHandler(this.btnReturnTransaction_Click);
            // 
            // btnCreateNewSale
            // 
            this.btnCreateNewSale.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreateNewSale.color = System.Drawing.Color.SeaGreen;
            this.btnCreateNewSale.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateNewSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNewSale.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCreateNewSale.ForeColor = System.Drawing.Color.White;
            this.btnCreateNewSale.Image = global::ElectricStoreMetro.Properties.Resources.sale;
            this.btnCreateNewSale.ImagePosition = 20;
            this.btnCreateNewSale.ImageZoom = 20;
            this.btnCreateNewSale.LabelPosition = 41;
            this.btnCreateNewSale.LabelText = "New Sale";
            this.btnCreateNewSale.Location = new System.Drawing.Point(7, 127);
            this.btnCreateNewSale.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateNewSale.Name = "btnCreateNewSale";
            this.btnCreateNewSale.Size = new System.Drawing.Size(243, 118);
            this.btnCreateNewSale.TabIndex = 2;
            this.btnCreateNewSale.Click += new System.EventHandler(this.btnCreateNewSale_Click);
            // 
            // btnCreateUserAccount
            // 
            this.btnCreateUserAccount.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreateUserAccount.color = System.Drawing.Color.SeaGreen;
            this.btnCreateUserAccount.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateUserAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateUserAccount.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCreateUserAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateUserAccount.Image = global::ElectricStoreMetro.Properties.Resources.accounts;
            this.btnCreateUserAccount.ImagePosition = 20;
            this.btnCreateUserAccount.ImageZoom = 50;
            this.btnCreateUserAccount.LabelPosition = 41;
            this.btnCreateUserAccount.LabelText = "Accounts";
            this.btnCreateUserAccount.Location = new System.Drawing.Point(287, 6);
            this.btnCreateUserAccount.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateUserAccount.Name = "btnCreateUserAccount";
            this.btnCreateUserAccount.Size = new System.Drawing.Size(139, 118);
            this.btnCreateUserAccount.TabIndex = 0;
            this.btnCreateUserAccount.Click += new System.EventHandler(this.btnCreateUserAccount_Click);
            // 
            // btnCreateNewProduct
            // 
            this.btnCreateNewProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreateNewProduct.color = System.Drawing.Color.SeaGreen;
            this.btnCreateNewProduct.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateNewProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNewProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCreateNewProduct.ForeColor = System.Drawing.Color.White;
            this.btnCreateNewProduct.Image = global::ElectricStoreMetro.Properties.Resources.items;
            this.btnCreateNewProduct.ImagePosition = 20;
            this.btnCreateNewProduct.ImageZoom = 40;
            this.btnCreateNewProduct.LabelPosition = 41;
            this.btnCreateNewProduct.LabelText = "Products";
            this.btnCreateNewProduct.Location = new System.Drawing.Point(147, 6);
            this.btnCreateNewProduct.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateNewProduct.Name = "btnCreateNewProduct";
            this.btnCreateNewProduct.Size = new System.Drawing.Size(139, 118);
            this.btnCreateNewProduct.TabIndex = 0;
            this.btnCreateNewProduct.Click += new System.EventHandler(this.btnCreateNewProduct_Click);
            // 
            // btnCreateProductCategories
            // 
            this.btnCreateProductCategories.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreateProductCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCreateProductCategories.color = System.Drawing.Color.SeaGreen;
            this.btnCreateProductCategories.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateProductCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateProductCategories.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCreateProductCategories.ForeColor = System.Drawing.Color.White;
            this.btnCreateProductCategories.Image = global::ElectricStoreMetro.Properties.Resources.categories;
            this.btnCreateProductCategories.ImagePosition = 20;
            this.btnCreateProductCategories.ImageZoom = 40;
            this.btnCreateProductCategories.LabelPosition = 41;
            this.btnCreateProductCategories.LabelText = "Categories";
            this.btnCreateProductCategories.Location = new System.Drawing.Point(7, 6);
            this.btnCreateProductCategories.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateProductCategories.Name = "btnCreateProductCategories";
            this.btnCreateProductCategories.Size = new System.Drawing.Size(139, 118);
            this.btnCreateProductCategories.TabIndex = 0;
            this.btnCreateProductCategories.Click += new System.EventHandler(this.btnCreateProductCategories_Click);
            // 
            // panelGuides
            // 
            this.panelGuides.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelGuides.Controls.Add(this.bunifuCustomLabel1);
            this.panelGuides.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelGuides.Location = new System.Drawing.Point(16, 270);
            this.panelGuides.Margin = new System.Windows.Forms.Padding(4);
            this.panelGuides.Name = "panelGuides";
            this.panelGuides.Size = new System.Drawing.Size(464, 277);
            this.panelGuides.TabIndex = 8;
            this.metroToolTip1.SetToolTip(this.panelGuides, "usefull informaton for first use..");
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Image = global::ElectricStoreMetro.Properties.Resources.guide;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(7, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(349, 240);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = resources.GetString("bunifuCustomLabel1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Items:";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frUpdateOrder
            // 
            this.AcceptButton = this.btnFetchOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1140, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelGuides);
            this.Controls.Add(this.panelQucikLinks);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.brnProcess);
            this.Controls.Add(this.btnFetchOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frUpdateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Payment of Order";
            this.Load += new System.EventHandler(this.frUpdateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelQucikLinks.ResumeLayout(false);
            this.panelGuides.ResumeLayout(false);
            this.panelGuides.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtOrderNo;
        private ns1.BunifuCustomDataGrid dgv;
        private System.Windows.Forms.Panel panel1;
        public MetroFramework.Controls.MetroTextBox txtPaymentDue;
        public MetroFramework.Controls.MetroTextBox txtTotalPayment;
        public MetroFramework.Controls.MetroTextBox txtGrandTotal;
        public MetroFramework.Controls.MetroTextBox txtDiscount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblTotalToPay;
        private MetroFramework.Controls.MetroButton btnFetchOrder;
        private MetroFramework.Controls.MetroButton brnProcess;
        private MetroFramework.Controls.MetroButton btnClose;
        private System.Windows.Forms.Panel panelQucikLinks;
        private System.Windows.Forms.Panel panelGuides;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuTileButton btnReturnTransaction;
        private ns1.BunifuTileButton btnCreateNewSale;
        private ns1.BunifuTileButton btnCreateUserAccount;
        private ns1.BunifuTileButton btnCreateNewProduct;
        private ns1.BunifuTileButton btnCreateProductCategories;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}
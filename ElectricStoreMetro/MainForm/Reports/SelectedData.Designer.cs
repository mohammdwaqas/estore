namespace ElectricStoreMetro.MainForm.Reports
{
    partial class SelectedData
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
            this.dgv = new ns1.BunifuCustomDataGrid();
            this.btnPrintStock = new MetroFramework.Controls.MetroButton();
            this.btnPrintSales = new MetroFramework.Controls.MetroButton();
            this.txtTotalAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtPaymentDue = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxSale = new System.Windows.Forms.GroupBox();
            this.gboxStock = new System.Windows.Forms.GroupBox();
            this.txtStockAmount = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gboxSale.SuspendLayout();
            this.gboxStock.SuspendLayout();
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
            this.dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgv.HeaderBgColor = System.Drawing.Color.White;
            this.dgv.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv.Location = new System.Drawing.Point(23, 63);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.Size = new System.Drawing.Size(695, 404);
            this.dgv.TabIndex = 0;
            // 
            // btnPrintStock
            // 
            this.btnPrintStock.Location = new System.Drawing.Point(283, 34);
            this.btnPrintStock.Name = "btnPrintStock";
            this.btnPrintStock.Size = new System.Drawing.Size(75, 23);
            this.btnPrintStock.TabIndex = 2;
            this.btnPrintStock.Text = "Print (Stock)";
            this.btnPrintStock.UseSelectable = true;
            this.btnPrintStock.Visible = false;
            this.btnPrintStock.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnPrintSales
            // 
            this.btnPrintSales.Location = new System.Drawing.Point(364, 34);
            this.btnPrintSales.Name = "btnPrintSales";
            this.btnPrintSales.Size = new System.Drawing.Size(75, 23);
            this.btnPrintSales.TabIndex = 3;
            this.btnPrintSales.Text = "Print(Sales)";
            this.btnPrintSales.UseSelectable = true;
            this.btnPrintSales.Visible = false;
            this.btnPrintSales.Click += new System.EventHandler(this.btnPrintSales_Click);
            // 
            // txtTotalAmount
            // 
            // 
            // 
            // 
            this.txtTotalAmount.CustomButton.Image = null;
            this.txtTotalAmount.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtTotalAmount.CustomButton.Name = "";
            this.txtTotalAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalAmount.CustomButton.TabIndex = 1;
            this.txtTotalAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalAmount.CustomButton.UseSelectable = true;
            this.txtTotalAmount.CustomButton.Visible = false;
            this.txtTotalAmount.Lines = new string[0];
            this.txtTotalAmount.Location = new System.Drawing.Point(56, 27);
            this.txtTotalAmount.MaxLength = 32767;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.PromptText = "Total Amount";
            this.txtTotalAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.SelectionLength = 0;
            this.txtTotalAmount.SelectionStart = 0;
            this.txtTotalAmount.ShortcutsEnabled = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(143, 23);
            this.txtTotalAmount.TabIndex = 4;
            this.txtTotalAmount.UseSelectable = true;
            this.txtTotalAmount.WaterMark = "Total Amount";
            this.txtTotalAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPaymentDue
            // 
            // 
            // 
            // 
            this.txtPaymentDue.CustomButton.Image = null;
            this.txtPaymentDue.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtPaymentDue.CustomButton.Name = "";
            this.txtPaymentDue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPaymentDue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentDue.CustomButton.TabIndex = 1;
            this.txtPaymentDue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentDue.CustomButton.UseSelectable = true;
            this.txtPaymentDue.CustomButton.Visible = false;
            this.txtPaymentDue.Lines = new string[0];
            this.txtPaymentDue.Location = new System.Drawing.Point(206, 27);
            this.txtPaymentDue.MaxLength = 32767;
            this.txtPaymentDue.Name = "txtPaymentDue";
            this.txtPaymentDue.PasswordChar = '\0';
            this.txtPaymentDue.PromptText = "Payment Due";
            this.txtPaymentDue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentDue.SelectedText = "";
            this.txtPaymentDue.SelectionLength = 0;
            this.txtPaymentDue.SelectionStart = 0;
            this.txtPaymentDue.ShortcutsEnabled = true;
            this.txtPaymentDue.Size = new System.Drawing.Size(148, 23);
            this.txtPaymentDue.TabIndex = 5;
            this.txtPaymentDue.UseSelectable = true;
            this.txtPaymentDue.WaterMark = "Payment Due";
            this.txtPaymentDue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentDue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Payment Due:";
            // 
            // gboxSale
            // 
            this.gboxSale.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gboxSale.Controls.Add(this.label2);
            this.gboxSale.Controls.Add(this.label1);
            this.gboxSale.Controls.Add(this.txtPaymentDue);
            this.gboxSale.Controls.Add(this.txtTotalAmount);
            this.gboxSale.Location = new System.Drawing.Point(34, 473);
            this.gboxSale.Name = "gboxSale";
            this.gboxSale.Size = new System.Drawing.Size(405, 63);
            this.gboxSale.TabIndex = 8;
            this.gboxSale.TabStop = false;
            this.gboxSale.Text = "Sale Report";
            this.gboxSale.Visible = false;
            // 
            // gboxStock
            // 
            this.gboxStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxStock.Controls.Add(this.label3);
            this.gboxStock.Controls.Add(this.txtStockAmount);
            this.gboxStock.Location = new System.Drawing.Point(445, 473);
            this.gboxStock.Name = "gboxStock";
            this.gboxStock.Size = new System.Drawing.Size(263, 63);
            this.gboxStock.TabIndex = 9;
            this.gboxStock.TabStop = false;
            this.gboxStock.Text = "Stock Report";
            this.gboxStock.Visible = false;
            // 
            // txtStockAmount
            // 
            // 
            // 
            // 
            this.txtStockAmount.CustomButton.Image = null;
            this.txtStockAmount.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtStockAmount.CustomButton.Name = "";
            this.txtStockAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStockAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStockAmount.CustomButton.TabIndex = 1;
            this.txtStockAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStockAmount.CustomButton.UseSelectable = true;
            this.txtStockAmount.CustomButton.Visible = false;
            this.txtStockAmount.Lines = new string[0];
            this.txtStockAmount.Location = new System.Drawing.Point(61, 34);
            this.txtStockAmount.MaxLength = 32767;
            this.txtStockAmount.Name = "txtStockAmount";
            this.txtStockAmount.PasswordChar = '\0';
            this.txtStockAmount.PromptText = "Total Amount";
            this.txtStockAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStockAmount.SelectedText = "";
            this.txtStockAmount.SelectionLength = 0;
            this.txtStockAmount.SelectionStart = 0;
            this.txtStockAmount.ShortcutsEnabled = true;
            this.txtStockAmount.Size = new System.Drawing.Size(143, 23);
            this.txtStockAmount.TabIndex = 5;
            this.txtStockAmount.UseSelectable = true;
            this.txtStockAmount.WaterMark = "Total Amount";
            this.txtStockAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStockAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock Amount:";
            // 
            // SelectedData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 541);
            this.Controls.Add(this.gboxStock);
            this.Controls.Add(this.gboxSale);
            this.Controls.Add(this.btnPrintSales);
            this.Controls.Add(this.btnPrintStock);
            this.Controls.Add(this.dgv);
            this.Name = "SelectedData";
            this.Text = "Selected Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SelectedData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gboxSale.ResumeLayout(false);
            this.gboxSale.PerformLayout();
            this.gboxStock.ResumeLayout(false);
            this.gboxStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public ns1.BunifuCustomDataGrid dgv;
        private MetroFramework.Controls.MetroTextBox txtTotalAmount;
        private MetroFramework.Controls.MetroTextBox txtPaymentDue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox gboxSale;
        private System.Windows.Forms.Label label3;
        public MetroFramework.Controls.MetroTextBox txtStockAmount;
        public System.Windows.Forms.GroupBox gboxStock;
        public MetroFramework.Controls.MetroButton btnPrintStock;
        public MetroFramework.Controls.MetroButton btnPrintSales;
    }
}
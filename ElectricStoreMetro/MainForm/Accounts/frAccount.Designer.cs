namespace ElectricStoreMetro.MainForm.Accounts
{
    partial class frAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCreateAdd = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCreateCell = new MetroFramework.Controls.MetroTextBox();
            this.tbCreateName = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCreatePass = new MetroFramework.Controls.MetroTextBox();
            this.dgv = new ns1.BunifuCustomDataGrid();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbCreateAdd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbCreateCell);
            this.groupBox1.Controls.Add(this.tbCreateName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbCreatePass);
            this.groupBox1.Location = new System.Drawing.Point(27, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Add:";
            // 
            // tbCreateAdd
            // 
            // 
            // 
            // 
            this.tbCreateAdd.CustomButton.Image = null;
            this.tbCreateAdd.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.tbCreateAdd.CustomButton.Name = "";
            this.tbCreateAdd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCreateAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCreateAdd.CustomButton.TabIndex = 1;
            this.tbCreateAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCreateAdd.CustomButton.UseSelectable = true;
            this.tbCreateAdd.CustomButton.Visible = false;
            this.tbCreateAdd.Lines = new string[0];
            this.tbCreateAdd.Location = new System.Drawing.Point(117, 130);
            this.tbCreateAdd.MaxLength = 32767;
            this.tbCreateAdd.Name = "tbCreateAdd";
            this.tbCreateAdd.PasswordChar = '\0';
           
            this.tbCreateAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCreateAdd.SelectedText = "";
            this.tbCreateAdd.SelectionLength = 0;
            this.tbCreateAdd.SelectionStart = 0;
            this.tbCreateAdd.ShortcutsEnabled = true;
            this.tbCreateAdd.Size = new System.Drawing.Size(482, 23);
            this.tbCreateAdd.TabIndex = 3;
            this.tbCreateAdd.UseSelectable = true;
            this.tbCreateAdd.WaterMark = "Address of user (optional)...";
            this.tbCreateAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCreateAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cell:";
            // 
            // tbCreateCell
            // 
            // 
            // 
            // 
            this.tbCreateCell.CustomButton.Image = null;
            this.tbCreateCell.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.tbCreateCell.CustomButton.Name = "";
            this.tbCreateCell.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCreateCell.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCreateCell.CustomButton.TabIndex = 1;
            this.tbCreateCell.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCreateCell.CustomButton.UseSelectable = true;
            this.tbCreateCell.CustomButton.Visible = false;
            this.tbCreateCell.Lines = new string[0];
            this.tbCreateCell.Location = new System.Drawing.Point(117, 101);
            this.tbCreateCell.MaxLength = 32767;
            this.tbCreateCell.Name = "tbCreateCell";
            this.tbCreateCell.PasswordChar = '\0';
            this.tbCreateCell.PromptText = "cell number (optional) ..";
            this.tbCreateCell.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCreateCell.SelectedText = "";
            this.tbCreateCell.SelectionLength = 0;
            this.tbCreateCell.SelectionStart = 0;
            this.tbCreateCell.ShortcutsEnabled = true;
            this.tbCreateCell.Size = new System.Drawing.Size(482, 23);
            this.tbCreateCell.TabIndex = 2;
            this.tbCreateCell.UseSelectable = true;
            this.tbCreateCell.WaterMark = "cell number (optional) ..";
            this.tbCreateCell.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCreateCell.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbCreateName
            // 
            // 
            // 
            // 
            this.tbCreateName.CustomButton.Image = null;
            this.tbCreateName.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.tbCreateName.CustomButton.Name = "";
            this.tbCreateName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCreateName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCreateName.CustomButton.TabIndex = 1;
            this.tbCreateName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCreateName.CustomButton.UseSelectable = true;
            this.tbCreateName.CustomButton.Visible = false;
            this.tbCreateName.Lines = new string[0];
            this.tbCreateName.Location = new System.Drawing.Point(117, 43);
            this.tbCreateName.MaxLength = 32767;
            this.tbCreateName.Name = "tbCreateName";
            this.tbCreateName.PasswordChar = '\0';
            this.tbCreateName.PromptText = "name of the user..";
            this.tbCreateName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCreateName.SelectedText = "";
            this.tbCreateName.SelectionLength = 0;
            this.tbCreateName.SelectionStart = 0;
            this.tbCreateName.ShortcutsEnabled = true;
            this.tbCreateName.Size = new System.Drawing.Size(482, 23);
            this.tbCreateName.TabIndex = 0;
            this.tbCreateName.UseSelectable = true;
            this.tbCreateName.WaterMark = "name of the user..";
            this.tbCreateName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCreateName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pass:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbCreatePass
            // 
            // 
            // 
            // 
            this.tbCreatePass.CustomButton.Image = null;
            this.tbCreatePass.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.tbCreatePass.CustomButton.Name = "";
            this.tbCreatePass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCreatePass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCreatePass.CustomButton.TabIndex = 1;
            this.tbCreatePass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCreatePass.CustomButton.UseSelectable = true;
            this.tbCreatePass.CustomButton.Visible = false;
            this.tbCreatePass.Lines = new string[0];
            this.tbCreatePass.Location = new System.Drawing.Point(117, 72);
            this.tbCreatePass.MaxLength = 32767;
            this.tbCreatePass.Name = "tbCreatePass";
            this.tbCreatePass.PasswordChar = '\0';
            this.tbCreatePass.PromptText = "secret password..";
            this.tbCreatePass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCreatePass.SelectedText = "";
            this.tbCreatePass.SelectionLength = 0;
            this.tbCreatePass.SelectionStart = 0;
            this.tbCreatePass.ShortcutsEnabled = true;
            this.tbCreatePass.Size = new System.Drawing.Size(482, 23);
            this.tbCreatePass.TabIndex = 1;
            this.tbCreatePass.UseSelectable = true;
            this.tbCreatePass.WaterMark = "secret password..";
            this.tbCreatePass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCreatePass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DoubleBuffered = true;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv.HeaderForeColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(27, 277);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(605, 232);
            this.dgv.TabIndex = 1;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::ElectricStoreMetro.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Location = new System.Drawing.Point(528, 517);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 23);
            this.btnDelete.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::ElectricStoreMetro.Properties.Resources.update;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Location = new System.Drawing.Point(285, 517);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 23);
            this.btnUpdate.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.btnUpdate, "Update");
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::ElectricStoreMetro.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(28, 517);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 23);
            this.btnSave.TabIndex = 0;
            this.metroToolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Previous Accounts:";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frAccount
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 563);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "frAccount";
            this.Text = "Create / Manage System User";
            this.Load += new System.EventHandler(this.frAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ns1.BunifuCustomDataGrid dgv;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox tbCreatePass;
        private MetroFramework.Controls.MetroTextBox tbCreateName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox tbCreateAdd;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox tbCreateCell;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}
namespace ElectricStoreMetro.MainForm.Sale
{
    partial class frCheckOut
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtAmountDue = new MetroFramework.Controls.MetroTextBox();
            this.txtAmountGiven = new MetroFramework.Controls.MetroTextBox();
            this.txtChange = new MetroFramework.Controls.MetroTextBox();
            this.btnProcess = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Amount Due:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Amount Given:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(35, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Change:";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // txtAmountDue
            // 
            // 
            // 
            // 
            this.txtAmountDue.CustomButton.Image = null;
            this.txtAmountDue.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtAmountDue.CustomButton.Name = "";
            this.txtAmountDue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmountDue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmountDue.CustomButton.TabIndex = 1;
            this.txtAmountDue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmountDue.CustomButton.UseSelectable = true;
            this.txtAmountDue.CustomButton.Visible = false;
            this.txtAmountDue.Lines = new string[0];
            this.txtAmountDue.Location = new System.Drawing.Point(187, 64);
            this.txtAmountDue.MaxLength = 32767;
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.PasswordChar = '\0';
            this.txtAmountDue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmountDue.SelectedText = "";
            this.txtAmountDue.SelectionLength = 0;
            this.txtAmountDue.SelectionStart = 0;
            this.txtAmountDue.ShortcutsEnabled = true;
            this.txtAmountDue.Size = new System.Drawing.Size(201, 23);
            this.txtAmountDue.TabIndex = 3;
            this.txtAmountDue.UseSelectable = true;
            this.txtAmountDue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmountDue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAmountGiven
            // 
            // 
            // 
            // 
            this.txtAmountGiven.CustomButton.Image = null;
            this.txtAmountGiven.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtAmountGiven.CustomButton.Name = "";
            this.txtAmountGiven.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmountGiven.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmountGiven.CustomButton.TabIndex = 1;
            this.txtAmountGiven.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmountGiven.CustomButton.UseSelectable = true;
            this.txtAmountGiven.CustomButton.Visible = false;
            this.txtAmountGiven.Lines = new string[0];
            this.txtAmountGiven.Location = new System.Drawing.Point(187, 89);
            this.txtAmountGiven.MaxLength = 32767;
            this.txtAmountGiven.Name = "txtAmountGiven";
            this.txtAmountGiven.PasswordChar = '\0';
            this.txtAmountGiven.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmountGiven.SelectedText = "";
            this.txtAmountGiven.SelectionLength = 0;
            this.txtAmountGiven.SelectionStart = 0;
            this.txtAmountGiven.ShortcutsEnabled = true;
            this.txtAmountGiven.Size = new System.Drawing.Size(201, 23);
            this.txtAmountGiven.TabIndex = 4;
            this.txtAmountGiven.UseSelectable = true;
            this.txtAmountGiven.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmountGiven.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmountGiven.TextChanged += new System.EventHandler(this.txtAmountGiven_TextChanged);
            // 
            // txtChange
            // 
            // 
            // 
            // 
            this.txtChange.CustomButton.Image = null;
            this.txtChange.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtChange.CustomButton.Name = "";
            this.txtChange.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChange.CustomButton.TabIndex = 1;
            this.txtChange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChange.CustomButton.UseSelectable = true;
            this.txtChange.CustomButton.Visible = false;
            this.txtChange.Lines = new string[0];
            this.txtChange.Location = new System.Drawing.Point(187, 114);
            this.txtChange.MaxLength = 32767;
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChange.SelectedText = "";
            this.txtChange.SelectionLength = 0;
            this.txtChange.SelectionStart = 0;
            this.txtChange.ShortcutsEnabled = true;
            this.txtChange.Size = new System.Drawing.Size(201, 23);
            this.txtChange.TabIndex = 5;
            this.txtChange.UseSelectable = true;
            this.txtChange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(313, 158);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process ..";
            this.btnProcess.UseSelectable = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // frCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 204);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtAmountGiven);
            this.Controls.Add(this.txtAmountDue);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frCheckOut";
            this.Text = "Check Out:";
            this.Load += new System.EventHandler(this.frCheckOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnProcess;
        public MetroFramework.Controls.MetroTextBox txtAmountDue;
        public MetroFramework.Controls.MetroTextBox txtAmountGiven;
        public MetroFramework.Controls.MetroTextBox txtChange;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStoreMetro.MainForm.Backup_Restore
{
    public partial class frBackup : MetroFramework.Forms.MetroForm
    {
        public frBackup()
        {
            InitializeComponent();
        }

        private void frBackup_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frBAckupRestore f = new frBAckupRestore();
            f.Show();
        }
    }
}

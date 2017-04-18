using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStoreMetro.MainForm.Contact
{
    public partial class frContact : Form
    {
        public frContact()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://mail.google.com/", System.UriKind.Absolute);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser1.Url = new System.Uri("http://www.devstudio.pk/",  System.UriKind.Absolute);
        }
    }
}

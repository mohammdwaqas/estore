using System;
using System.Windows.Forms;
using ElectricStoreMetro.MainForm.Accounts;
using ElectricStoreMetro.MainForm.Return;
using ElectricStoreMetro.MainForm.Sale;
using ElectricStoreMetro.MainForm.Measurement;
using ElectricStoreMetro.MainForm.Product;
using ElectricStoreMetro.MainForm.Settings;

namespace ElectricStoreMetro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frSales());
        }
    }
}

using System;
using System.Windows.Forms;

namespace grocery_store
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("vi-VI");
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = new System.Globalization.CultureInfo("vi-VI");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //API.GenarateBarCode genarateBarCode = new API.GenarateBarCode();
            //genarateBarCode.Genarate();
            //API.PaymentQR paymentQR = new API.PaymentQR();
            //paymentQR.Genarate();
            Application.Run(new GUI.Main());
        }
    }

}

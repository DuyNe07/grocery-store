using grocery_store.API;
using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            //API.GenarateBarCode genarateBarCode = new API.GenarateBarCode();
            //genarateBarCode.Genarate();
            //API.PaymentQR paymentQR = new API.PaymentQR();
            //paymentQR.Genarate();
            updatePayment();
            Application.Run(new GUI.Main());
        }

        static async void updatePayment()
        {
            using(GroceryStoreContext db = new GroceryStoreContext())
            {
                Payment payment = await db.Payment.FindAsync(1);
                if(payment.Qr == null)
                {
                    PaymentQR paymentQR = new PaymentQR();
                    paymentQR.Genarate();
                }
                else
                {
                    return;
                }
            }
        }

    }

}

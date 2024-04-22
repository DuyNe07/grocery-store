﻿using grocery_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //API.GenarateBarCode genarateBarCode = new API.GenarateBarCode();
            //genarateBarCode.Genarate();
            Application.Run(new GUI.Main());
        }
    }
    
}

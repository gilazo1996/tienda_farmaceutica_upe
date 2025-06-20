﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var connStr = ConfigurationManager.ConnectionStrings["FarmaceuticaDB"]?.ConnectionString;
            Console.WriteLine("Cadena de conexión: " + (connStr ?? "NULL"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formInicio());
        }
    }
}
    


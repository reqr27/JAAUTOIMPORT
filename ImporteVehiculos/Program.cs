﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImporteVehiculos.Formularios;

namespace ImporteVehiculos
{
    public static class Program
    {
        public static bool VerDetalles = false;
        public static double GprecioTotalRD;
        public static double GprecioTotalUSD;
        public static int GidVehiculo;
        //static public string Gtitulo = "ROSA BISONO AUTO";
        static public string Gtitulo = "JUAN ALMONTE AUTO IMPORT";
        static public string Gventana;
        public static int GidUsuario;
        public static string Gusuario;
        public static DateTime Gdesde;
        public static DateTime Ghasta;
        public static string Greporte;
        public static int GidPropietario;
        public static string Gpropietario;
        public static int GidVehiculoRpt;
        public static string GnombreVehiculo;
        public static int GnumeroRecibo;
        public static string GtipoRecibo;
       

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

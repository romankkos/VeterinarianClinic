using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicApp.Forms;
using ClinicApp;
using ClinicApp.Models;
using ClinicApp.DbContexts;

namespace ClinicApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new vet_clinicContext().Database.EnsureCreated();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenusForm());
        }
    }
}

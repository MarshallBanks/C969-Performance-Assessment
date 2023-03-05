using C969_Performance_Assessment.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace C969_Performance_Assessment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CurrentUser.GetInstance();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CultureInfo currentCulture = CultureInfo.CurrentUICulture;
            DBConnection.startConnection();
            Application.Run(new LoginForm(currentCulture));
            DBConnection.closeConnection();
        }
    }
}

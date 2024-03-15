using OOO_Technical_Service.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Technical_Service
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new AuthorizationForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MenuForm());
            }
        }
    }
}

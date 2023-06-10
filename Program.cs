using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.View;

namespace Biblioteca
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
            Application.Run(new PrincipalForm());
        }
    }
}


//var login = new EditorasForm();
//Application.Run(login);
//if (login.DialogResult == DialogResult.OK)
//{
//    Application.Run(new principalForm());
//}
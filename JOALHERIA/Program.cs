using Aux_Joalheria;
using JOALHERIADAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOALHERIA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI.frmLogin());
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // Log the exception, display it, etc
            NetworkLog.Insert(e.Exception, "Program.cs");
            frmErro.Erro_Inesperado(e.Exception);
        }
    }
}

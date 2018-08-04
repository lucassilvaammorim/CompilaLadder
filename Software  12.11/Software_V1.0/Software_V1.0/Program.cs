using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Software_V1._0
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
            inicio i = new inicio();
            i.Show();
            
            Application.DoEvents();
            Thread.Sleep(5000);
            //Carregar configurações do usuário
            i.Dispose();

            Application.Run(new Form1());

            
        }
    }
}

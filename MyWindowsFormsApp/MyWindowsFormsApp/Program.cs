using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Personnes_Form());
            

            /*
             * //Form form4 : calculatrice
            try
            {
                Application.Run(new Form4());
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }
    }
}

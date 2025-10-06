using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Formularios;

namespace Vistas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Usuario.HayUsuariosRegistrados())
            {
                Application.Run(new frmLogin());
            }
            else
            {
                Application.Run(new frmPrimerUsuario());
            }

            //Application.Run(new frmOlvideMiClave());
        }
    }
}

using System;
using System.Windows.Forms;
using JSistemas.UIL.Hortalica.Cadastro;

namespace JSistemas.UIL.Hortalica
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
            Application.Run(new CadastroProduto());
        }
    }
}

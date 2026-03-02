using System;
using System.Windows.Forms;

namespace ClienteApp.UI
{
    /// <summary>
    /// Classe responsável por inicializar a aplicação.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal da aplicação.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new Forms.MainForm());
        }
    }
}
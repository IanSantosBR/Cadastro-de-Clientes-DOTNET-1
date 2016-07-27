// GEC5 AV1 Laboratório de Programação (.NET I) - Ian Santos / Data da última edição: 27/07/2016

using System;
using System.Windows.Forms;

namespace Cadastro_de_Clientes
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CadastroClientes());
        }
    }
}

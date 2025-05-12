using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using achados_e_perdidos_senac.CadastroItens;
using achados_e_perdidos_senac.Screen.Splash;

namespace achados_e_perdidos_senac
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSelecionarItem());
        }
    }
}

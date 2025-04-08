using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace achados_e_perdidos_senac.Services
{
    public static class CloseEntireApplication
    {

        public static void CloseApplication(object sender, FormClosingEventArgs e) { 
        
                Application.ExitThread();
        
        }

    }
}

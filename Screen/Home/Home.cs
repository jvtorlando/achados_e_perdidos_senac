using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using achados_e_perdidos_senac.Services;

namespace achados_e_perdidos_senac
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.FormClosing += CloseEntireApplication.CloseApplication;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

       
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace achados_e_perdidos_senac.Screen.Splash
{
    public partial class SplashScreen: Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelLoading.Width += 11;
            if (panelLoading.Width >= 800)
            {
                timer1.Stop();
                login loginScreen = new login();
                loginScreen.Show();
                this.Hide();
            }
        }
    }
}

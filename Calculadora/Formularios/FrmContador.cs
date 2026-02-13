using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class FrmContador : Form
    {
        int contador = 0;
        public FrmContador()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            tkbVelociodad.Enabled = true;
            tmrContador.Interval = tkbVelociodad.Value * 200;
            tmrContador.Enabled = true;
            tmrContador.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrContador.Enabled = false;
            tkbVelociodad.Enabled = false;
        }

        private void tkbVelociodad_Scroll(object sender, EventArgs e)
        {
            tmrContador.Interval = tkbVelociodad.Value * 200;
        }

        private void tmrContador_Tick(object sender, EventArgs e)
        {
            contador++;
            lblCuenta.Text = contador.ToString();
        }
    }
}

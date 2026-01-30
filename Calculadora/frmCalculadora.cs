using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, resultado = 0;

            try
            {
                a = Convert.ToInt32(txtVariableA.Text);
                b = int.Parse(txtVariableB.Text);

                resultado = a + b;

                MessageBox.Show("El resultado es: " + resultado.ToString(),
                    "Systema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la convercion de datos",
                    "Systema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btmReset_Click(object sender, EventArgs e)
        {
           Reset();
        }

        private void Reset() 
        {
            txtVariableA.Text = "";
            txtVariableB.Clear();
            txtVariableA.Focus();
        }
    }
}

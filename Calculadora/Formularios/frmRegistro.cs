using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Calculadora.Formularios
{
    public partial class frmRegistro : Form
    {
        List<Persona> persona = new List<Persona>();
        public frmRegistro()
        {
            InitializeComponent();
        }



        private void tabRegistrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabRegistrar.SelectedIndex == 1)
            {

                dgvPersonas.DataSource = null;
                dgvPersonas.DataSource = persona;
                verificarRegistros();
            }
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.Add(new Persona()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Fecha = dtpFecha.Value
            }
           );
            MessageBox.Show("Registro agregado con exito");
        }

        private void verificarRegistros()
        {
            if (persona.Count == 0)
            {
                btnEeliminar.Enabled = false;
            }
            else
                btnEeliminar.Enabled = true;
        }

        private void btnEeliminar_Click(object sender, EventArgs e)
        {
            persona.RemoveAt(dgvPersonas.CurrentRow.Index);
            dgvPersonas.DataSource = null;//limpiar el datagrid
            dgvPersonas.DataSource= persona;//Vuelve a llenar el datagrid
            verificarRegistros();//Verificar si habilito el boton
        }
    }
}

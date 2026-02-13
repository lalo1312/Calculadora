using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calculadora.Formularios
{
    public partial class frmEditor : Form
    {
        Boolean saved = false;
        string path = "";

        string texto = "";
        public frmEditor()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofpEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofpEditor.FileName))
                {
                    rtbEditor.Text = File.ReadAllText(ofpEditor.FileName);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                Guardar();
                saved = true;
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                path = sfdEditor.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            path = "";
            saved = false;
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            texto = rtbEditor.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            tssStatus.Text = palabras.Length.ToString() + " Palabras";

        }

        private void tssStatus_Click(object sender, EventArgs e)
        {
            string[] parrafos = texto.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r', }, StringSplitOptions.RemoveEmptyEntries);

            MessageBox.Show("Estadisticas:\n\nPalabras: "
                + palabras.Length.ToString()
                + "\nLetras: " + texto.Length.ToString()
                + "\nParrafos: "
                + parrafos.Length.ToString(), "Contador de Palabras");
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ftdEditor.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.Font = ftdEditor.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cldEditor.ShowDialog() == DialogResult.OK) 
            { 
                rtbEditor.ForeColor = cldEditor.Color;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;//para usar el visualbox
using System.Media;
using CSCore.SoundOut;


using System.Media;

namespace Calculadora.Formularios
{
    public partial class frmTemporizadores : Form
    {
        string alarma1 = "";
        public frmTemporizadores()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();//DateTime.Now (saca la hora del Systema)
            if (lblHora.Text == alarma1) 
            { 
                SoundPlayer player = new SoundPlayer("C:\\Users\\chido\\source\\repos\\Calculadora\\Calculadora\\sonidos\\dragon-studio-rooster-crowing-364473.mp3");
                player.Play();
            }
        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma1 = Interaction.InputBox("Ingrese la Hora: ", "Sistema", "00.00.00 x.x");
        }
    }
}

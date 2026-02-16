using Calculadora.Formularios;
using Microsoft.Win32;

namespace Calculadora
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculadoraSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadora calculadoraSimple = new frmCalculadora();
            calculadoraSimple.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja burbuja = new frmBurbuja();
            burbuja.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro registrosForm = new frmRegistro();
            registrosForm.Show();
        }

        private void relojToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTemporizadores reloj = new frmTemporizadores();
            reloj.Show();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor editor = new frmEditor();
            editor.Show();
        }

        private void contadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContador contador = new FrmContador();
            contador.Show();
        }

        private void xMLDirectorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXMLAccess xmlAcceso= new frmXMLAccess();
            xmlAcceso.Show();
        }
    }
}

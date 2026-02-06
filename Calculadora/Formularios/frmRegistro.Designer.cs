namespace Calculadora.Formularios
{
    partial class frmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabRegistrar = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            Nombre = new Label();
            tabPage2 = new TabPage();
            dgvPersonas = new DataGridView();
            tabRegistrar.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // tabRegistrar
            // 
            tabRegistrar.Controls.Add(tabPage1);
            tabRegistrar.Controls.Add(tabPage2);
            tabRegistrar.Location = new Point(3, 3);
            tabRegistrar.Name = "tabRegistrar";
            tabRegistrar.SelectedIndex = 0;
            tabRegistrar.Size = new Size(794, 446);
            tabRegistrar.TabIndex = 0;
            tabRegistrar.SelectedIndexChanged += tabRegistrar_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dtpFecha);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(Nombre);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(786, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(221, 73);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(35, 336);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 284);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 5;
            label2.Text = "Fecha de nacimiento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 175);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(34, 211);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(28, 43);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkGray;
            tabPage2.Controls.Add(dgvPersonas);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(0, 0);
            dgvPersonas.Margin = new Padding(3, 4, 3, 4);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.Size = new Size(786, 413);
            dgvPersonas.TabIndex = 1;
            dgvPersonas.CellContentClick += dgvPersonas_CellContentClick;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabRegistrar);
            Name = "frmRegistro";
            Text = "Registro Alumnos";
            tabRegistrar.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabRegistrar;
        private TabPage tabPage1;
        private Button btm;
        private Label label1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label Nombre;
        private DateTimePicker dtpFecha;
        private Label label2;
        private TabPage tabPage2;
        private DataGridView dgvPersonas;
        private Button button1;
    }
}
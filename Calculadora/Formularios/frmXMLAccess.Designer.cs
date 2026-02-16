namespace Calculadora.Formularios
{
    partial class frmXMLAccess
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
            dgvPersonas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            spcXML = new SplitContainer();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spcXML).BeginInit();
            spcXML.Panel1.SuspendLayout();
            spcXML.Panel2.SuspendLayout();
            spcXML.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Telefono });
            dgvPersonas.Dock = DockStyle.Fill;
            dgvPersonas.Location = new Point(0, 0);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.Size = new Size(800, 347);
            dgvPersonas.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 50;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 550;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 150;
            // 
            // spcXML
            // 
            spcXML.Dock = DockStyle.Fill;
            spcXML.Location = new Point(0, 0);
            spcXML.Name = "spcXML";
            spcXML.Orientation = Orientation.Horizontal;
            // 
            // spcXML.Panel1
            // 
            spcXML.Panel1.Controls.Add(dgvPersonas);
            // 
            // spcXML.Panel2
            // 
            spcXML.Panel2.Controls.Add(btnGuardar);
            spcXML.Size = new Size(800, 450);
            spcXML.SplitterDistance = 347;
            spcXML.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(336, 44);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmXMLAccess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(spcXML);
            Name = "frmXMLAccess";
            Text = "XML";
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            spcXML.Panel1.ResumeLayout(false);
            spcXML.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcXML).EndInit();
            spcXML.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPersonas;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private SplitContainer spcXML;
        private Button btnGuardar;
    }
}
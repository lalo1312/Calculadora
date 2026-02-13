namespace Calculadora.Formularios
{
    partial class FrmContador
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
            components = new System.ComponentModel.Container();
            lblCuenta = new Label();
            btnInicio = new Button();
            btnDetener = new Button();
            tkbVelociodad = new TrackBar();
            tmrContador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tkbVelociodad).BeginInit();
            SuspendLayout();
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Arial Narrow", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuenta.Location = new Point(137, 36);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(45, 55);
            lblCuenta.TabIndex = 0;
            lblCuenta.Text = "0";
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(27, 180);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(94, 29);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(219, 180);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(94, 29);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // tkbVelociodad
            // 
            tkbVelociodad.Enabled = false;
            tkbVelociodad.Location = new Point(12, 118);
            tkbVelociodad.Maximum = 5;
            tkbVelociodad.Minimum = 1;
            tkbVelociodad.Name = "tkbVelociodad";
            tkbVelociodad.Size = new Size(301, 56);
            tkbVelociodad.TabIndex = 3;
            tkbVelociodad.Value = 1;
            tkbVelociodad.Scroll += tkbVelociodad_Scroll;
            // 
            // tmrContador
            // 
            tmrContador.Interval = 1;
            tmrContador.Tick += tmrContador_Tick;
            // 
            // FrmContador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 256);
            Controls.Add(tkbVelociodad);
            Controls.Add(btnDetener);
            Controls.Add(btnInicio);
            Controls.Add(lblCuenta);
            Name = "FrmContador";
            Text = "Contador";
            ((System.ComponentModel.ISupportInitialize)tkbVelociodad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuenta;
        private Button btnInicio;
        private Button btnDetener;
        private TrackBar tkbVelociodad;
        private System.Windows.Forms.Timer tmrContador;
    }
}
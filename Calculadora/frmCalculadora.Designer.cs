namespace Calculadora
{
    partial class frmCalculadora
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
            label1 = new Label();
            label2 = new Label();
            txtVariableA = new TextBox();
            txtVariableB = new TextBox();
            btnCalcular = new Button();
            btmReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Variable A";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 132);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Variable B";
            // 
            // txtVariableA
            // 
            txtVariableA.Location = new Point(38, 66);
            txtVariableA.Name = "txtVariableA";
            txtVariableA.Size = new Size(125, 27);
            txtVariableA.TabIndex = 2;
            // 
            // txtVariableB
            // 
            txtVariableB.Location = new Point(31, 171);
            txtVariableB.Name = "txtVariableB";
            txtVariableB.Size = new Size(125, 27);
            txtVariableB.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(207, 123);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btmReset
            // 
            btmReset.Location = new Point(207, 79);
            btmReset.Name = "btmReset";
            btmReset.Size = new Size(94, 29);
            btmReset.TabIndex = 5;
            btmReset.Text = "Reset";
            btmReset.UseVisualStyleBackColor = true;
            btmReset.Click += btmReset_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 244);
            Controls.Add(btmReset);
            Controls.Add(btnCalcular);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCalculadora";
            Text = "Calculadora";
            Load += frmCalculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtVariableA;
        private TextBox txtVariableB;
        private Button btnCalcular;
        private Button btmReset;
    }
}
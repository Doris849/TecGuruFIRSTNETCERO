
namespace TecGurusBasicUAMPL.Tarea1
{
    partial class CalculadoraFRM
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.TboxNumero1 = new System.Windows.Forms.TextBox();
            this.TboxNumero2 = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero1.Location = new System.Drawing.Point(71, 49);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(138, 34);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Numero 1";
            this.lblNumero1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero2.Location = new System.Drawing.Point(71, 119);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(138, 34);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Numero 2";
            // 
            // TboxNumero1
            // 
            this.TboxNumero1.Location = new System.Drawing.Point(237, 58);
            this.TboxNumero1.Name = "TboxNumero1";
            this.TboxNumero1.Size = new System.Drawing.Size(100, 26);
            this.TboxNumero1.TabIndex = 2;
            // 
            // TboxNumero2
            // 
            this.TboxNumero2.Location = new System.Drawing.Point(237, 133);
            this.TboxNumero2.Name = "TboxNumero2";
            this.TboxNumero2.Size = new System.Drawing.Size(100, 26);
            this.TboxNumero2.TabIndex = 3;
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSuma.Location = new System.Drawing.Point(298, 311);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(188, 97);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "SUMA";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblResultado.Location = new System.Drawing.Point(149, 236);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(113, 34);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "label1";
            this.lblResultado.Visible = false;
            // 
            // CalculadoraFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.TboxNumero2);
            this.Controls.Add(this.TboxNumero1);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Name = "CalculadoraFRM";
            this.Text = "CalculadoraFRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox TboxNumero1;
        private System.Windows.Forms.TextBox TboxNumero2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label lblResultado;
    }
}
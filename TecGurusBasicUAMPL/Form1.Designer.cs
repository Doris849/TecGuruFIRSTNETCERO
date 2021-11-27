
namespace TecGurusBasicUAMPL
{
    partial class Form1
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
            this.btnExample = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExample
            // 
            this.btnExample.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExample.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExample.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExample.Location = new System.Drawing.Point(259, 261);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(142, 67);
            this.btnExample.TabIndex = 0;
            this.btnExample.Text = "Saludo";
            this.btnExample.UseVisualStyleBackColor = false;
            this.btnExample.Click += new System.EventHandler(this.btnExample_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(255, 153);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(51, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "label1";
            this.lblWelcome.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 406);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExample);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExample;
        private System.Windows.Forms.Label lblWelcome;
    }
}


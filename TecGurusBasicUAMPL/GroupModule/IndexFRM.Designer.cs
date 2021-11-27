
namespace TecGurusBasicUAMPL.GroupModule
{
    partial class IndexFRM
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
            this.label1 = new System.Windows.Forms.Label();
            this.GRVListGroups = new System.Windows.Forms.DataGridView();
            this.btnGet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GRVListGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupos";
            // 
            // GRVListGroups
            // 
            this.GRVListGroups.BackgroundColor = System.Drawing.Color.Aqua;
            this.GRVListGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRVListGroups.Location = new System.Drawing.Point(45, 92);
            this.GRVListGroups.Name = "GRVListGroups";
            this.GRVListGroups.RowHeadersWidth = 62;
            this.GRVListGroups.RowTemplate.Height = 28;
            this.GRVListGroups.Size = new System.Drawing.Size(775, 269);
            this.GRVListGroups.TabIndex = 1;
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(45, 406);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(129, 61);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Consultar";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // IndexFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(863, 531);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.GRVListGroups);
            this.Controls.Add(this.label1);
            this.Name = "IndexFRM";
            this.Text = "IndexFRM";
            ((System.ComponentModel.ISupportInitialize)(this.GRVListGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GRVListGroups;
        private System.Windows.Forms.Button btnGet;
    }
}
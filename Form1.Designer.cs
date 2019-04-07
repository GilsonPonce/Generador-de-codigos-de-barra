namespace Generardor_de_Codigo_de_barras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btngenerate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtenter = new System.Windows.Forms.TextBox();
            this.pnlview = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Text for the bar code";
            // 
            // btngenerate
            // 
            this.btngenerate.Location = new System.Drawing.Point(43, 245);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(351, 23);
            this.btngenerate.TabIndex = 1;
            this.btngenerate.Text = "Generate";
            this.btngenerate.UseVisualStyleBackColor = true;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Location = new System.Drawing.Point(423, 219);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(226, 49);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtenter
            // 
            this.txtenter.Location = new System.Drawing.Point(43, 219);
            this.txtenter.MaxLength = 57;
            this.txtenter.Name = "txtenter";
            this.txtenter.Size = new System.Drawing.Size(351, 20);
            this.txtenter.TabIndex = 3;
            // 
            // pnlview
            // 
            this.pnlview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlview.Location = new System.Drawing.Point(43, 13);
            this.pnlview.Name = "pnlview";
            this.pnlview.Size = new System.Drawing.Size(606, 179);
            this.pnlview.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 290);
            this.Controls.Add(this.pnlview);
            this.Controls.Add(this.txtenter);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(707, 329);
            this.MinimumSize = new System.Drawing.Size(707, 329);
            this.Name = "Form1";
            this.Text = "Bar Code Generator";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtenter;
        private System.Windows.Forms.Panel pnlview;
    }
}


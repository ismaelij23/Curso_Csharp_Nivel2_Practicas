namespace proyectoDesafioWinForm
{
    partial class formPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesafio = new System.Windows.Forms.TextBox();
            this.txtDesafio1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(376, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "BOTON";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(252, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "LABEL";
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // txtDesafio
            // 
            this.txtDesafio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesafio.Location = new System.Drawing.Point(376, 292);
            this.txtDesafio.MaxLength = 100;
            this.txtDesafio.Name = "txtDesafio";
            this.txtDesafio.Size = new System.Drawing.Size(194, 20);
            this.txtDesafio.TabIndex = 2;
            this.txtDesafio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesafio_KeyPress);
            // 
            // txtDesafio1
            // 
            this.txtDesafio1.Location = new System.Drawing.Point(183, 337);
            this.txtDesafio1.Multiline = true;
            this.txtDesafio1.Name = "txtDesafio1";
            this.txtDesafio1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesafio1.Size = new System.Drawing.Size(387, 65);
            this.txtDesafio1.TabIndex = 3;
            this.txtDesafio1.Leave += new System.EventHandler(this.txtDesafio1_Leave);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDesafio1);
            this.Controls.Add(this.txtDesafio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesafio;
        private System.Windows.Forms.TextBox txtDesafio1;
    }
}


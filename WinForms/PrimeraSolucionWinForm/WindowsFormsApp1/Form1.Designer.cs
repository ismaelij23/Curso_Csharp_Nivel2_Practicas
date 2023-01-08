namespace WindowsFormsApp1
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFechaNto = new System.Windows.Forms.Label();
            this.dtpFechaNto = new System.Windows.Forms.DateTimePicker();
            this.chBoxChocolate = new System.Windows.Forms.CheckBox();
            this.radBtnHombre = new System.Windows.Forms.RadioButton();
            this.radBtnMujer = new System.Windows.Forms.RadioButton();
            this.radBtnNoBin = new System.Windows.Forms.RadioButton();
            this.grBoxGenero = new System.Windows.Forms.GroupBox();
            this.cboBoxColorFav = new System.Windows.Forms.ComboBox();
            this.labelColorFav = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgrPersona = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.btnLista = new System.Windows.Forms.Button();
            this.grBoxGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(239, 78);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(292, 71);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(190, 20);
            this.textName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Perfil Persona";
            // 
            // labelFechaNto
            // 
            this.labelFechaNto.AutoSize = true;
            this.labelFechaNto.Location = new System.Drawing.Point(175, 122);
            this.labelFechaNto.Name = "labelFechaNto";
            this.labelFechaNto.Size = new System.Drawing.Size(111, 13);
            this.labelFechaNto.TabIndex = 6;
            this.labelFechaNto.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNto
            // 
            this.dtpFechaNto.Location = new System.Drawing.Point(292, 116);
            this.dtpFechaNto.Name = "dtpFechaNto";
            this.dtpFechaNto.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNto.TabIndex = 7;
            // 
            // chBoxChocolate
            // 
            this.chBoxChocolate.AutoSize = true;
            this.chBoxChocolate.Location = new System.Drawing.Point(292, 154);
            this.chBoxChocolate.Name = "chBoxChocolate";
            this.chBoxChocolate.Size = new System.Drawing.Size(135, 17);
            this.chBoxChocolate.TabIndex = 8;
            this.chBoxChocolate.Text = "Te gusta el chocolate?";
            this.chBoxChocolate.UseVisualStyleBackColor = true;
            // 
            // radBtnHombre
            // 
            this.radBtnHombre.AutoSize = true;
            this.radBtnHombre.Checked = true;
            this.radBtnHombre.Location = new System.Drawing.Point(23, 44);
            this.radBtnHombre.Name = "radBtnHombre";
            this.radBtnHombre.Size = new System.Drawing.Size(62, 17);
            this.radBtnHombre.TabIndex = 9;
            this.radBtnHombre.TabStop = true;
            this.radBtnHombre.Text = "Hombre";
            this.radBtnHombre.UseVisualStyleBackColor = true;
            // 
            // radBtnMujer
            // 
            this.radBtnMujer.AutoSize = true;
            this.radBtnMujer.Location = new System.Drawing.Point(154, 44);
            this.radBtnMujer.Name = "radBtnMujer";
            this.radBtnMujer.Size = new System.Drawing.Size(51, 17);
            this.radBtnMujer.TabIndex = 10;
            this.radBtnMujer.Text = "Mujer";
            this.radBtnMujer.UseVisualStyleBackColor = true;
            // 
            // radBtnNoBin
            // 
            this.radBtnNoBin.AutoSize = true;
            this.radBtnNoBin.Location = new System.Drawing.Point(286, 44);
            this.radBtnNoBin.Name = "radBtnNoBin";
            this.radBtnNoBin.Size = new System.Drawing.Size(73, 17);
            this.radBtnNoBin.TabIndex = 11;
            this.radBtnNoBin.Text = "No binario";
            this.radBtnNoBin.UseVisualStyleBackColor = true;
            // 
            // grBoxGenero
            // 
            this.grBoxGenero.Controls.Add(this.radBtnMujer);
            this.grBoxGenero.Controls.Add(this.radBtnNoBin);
            this.grBoxGenero.Controls.Add(this.label1);
            this.grBoxGenero.Controls.Add(this.radBtnHombre);
            this.grBoxGenero.Location = new System.Drawing.Point(178, 177);
            this.grBoxGenero.Name = "grBoxGenero";
            this.grBoxGenero.Size = new System.Drawing.Size(394, 75);
            this.grBoxGenero.TabIndex = 12;
            this.grBoxGenero.TabStop = false;
            this.grBoxGenero.Text = "Género";
            // 
            // cboBoxColorFav
            // 
            this.cboBoxColorFav.FormattingEnabled = true;
            this.cboBoxColorFav.Location = new System.Drawing.Point(292, 269);
            this.cboBoxColorFav.Name = "cboBoxColorFav";
            this.cboBoxColorFav.Size = new System.Drawing.Size(200, 21);
            this.cboBoxColorFav.TabIndex = 13;
            this.cboBoxColorFav.SelectedIndexChanged += new System.EventHandler(this.cboBoxColorFav_SelectedIndexChanged);
            // 
            // labelColorFav
            // 
            this.labelColorFav.AutoSize = true;
            this.labelColorFav.Location = new System.Drawing.Point(208, 277);
            this.labelColorFav.Name = "labelColorFav";
            this.labelColorFav.Size = new System.Drawing.Size(78, 13);
            this.labelColorFav.TabIndex = 14;
            this.labelColorFav.Text = "Color Favorito: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(292, 309);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Número Favorito:";
            // 
            // btnAgrPersona
            // 
            this.btnAgrPersona.Location = new System.Drawing.Point(332, 350);
            this.btnAgrPersona.Name = "btnAgrPersona";
            this.btnAgrPersona.Size = new System.Drawing.Size(116, 42);
            this.btnAgrPersona.TabIndex = 17;
            this.btnAgrPersona.Text = "Agregar &Persona";
            this.btnAgrPersona.UseVisualStyleBackColor = true;
            this.btnAgrPersona.Click += new System.EventHandler(this.btnAgrPersona_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(178, 413);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(359, 97);
            this.listView.TabIndex = 18;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(178, 517);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 23);
            this.btnLista.TabIndex = 19;
            this.btnLista.Text = "Ver en Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnAgrPersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelColorFav);
            this.Controls.Add(this.cboBoxColorFav);
            this.Controls.Add(this.grBoxGenero);
            this.Controls.Add(this.chBoxChocolate);
            this.Controls.Add(this.dtpFechaNto);
            this.Controls.Add(this.labelFechaNto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grBoxGenero.ResumeLayout(false);
            this.grBoxGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFechaNto;
        private System.Windows.Forms.DateTimePicker dtpFechaNto;
        private System.Windows.Forms.CheckBox chBoxChocolate;
        private System.Windows.Forms.RadioButton radBtnHombre;
        private System.Windows.Forms.RadioButton radBtnMujer;
        private System.Windows.Forms.RadioButton radBtnNoBin;
        private System.Windows.Forms.GroupBox grBoxGenero;
        private System.Windows.Forms.ComboBox cboBoxColorFav;
        private System.Windows.Forms.Label labelColorFav;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgrPersona;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnLista;
    }
}


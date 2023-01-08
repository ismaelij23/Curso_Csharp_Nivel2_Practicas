namespace PracticaWinForm1
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
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.grBoxGenero = new System.Windows.Forms.GroupBox();
            this.rdBtnNoBin = new System.Windows.Forms.RadioButton();
            this.rdBtnMujer = new System.Windows.Forms.RadioButton();
            this.rdBtnHombre = new System.Windows.Forms.RadioButton();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.checkBoxDobleTurno = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.cboBoxPuesto = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grBoxGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEmpleado.Location = new System.Drawing.Point(298, 25);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(243, 33);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Perfil de Empleado";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(142, 134);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 24);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(457, 92);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(84, 24);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(142, 354);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 24);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono: ";
            // 
            // lblSalario
            // 
            this.lblSalario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(159, 314);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(72, 24);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salario:";
            // 
            // grBoxGenero
            // 
            this.grBoxGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grBoxGenero.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grBoxGenero.Controls.Add(this.rdBtnNoBin);
            this.grBoxGenero.Controls.Add(this.rdBtnMujer);
            this.grBoxGenero.Controls.Add(this.rdBtnHombre);
            this.grBoxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxGenero.Location = new System.Drawing.Point(461, 134);
            this.grBoxGenero.Name = "grBoxGenero";
            this.grBoxGenero.Size = new System.Drawing.Size(447, 82);
            this.grBoxGenero.TabIndex = 4;
            this.grBoxGenero.TabStop = false;
            this.grBoxGenero.Text = "Género";
            // 
            // rdBtnNoBin
            // 
            this.rdBtnNoBin.AutoSize = true;
            this.rdBtnNoBin.Location = new System.Drawing.Point(310, 43);
            this.rdBtnNoBin.Name = "rdBtnNoBin";
            this.rdBtnNoBin.Size = new System.Drawing.Size(116, 28);
            this.rdBtnNoBin.TabIndex = 2;
            this.rdBtnNoBin.Text = "No Binario";
            this.rdBtnNoBin.UseVisualStyleBackColor = true;
            // 
            // rdBtnMujer
            // 
            this.rdBtnMujer.AutoSize = true;
            this.rdBtnMujer.Location = new System.Drawing.Point(165, 43);
            this.rdBtnMujer.Name = "rdBtnMujer";
            this.rdBtnMujer.Size = new System.Drawing.Size(76, 28);
            this.rdBtnMujer.TabIndex = 1;
            this.rdBtnMujer.Text = "Mujer";
            this.rdBtnMujer.UseVisualStyleBackColor = true;
            // 
            // rdBtnHombre
            // 
            this.rdBtnHombre.AutoSize = true;
            this.rdBtnHombre.Checked = true;
            this.rdBtnHombre.Location = new System.Drawing.Point(16, 43);
            this.rdBtnHombre.Name = "rdBtnHombre";
            this.rdBtnHombre.Size = new System.Drawing.Size(97, 28);
            this.rdBtnHombre.TabIndex = 0;
            this.rdBtnHombre.TabStop = true;
            this.rdBtnHombre.Text = "Hombre";
            this.rdBtnHombre.UseVisualStyleBackColor = true;
            // 
            // lblPuesto
            // 
            this.lblPuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(158, 275);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(73, 24);
            this.lblPuesto.TabIndex = 6;
            this.lblPuesto.Text = "Puesto:";
            this.lblPuesto.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(171, 172);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(60, 24);
            this.lblEdad.TabIndex = 7;
            this.lblEdad.Text = "Edad:";
            // 
            // checkBoxDobleTurno
            // 
            this.checkBoxDobleTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxDobleTurno.AutoSize = true;
            this.checkBoxDobleTurno.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkBoxDobleTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDobleTurno.Location = new System.Drawing.Point(247, 226);
            this.checkBoxDobleTurno.Name = "checkBoxDobleTurno";
            this.checkBoxDobleTurno.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.checkBoxDobleTurno.Size = new System.Drawing.Size(193, 28);
            this.checkBoxDobleTurno.TabIndex = 3;
            this.checkBoxDobleTurno.Text = "Hace doble turno?";
            this.checkBoxDobleTurno.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(247, 138);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.Location = new System.Drawing.Point(559, 95);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(252, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownEdad.Location = new System.Drawing.Point(247, 178);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(189, 20);
            this.numericUpDownEdad.TabIndex = 2;
            // 
            // cboBoxPuesto
            // 
            this.cboBoxPuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboBoxPuesto.FormattingEnabled = true;
            this.cboBoxPuesto.Location = new System.Drawing.Point(250, 278);
            this.cboBoxPuesto.Name = "cboBoxPuesto";
            this.cboBoxPuesto.Size = new System.Drawing.Size(190, 21);
            this.cboBoxPuesto.TabIndex = 5;
            // 
            // txtSalario
            // 
            this.txtSalario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalario.Location = new System.Drawing.Point(250, 319);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(252, 20);
            this.txtSalario.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.Location = new System.Drawing.Point(250, 359);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(252, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(326, 396);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(153, 44);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(199, 91);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 24);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(247, 96);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(189, 20);
            this.txtID.TabIndex = 19;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(76, 473);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(907, 248);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Edad";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Doble turno";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Género";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Puesto";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Salario";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Télefono";
            this.columnHeader10.Width = 100;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(496, 396);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 44);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1022, 733);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.cboBoxPuesto);
            this.Controls.Add(this.numericUpDownEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.checkBoxDobleTurno);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.grBoxGenero);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblEmpleado);
            this.MaximumSize = new System.Drawing.Size(1038, 772);
            this.MinimumSize = new System.Drawing.Size(710, 763);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grBoxGenero.ResumeLayout(false);
            this.grBoxGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.GroupBox grBoxGenero;
        private System.Windows.Forms.RadioButton rdBtnNoBin;
        private System.Windows.Forms.RadioButton rdBtnMujer;
        private System.Windows.Forms.RadioButton rdBtnHombre;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.CheckBox checkBoxDobleTurno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.ComboBox cboBoxPuesto;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnEliminar;
    }
}


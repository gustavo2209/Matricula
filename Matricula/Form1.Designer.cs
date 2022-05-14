
namespace Matricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDesarrollo = new System.Windows.Forms.CheckBox();
            this.chkDiseno = new System.Windows.Forms.CheckBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.chkOfi = new System.Windows.Forms.CheckBox();
            this.cboDesarrollo = new System.Windows.Forms.ComboBox();
            this.cboDiseno = new System.Windows.Forms.ComboBox();
            this.cboAdmin = new System.Windows.Forms.ComboBox();
            this.cboOfi = new System.Windows.Forms.ComboBox();
            this.lblpresentacion = new System.Windows.Forms.Label();
            this.grupo = new System.Windows.Forms.GroupBox();
            this.rdbNoche = new System.Windows.Forms.RadioButton();
            this.rdbManana = new System.Windows.Forms.RadioButton();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboDias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbCurso = new System.Windows.Forms.ListBox();
            this.lsbFrecuencia = new System.Windows.Forms.ListBox();
            this.lsbPrecio = new System.Windows.Forms.ListBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            this.grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONE CURSOS PARA MATRICULARSE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(0, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(761, 3);
            this.label2.TabIndex = 1;
            // 
            // chkDesarrollo
            // 
            this.chkDesarrollo.AutoSize = true;
            this.chkDesarrollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDesarrollo.Location = new System.Drawing.Point(23, 76);
            this.chkDesarrollo.Name = "chkDesarrollo";
            this.chkDesarrollo.Size = new System.Drawing.Size(102, 21);
            this.chkDesarrollo.TabIndex = 2;
            this.chkDesarrollo.Text = "Desarrollo";
            this.chkDesarrollo.UseVisualStyleBackColor = true;
            this.chkDesarrollo.CheckedChanged += new System.EventHandler(this.cambiarEstadoPresentacion);
            this.chkDesarrollo.Click += new System.EventHandler(this.chkDesarrollo_Click);
            // 
            // chkDiseno
            // 
            this.chkDiseno.AutoSize = true;
            this.chkDiseno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiseno.Location = new System.Drawing.Point(23, 117);
            this.chkDiseno.Name = "chkDiseno";
            this.chkDiseno.Size = new System.Drawing.Size(77, 21);
            this.chkDiseno.TabIndex = 3;
            this.chkDiseno.Text = "Diseño";
            this.chkDiseno.UseVisualStyleBackColor = true;
            this.chkDiseno.CheckedChanged += new System.EventHandler(this.cambiarEstadoPresentacion);
            this.chkDiseno.Click += new System.EventHandler(this.chkDiseno_Click);
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmin.Location = new System.Drawing.Point(23, 160);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(133, 21);
            this.chkAdmin.TabIndex = 4;
            this.chkAdmin.Text = "Administración";
            this.chkAdmin.UseVisualStyleBackColor = true;
            this.chkAdmin.CheckedChanged += new System.EventHandler(this.cambiarEstadoPresentacion);
            this.chkAdmin.Click += new System.EventHandler(this.chkAdmin_Click);
            // 
            // chkOfi
            // 
            this.chkOfi.AutoSize = true;
            this.chkOfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOfi.Location = new System.Drawing.Point(23, 201);
            this.chkOfi.Name = "chkOfi";
            this.chkOfi.Size = new System.Drawing.Size(95, 21);
            this.chkOfi.TabIndex = 5;
            this.chkOfi.Text = "Ofimática";
            this.chkOfi.UseVisualStyleBackColor = true;
            this.chkOfi.CheckedChanged += new System.EventHandler(this.cambiarEstadoPresentacion);
            this.chkOfi.Click += new System.EventHandler(this.chkOfi_Click);
            // 
            // cboDesarrollo
            // 
            this.cboDesarrollo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesarrollo.FormattingEnabled = true;
            this.cboDesarrollo.Items.AddRange(new object[] {
            "C Sharp",
            "Java",
            "Power Builder",
            "Visual Basic"});
            this.cboDesarrollo.Location = new System.Drawing.Point(189, 76);
            this.cboDesarrollo.Name = "cboDesarrollo";
            this.cboDesarrollo.Size = new System.Drawing.Size(121, 21);
            this.cboDesarrollo.TabIndex = 6;
            this.cboDesarrollo.Visible = false;
            this.cboDesarrollo.SelectedIndexChanged += new System.EventHandler(this.cboDesarrollo_SelectedIndexChanged);
            // 
            // cboDiseno
            // 
            this.cboDiseno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiseno.FormattingEnabled = true;
            this.cboDiseno.Items.AddRange(new object[] {
            "AutoCad",
            "Corel Draw",
            "Photoshop",
            "Image Composer"});
            this.cboDiseno.Location = new System.Drawing.Point(189, 117);
            this.cboDiseno.Name = "cboDiseno";
            this.cboDiseno.Size = new System.Drawing.Size(121, 21);
            this.cboDiseno.TabIndex = 7;
            this.cboDiseno.Visible = false;
            this.cboDiseno.SelectedIndexChanged += new System.EventHandler(this.cboDiseno_SelectedIndexChanged);
            // 
            // cboAdmin
            // 
            this.cboAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdmin.FormattingEnabled = true;
            this.cboAdmin.Items.AddRange(new object[] {
            "Linux",
            "Solaris",
            "OS/2",
            "Windows 2000"});
            this.cboAdmin.Location = new System.Drawing.Point(189, 160);
            this.cboAdmin.Name = "cboAdmin";
            this.cboAdmin.Size = new System.Drawing.Size(121, 21);
            this.cboAdmin.TabIndex = 8;
            this.cboAdmin.Visible = false;
            this.cboAdmin.SelectedIndexChanged += new System.EventHandler(this.cboAdmin_SelectedIndexChanged);
            // 
            // cboOfi
            // 
            this.cboOfi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOfi.FormattingEnabled = true;
            this.cboOfi.Items.AddRange(new object[] {
            "Word",
            "Excel",
            "PowerPoint",
            "Access"});
            this.cboOfi.Location = new System.Drawing.Point(189, 201);
            this.cboOfi.Name = "cboOfi";
            this.cboOfi.Size = new System.Drawing.Size(121, 21);
            this.cboOfi.TabIndex = 9;
            this.cboOfi.Visible = false;
            this.cboOfi.SelectedIndexChanged += new System.EventHandler(this.cboOfi_SelectedIndexChanged);
            // 
            // lblpresentacion
            // 
            this.lblpresentacion.Image = global::Matricula.Properties.Resources.x_mickb;
            this.lblpresentacion.Location = new System.Drawing.Point(186, 76);
            this.lblpresentacion.Name = "lblpresentacion";
            this.lblpresentacion.Size = new System.Drawing.Size(548, 149);
            this.lblpresentacion.TabIndex = 10;
            // 
            // grupo
            // 
            this.grupo.Controls.Add(this.rdbNoche);
            this.grupo.Controls.Add(this.rdbManana);
            this.grupo.Controls.Add(this.rdbTarde);
            this.grupo.Controls.Add(this.btnAceptar);
            this.grupo.Controls.Add(this.txtPrecio);
            this.grupo.Controls.Add(this.cboDias);
            this.grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo.Location = new System.Drawing.Point(337, 76);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(397, 149);
            this.grupo.TabIndex = 11;
            this.grupo.TabStop = false;
            this.grupo.Visible = false;
            // 
            // rdbNoche
            // 
            this.rdbNoche.AutoSize = true;
            this.rdbNoche.Location = new System.Drawing.Point(209, 101);
            this.rdbNoche.Name = "rdbNoche";
            this.rdbNoche.Size = new System.Drawing.Size(72, 21);
            this.rdbNoche.TabIndex = 13;
            this.rdbNoche.TabStop = true;
            this.rdbNoche.Text = "Noche";
            this.rdbNoche.UseVisualStyleBackColor = true;
            // 
            // rdbManana
            // 
            this.rdbManana.AutoSize = true;
            this.rdbManana.Location = new System.Drawing.Point(209, 30);
            this.rdbManana.Name = "rdbManana";
            this.rdbManana.Size = new System.Drawing.Size(83, 21);
            this.rdbManana.TabIndex = 3;
            this.rdbManana.TabStop = true;
            this.rdbManana.Text = "Mañana";
            this.rdbManana.UseVisualStyleBackColor = true;
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Location = new System.Drawing.Point(209, 66);
            this.rdbTarde.Name = "rdbTarde";
            this.rdbTarde.Size = new System.Drawing.Size(69, 21);
            this.rdbTarde.TabIndex = 12;
            this.rdbTarde.TabStop = true;
            this.rdbTarde.Text = "Tarde";
            this.rdbTarde.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(22, 99);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 31);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(22, 64);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 23);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboDias
            // 
            this.cboDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDias.FormattingEnabled = true;
            this.cboDias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes"});
            this.cboDias.Location = new System.Drawing.Point(22, 27);
            this.cboDias.Name = "cboDias";
            this.cboDias.Size = new System.Drawing.Size(121, 24);
            this.cboDias.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(0, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(761, 3);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(711, 35);
            this.label4.TabIndex = 13;
            this.label4.Text = "CURSOS SELECCIONADOS POR USTED";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsbCurso
            // 
            this.lsbCurso.FormattingEnabled = true;
            this.lsbCurso.Location = new System.Drawing.Point(23, 318);
            this.lsbCurso.Name = "lsbCurso";
            this.lsbCurso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lsbCurso.Size = new System.Drawing.Size(272, 134);
            this.lsbCurso.TabIndex = 14;
            // 
            // lsbFrecuencia
            // 
            this.lsbFrecuencia.FormattingEnabled = true;
            this.lsbFrecuencia.Location = new System.Drawing.Point(295, 318);
            this.lsbFrecuencia.Name = "lsbFrecuencia";
            this.lsbFrecuencia.Size = new System.Drawing.Size(286, 134);
            this.lsbFrecuencia.TabIndex = 15;
            // 
            // lsbPrecio
            // 
            this.lsbPrecio.FormattingEnabled = true;
            this.lsbPrecio.Location = new System.Drawing.Point(581, 318);
            this.lsbPrecio.Name = "lsbPrecio";
            this.lsbPrecio.Size = new System.Drawing.Size(153, 134);
            this.lsbPrecio.TabIndex = 16;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(23, 476);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(272, 23);
            this.lblCantidad.TabIndex = 17;
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(581, 476);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(153, 23);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Location = new System.Drawing.Point(23, 523);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(711, 33);
            this.btnElimina.TabIndex = 19;
            this.btnElimina.Text = "Elimina Seleccionados";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(760, 568);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lsbPrecio);
            this.Controls.Add(this.lsbFrecuencia);
            this.Controls.Add(this.lsbCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.cboDesarrollo);
            this.Controls.Add(this.cboDiseno);
            this.Controls.Add(this.cboOfi);
            this.Controls.Add(this.lblpresentacion);
            this.Controls.Add(this.cboAdmin);
            this.Controls.Add(this.chkOfi);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.chkDiseno);
            this.Controls.Add(this.chkDesarrollo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupo.ResumeLayout(false);
            this.grupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDesarrollo;
        private System.Windows.Forms.CheckBox chkDiseno;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.CheckBox chkOfi;
        private System.Windows.Forms.ComboBox cboDesarrollo;
        private System.Windows.Forms.ComboBox cboDiseno;
        private System.Windows.Forms.ComboBox cboAdmin;
        private System.Windows.Forms.ComboBox cboOfi;
        private System.Windows.Forms.Label lblpresentacion;
        private System.Windows.Forms.GroupBox grupo;
        private System.Windows.Forms.ComboBox cboDias;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton rdbNoche;
        private System.Windows.Forms.RadioButton rdbManana;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lsbCurso;
        private System.Windows.Forms.ListBox lsbFrecuencia;
        private System.Windows.Forms.ListBox lsbPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnElimina;
    }
}


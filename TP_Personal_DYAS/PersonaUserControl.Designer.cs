using System;
using TP_Personal_DYAS_BE;
using TP_Personal_DYAS_BLL;

namespace TP_Personal_DYAS
{
    partial class PersonaUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sexoCombo = new System.Windows.Forms.ComboBox();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.profesionCombo = new System.Windows.Forms.ComboBox();
            this.nacionalidadCombo = new System.Windows.Forms.ComboBox();
            this.fechaNacimientoTxt = new System.Windows.Forms.MaskedTextBox();
            this.personasDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.nroPersonaFiltroTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buscarBtn = new System.Windows.Forms.Button();
            this.NroPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Profesion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(130, 17);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(100, 20);
            this.nombreTxt.TabIndex = 0;
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Location = new System.Drawing.Point(342, 17);
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(100, 20);
            this.apellidoTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Profesión";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nacionalidad";
            // 
            // sexoCombo
            // 
            this.sexoCombo.FormattingEnabled = true;
            this.sexoCombo.Location = new System.Drawing.Point(342, 46);
            this.sexoCombo.Name = "sexoCombo";
            this.sexoCombo.Size = new System.Drawing.Size(121, 21);
            this.sexoCombo.TabIndex = 12;
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(494, 15);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(121, 23);
            this.agregarBtn.TabIndex = 13;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // profesionCombo
            // 
            this.profesionCombo.FormattingEnabled = true;
            this.profesionCombo.Location = new System.Drawing.Point(130, 69);
            this.profesionCombo.Name = "profesionCombo";
            this.profesionCombo.Size = new System.Drawing.Size(121, 21);
            this.profesionCombo.TabIndex = 15;
            // 
            // nacionalidadCombo
            // 
            this.nacionalidadCombo.FormattingEnabled = true;
            this.nacionalidadCombo.Location = new System.Drawing.Point(342, 73);
            this.nacionalidadCombo.Name = "nacionalidadCombo";
            this.nacionalidadCombo.Size = new System.Drawing.Size(121, 21);
            this.nacionalidadCombo.TabIndex = 16;
            // 
            // fechaNacimientoTxt
            // 
            this.fechaNacimientoTxt.Location = new System.Drawing.Point(130, 43);
            this.fechaNacimientoTxt.Mask = "00/00/0000";
            this.fechaNacimientoTxt.Name = "fechaNacimientoTxt";
            this.fechaNacimientoTxt.Size = new System.Drawing.Size(109, 20);
            this.fechaNacimientoTxt.TabIndex = 17;
            this.fechaNacimientoTxt.ValidatingType = typeof(System.DateTime);
            // 
            // personasDataGridView
            // 
            this.personasDataGridView.AllowUserToAddRows = false;
            this.personasDataGridView.AllowUserToDeleteRows = false;
            this.personasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroPersona,
            this.Nombre,
            this.Apellido,
            this.FechaNacimiento,
            this.Sexo,
            this.Profesion,
            this.Nacionalidad,
            this.Editar,
            this.Eliminar});
            this.personasDataGridView.Location = new System.Drawing.Point(34, 113);
            this.personasDataGridView.MultiSelect = false;
            this.personasDataGridView.Name = "personasDataGridView";
            this.personasDataGridView.Size = new System.Drawing.Size(724, 250);
            this.personasDataGridView.TabIndex = 18;
            this.personasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personasDataGridView_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Filtrar por Nro de Persona";
            // 
            // nroPersonaFiltroTxt
            // 
            this.nroPersonaFiltroTxt.Location = new System.Drawing.Point(177, 378);
            this.nroPersonaFiltroTxt.Name = "nroPersonaFiltroTxt";
            this.nroPersonaFiltroTxt.Size = new System.Drawing.Size(100, 20);
            this.nroPersonaFiltroTxt.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(283, 375);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(104, 24);
            this.buscarBtn.TabIndex = 22;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // NroPersona
            // 
            this.NroPersona.DataPropertyName = "nroPersona";
            this.NroPersona.HeaderText = "Nro Persona";
            this.NroPersona.Name = "NroPersona";
            this.NroPersona.ReadOnly = true;
            this.NroPersona.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha De Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Profesion
            // 
            this.Profesion.DataPropertyName = "idProfesion";
            this.Profesion.HeaderText = "Profesión";
            this.Profesion.Name = "Profesion";
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.DataPropertyName = "idNacionalidad";
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // PersonaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.nroPersonaFiltroTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.personasDataGridView);
            this.Controls.Add(this.fechaNacimientoTxt);
            this.Controls.Add(this.nacionalidadCombo);
            this.Controls.Add(this.profesionCombo);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.sexoCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apellidoTxt);
            this.Controls.Add(this.nombreTxt);
            this.Name = "PersonaUserControl";
            this.Size = new System.Drawing.Size(797, 425);
            ((System.ComponentModel.ISupportInitialize)(this.personasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox apellidoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sexoCombo;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.ComboBox profesionCombo;
        private System.Windows.Forms.ComboBox nacionalidadCombo;
        private System.Windows.Forms.MaskedTextBox fechaNacimientoTxt;
        private System.Windows.Forms.DataGridView personasDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nroPersonaFiltroTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Profesion;
        private System.Windows.Forms.DataGridViewComboBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}

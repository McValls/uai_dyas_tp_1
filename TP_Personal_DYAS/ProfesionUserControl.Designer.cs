namespace TP_Personal_DYAS
{
    partial class ProfesionUserControl
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
            this.ProfesionDataSourceGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesionDataSourceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfesionDataSourceGrid
            // 
            this.ProfesionDataSourceGrid.AllowUserToAddRows = false;
            this.ProfesionDataSourceGrid.AllowUserToDeleteRows = false;
            this.ProfesionDataSourceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProfesionDataSourceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descripcion,
            this.Editar,
            this.Eliminar});
            this.ProfesionDataSourceGrid.Location = new System.Drawing.Point(15, 56);
            this.ProfesionDataSourceGrid.Name = "ProfesionDataSourceGrid";
            this.ProfesionDataSourceGrid.Size = new System.Drawing.Size(753, 341);
            this.ProfesionDataSourceGrid.TabIndex = 11;
            this.ProfesionDataSourceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProfesionDataSourceGrid_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(670, 27);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(112, 23);
            this.agregarBtn.TabIndex = 10;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Profesión";
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Location = new System.Drawing.Point(75, 27);
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(589, 20);
            this.descripcionTxt.TabIndex = 8;
            // 
            // ProfesionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProfesionDataSourceGrid);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descripcionTxt);
            this.Name = "ProfesionUserControl";
            this.Size = new System.Drawing.Size(797, 425);
            ((System.ComponentModel.ISupportInitialize)(this.ProfesionDataSourceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProfesionDataSourceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcionTxt;
    }
}

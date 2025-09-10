namespace TP_Personal_DYAS
{
    partial class NacionalidadUserControl
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
            this.NacionalidadDataSourceGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NacionalidadDataSourceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NacionalidadDataSourceGrid
            // 
            this.NacionalidadDataSourceGrid.AllowUserToAddRows = false;
            this.NacionalidadDataSourceGrid.AllowUserToDeleteRows = false;
            this.NacionalidadDataSourceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NacionalidadDataSourceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descripcion,
            this.Editar,
            this.Eliminar});
            this.NacionalidadDataSourceGrid.Location = new System.Drawing.Point(3, 59);
            this.NacionalidadDataSourceGrid.Name = "NacionalidadDataSourceGrid";
            this.NacionalidadDataSourceGrid.Size = new System.Drawing.Size(753, 341);
            this.NacionalidadDataSourceGrid.TabIndex = 7;
            this.NacionalidadDataSourceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NacionalidadDataSourceGrid_CellContentClick);
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
            this.agregarBtn.Location = new System.Drawing.Point(658, 30);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(112, 23);
            this.agregarBtn.TabIndex = 6;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "País";
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Location = new System.Drawing.Point(63, 30);
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(589, 20);
            this.descripcionTxt.TabIndex = 4;
            // 
            // NacionalidadUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NacionalidadDataSourceGrid);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descripcionTxt);
            this.Name = "NacionalidadUserControl";
            this.Size = new System.Drawing.Size(797, 425);
            ((System.ComponentModel.ISupportInitialize)(this.NacionalidadDataSourceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NacionalidadDataSourceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcionTxt;
    }
}

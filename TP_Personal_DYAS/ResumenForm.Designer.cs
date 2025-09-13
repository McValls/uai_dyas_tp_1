namespace TP_Personal_DYAS
{
    partial class ResumenForm
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
            this.profesionConMasPersonasTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nacionalidadesDataGridView = new System.Windows.Forms.DataGridView();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonasRegistradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromedioDeEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidadConMenosPersonasTxt = new System.Windows.Forms.TextBox();
            this.edadMaximaTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edadMinimaTxt = new System.Windows.Forms.TextBox();
            this.nacionalidadConMasPersonasTxt = new System.Windows.Forms.TextBox();
            this.promedioEdadesTxt = new System.Windows.Forms.TextBox();
            this.personasRegistradasTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nacionalidadesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // profesionConMasPersonasTxt
            // 
            this.profesionConMasPersonasTxt.Location = new System.Drawing.Point(229, 153);
            this.profesionConMasPersonasTxt.Name = "profesionConMasPersonasTxt";
            this.profesionConMasPersonasTxt.Size = new System.Drawing.Size(100, 20);
            this.profesionConMasPersonasTxt.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(46, 152);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(182, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Profesión con más personas";
            // 
            // nacionalidadesDataGridView
            // 
            this.nacionalidadesDataGridView.AllowUserToAddRows = false;
            this.nacionalidadesDataGridView.AllowUserToDeleteRows = false;
            this.nacionalidadesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nacionalidadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nacionalidadesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nacionalidad,
            this.PersonasRegistradas,
            this.PromedioDeEdad});
            this.nacionalidadesDataGridView.Location = new System.Drawing.Point(99, 193);
            this.nacionalidadesDataGridView.Name = "nacionalidadesDataGridView";
            this.nacionalidadesDataGridView.Size = new System.Drawing.Size(656, 186);
            this.nacionalidadesDataGridView.TabIndex = 36;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.DataPropertyName = "nacionalidad";
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.ReadOnly = true;
            // 
            // PersonasRegistradas
            // 
            this.PersonasRegistradas.DataPropertyName = "personasRegistradas";
            this.PersonasRegistradas.HeaderText = "Personas Registradas";
            this.PersonasRegistradas.Name = "PersonasRegistradas";
            this.PersonasRegistradas.ReadOnly = true;
            // 
            // PromedioDeEdad
            // 
            this.PromedioDeEdad.DataPropertyName = "promedioEdad";
            this.PromedioDeEdad.HeaderText = "Promedio de edad";
            this.PromedioDeEdad.Name = "PromedioDeEdad";
            this.PromedioDeEdad.ReadOnly = true;
            // 
            // nacionalidadConMenosPersonasTxt
            // 
            this.nacionalidadConMenosPersonasTxt.Location = new System.Drawing.Point(655, 123);
            this.nacionalidadConMenosPersonasTxt.Name = "nacionalidadConMenosPersonasTxt";
            this.nacionalidadConMenosPersonasTxt.Size = new System.Drawing.Size(100, 20);
            this.nacionalidadConMenosPersonasTxt.TabIndex = 35;
            // 
            // edadMaximaTxt
            // 
            this.edadMaximaTxt.Location = new System.Drawing.Point(655, 97);
            this.edadMaximaTxt.Name = "edadMaximaTxt";
            this.edadMaximaTxt.Size = new System.Drawing.Size(100, 20);
            this.edadMaximaTxt.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 126);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(158, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Nacionalidad con más personas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 100);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Edad Máxima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 126);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nacionalidad con menos personas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 74);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Promedio de edades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Edad mínima";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 74);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Personas registradas";
            // 
            // edadMinimaTxt
            // 
            this.edadMinimaTxt.Location = new System.Drawing.Point(229, 97);
            this.edadMinimaTxt.Name = "edadMinimaTxt";
            this.edadMinimaTxt.Size = new System.Drawing.Size(100, 20);
            this.edadMinimaTxt.TabIndex = 27;
            // 
            // nacionalidadConMasPersonasTxt
            // 
            this.nacionalidadConMasPersonasTxt.Location = new System.Drawing.Point(229, 123);
            this.nacionalidadConMasPersonasTxt.Name = "nacionalidadConMasPersonasTxt";
            this.nacionalidadConMasPersonasTxt.Size = new System.Drawing.Size(100, 20);
            this.nacionalidadConMasPersonasTxt.TabIndex = 26;
            // 
            // promedioEdadesTxt
            // 
            this.promedioEdadesTxt.Location = new System.Drawing.Point(655, 71);
            this.promedioEdadesTxt.Name = "promedioEdadesTxt";
            this.promedioEdadesTxt.Size = new System.Drawing.Size(100, 20);
            this.promedioEdadesTxt.TabIndex = 25;
            // 
            // personasRegistradasTxt
            // 
            this.personasRegistradasTxt.Location = new System.Drawing.Point(229, 71);
            this.personasRegistradasTxt.Name = "personasRegistradasTxt";
            this.personasRegistradasTxt.Size = new System.Drawing.Size(100, 20);
            this.personasRegistradasTxt.TabIndex = 24;
            // 
            // ResumenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.profesionConMasPersonasTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nacionalidadesDataGridView);
            this.Controls.Add(this.nacionalidadConMenosPersonasTxt);
            this.Controls.Add(this.edadMaximaTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edadMinimaTxt);
            this.Controls.Add(this.nacionalidadConMasPersonasTxt);
            this.Controls.Add(this.promedioEdadesTxt);
            this.Controls.Add(this.personasRegistradasTxt);
            this.Name = "ResumenForm";
            this.Text = "ResumenForm";
            this.Load += new System.EventHandler(this.ResumenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nacionalidadesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox profesionConMasPersonasTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView nacionalidadesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonasRegistradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromedioDeEdad;
        private System.Windows.Forms.TextBox nacionalidadConMenosPersonasTxt;
        private System.Windows.Forms.TextBox edadMaximaTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edadMinimaTxt;
        private System.Windows.Forms.TextBox nacionalidadConMasPersonasTxt;
        private System.Windows.Forms.TextBox promedioEdadesTxt;
        private System.Windows.Forms.TextBox personasRegistradasTxt;
    }
}
namespace TP_Personal_DYAS
{
    partial class TPPersonalMainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verResumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nacionalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.verResumenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1243, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click_1);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nacionalidadesToolStripMenuItem,
            this.profesionesToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // verResumenToolStripMenuItem
            // 
            this.verResumenToolStripMenuItem.Name = "verResumenToolStripMenuItem";
            this.verResumenToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.verResumenToolStripMenuItem.Text = "Ver Resumen";
            this.verResumenToolStripMenuItem.Click += new System.EventHandler(this.verResumenToolStripMenuItem_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nacionalidadesToolStripMenuItem
            // 
            this.nacionalidadesToolStripMenuItem.Name = "nacionalidadesToolStripMenuItem";
            this.nacionalidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nacionalidadesToolStripMenuItem.Text = "Nacionalidades";
            this.nacionalidadesToolStripMenuItem.Click += new System.EventHandler(this.nacionalidadesToolStripMenuItem_Click);
            // 
            // profesionesToolStripMenuItem
            // 
            this.profesionesToolStripMenuItem.Name = "profesionesToolStripMenuItem";
            this.profesionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profesionesToolStripMenuItem.Text = "Profesiones";
            this.profesionesToolStripMenuItem.Click += new System.EventHandler(this.profesionesToolStripMenuItem_Click_1);
            // 
            // TPPersonalMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 659);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TPPersonalMainForm";
            this.Text = "TPPersonalMainForm";
            this.Load += new System.EventHandler(this.TPPersonalMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacionalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verResumenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
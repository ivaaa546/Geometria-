namespace Proyecto_Geometria
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAMBIODESESIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRESEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRISMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRISMAEXAGONALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cILINDROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cÓNICOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.pRESEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1286, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOUSUARIOToolStripMenuItem,
            this.cAMBIODESESIÓNToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // nUEVOUSUARIOToolStripMenuItem
            // 
            this.nUEVOUSUARIOToolStripMenuItem.Name = "nUEVOUSUARIOToolStripMenuItem";
            this.nUEVOUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.nUEVOUSUARIOToolStripMenuItem.Text = "NUEVO USUARIO";
            // 
            // cAMBIODESESIÓNToolStripMenuItem
            // 
            this.cAMBIODESESIÓNToolStripMenuItem.Name = "cAMBIODESESIÓNToolStripMenuItem";
            this.cAMBIODESESIÓNToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.cAMBIODESESIÓNToolStripMenuItem.Text = "CAMBIO DE SESIÓN";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            // 
            // pRESEToolStripMenuItem
            // 
            this.pRESEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRISMAToolStripMenuItem,
            this.pRISMAEXAGONALToolStripMenuItem,
            this.cILINDROToolStripMenuItem,
            this.cÓNICOToolStripMenuItem});
            this.pRESEToolStripMenuItem.Name = "pRESEToolStripMenuItem";
            this.pRESEToolStripMenuItem.Size = new System.Drawing.Size(205, 20);
            this.pRESEToolStripMenuItem.Text = "PRESENTACIÓNES DE LOS ENVASES";
            this.pRESEToolStripMenuItem.Click += new System.EventHandler(this.pRESEToolStripMenuItem_Click);
            // 
            // pRISMAToolStripMenuItem
            // 
            this.pRISMAToolStripMenuItem.Name = "pRISMAToolStripMenuItem";
            this.pRISMAToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.pRISMAToolStripMenuItem.Text = "PRISMA CUADRANGULAR";
            this.pRISMAToolStripMenuItem.Click += new System.EventHandler(this.pRISMAToolStripMenuItem_Click);
            // 
            // pRISMAEXAGONALToolStripMenuItem
            // 
            this.pRISMAEXAGONALToolStripMenuItem.Name = "pRISMAEXAGONALToolStripMenuItem";
            this.pRISMAEXAGONALToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.pRISMAEXAGONALToolStripMenuItem.Text = "PRISMA EXAGONAL";
            this.pRISMAEXAGONALToolStripMenuItem.Click += new System.EventHandler(this.pRISMAEXAGONALToolStripMenuItem_Click);
            // 
            // cILINDROToolStripMenuItem
            // 
            this.cILINDROToolStripMenuItem.Name = "cILINDROToolStripMenuItem";
            this.cILINDROToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cILINDROToolStripMenuItem.Text = "CILINDRICO";
            this.cILINDROToolStripMenuItem.Click += new System.EventHandler(this.cILINDROToolStripMenuItem_Click);
            // 
            // cÓNICOToolStripMenuItem
            // 
            this.cÓNICOToolStripMenuItem.Name = "cÓNICOToolStripMenuItem";
            this.cÓNICOToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cÓNICOToolStripMenuItem.Text = "CÓNICO";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 657);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Figuras Geometricas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAMBIODESESIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRESEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRISMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRISMAEXAGONALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cILINDROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cÓNICOToolStripMenuItem;
    }
}


using Proyecto_Geometria.FORMULARIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Geometria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pRESEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRISMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //generar una instancia al formulario frmPCuadrangular

            frmPCuadrangular pc = new frmPCuadrangular();
            pc.MdiParent = this; //
            pc.Show(); //muesta formulario
                
        }

        private void pRISMAEXAGONALToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmPrismaHexagonal fc = new frmPrismaHexagonal();
            fc.MdiParent = this; //
            fc.Show(); //muesta formulario
        }

        private void cILINDROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCilindro cl = new frmCilindro();
            cl.MdiParent = this; //
            cl.Show(); //muesta formulario
        }
    }
}

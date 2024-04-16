using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Geometria.FORMULARIOS
{
    public partial class frmPCuadrangular : Form
    {
        public frmPCuadrangular()
        {
            InitializeComponent();
        }
        //declaramos variables
        double lado, altura;

        private void chkGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if(chkGeneral.Checked == true)
            {
                chkGeneral.Enabled = true;
                chk1.Enabled = false;
                chk2.Enabled = false;
                chk3.Enabled = false;
                chk4.Enabled = false;
                txtV.Enabled = false;
                txtA.Enabled = false;

            }

            else
            {
                chkGeneral.Enabled = true;
                chk1.Enabled = true;
                chk2.Enabled = true;
                chk3.Enabled = true;
                chk4.Enabled = true;
                txtV.Enabled = true;
                txtA.Enabled = true;
            }
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == true)
            {
                chkGeneral.Enabled = false;
                chk1.Enabled = true;
                chk2.Enabled = false;
                chk3.Enabled = false;
                chk4.Enabled = false;
                txtL.Enabled = false;
                txtA.Enabled = false;

            }

            else
            {
                chkGeneral.Enabled = true;
                chk1.Enabled = true;
                chk2.Enabled = true;
                chk3.Enabled = true;
                chk4.Enabled = true;
                txtL.Enabled = true;
                txtA.Enabled = true;
            }
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2.Checked == true)
            {
                chkGeneral.Enabled = false;
                chk1.Enabled = false;
                chk2.Enabled = true;
                chk3.Enabled = false;
                chk4.Enabled = false;
                txtH.Enabled = false;
                txtA.Enabled = false;

            }

            else
            {
                chkGeneral.Enabled = true;
                chk1.Enabled = true;
                chk2.Enabled = true;
                chk3.Enabled = true;
                chk4.Enabled = true;
                txtH.Enabled = true;
                txtA.Enabled = true;
            }
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3.Checked == true)
            {
                chkGeneral.Enabled = false;
                chk1.Enabled = false;
                chk2.Enabled = false;
                chk3.Enabled = true;
                chk4.Enabled = false;
                txtL.Enabled = false;
                txtV.Enabled = false;

            }

            else
            {
                chkGeneral.Enabled = true;
                chk1.Enabled = true;
                chk2.Enabled = true;
                chk3.Enabled = true;
                chk4.Enabled = true;
                txtL.Enabled = true;
                txtV.Enabled = true;
            }
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4.Checked == true)
            {
                chkGeneral.Enabled = false;
                chk1.Enabled = false;
                chk2.Enabled = false;
                chk3.Enabled = false;
                chk4.Enabled = true;
                txtH.Enabled = false;
                txtV.Enabled = false;

            }

            else
            {
                chkGeneral.Enabled = true;
                chk1.Enabled = true;
                chk2.Enabled = true;
                chk3.Enabled = true;
                chk4.Enabled = true;
                txtH.Enabled = true;
                txtV.Enabled = true;
            }
        }
        

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            //evaluar el checkbox activo en el momento
            if (chkGeneral.Checked == true)
            {

                bool lado1 = double.TryParse(txtL.Text, out lado);
                bool altura1 = double.TryParse(txtH.Text, out altura);
                Vprisma(lado, altura);
                Aprisma(lado, altura);
            }


            else if (chk1.Checked == true)
            {
                double v;
                bool v1 = double.TryParse(txtV.Text, out v);
                bool altura1 = double.TryParse(txtH.Text, out altura);
                LadoV(v,altura);
                Aprisma(Convert.ToDouble(txtL.Text), altura);

            }


            else if (chk2.Checked == true)
            {

                double v;
                bool v1 = double.TryParse(txtV.Text, out v);
                bool lado1 = double.TryParse(txtL.Text, out lado);

                alturaV(v, lado);
                Aprisma(lado,Convert.ToDouble(txtH.Text));


            }

            else if(chk3.Checked == true)
            {
                
              
                  prismaL();
                
            }

            else if (chk4.Checked == true)
            {
                prismaH();
            }
        }

        //metodo void para calcular el voluemn
        public void Vprisma(double lado, double altura) 
        {
            double v;

            //procedimiento
            v = Math.Pow(lado, 2) * altura;

            txtV.Text = Math.Round(v,2).ToString();
        }

        //metodo para void calcular area
        public void Aprisma(double lado, double altura)
        {
            double a;

            a = (2*lado)*(lado+(2*altura));
            txtA.Text = Math.Round(a,2).ToString();


        }

        //calculo del lado
        public void LadoV(double v, double a)
        {
            

            lado = Math.Sqrt(v / altura);

            txtL.Text = Math.Round(lado,2).ToString();
        }

        //calculo de la altura
        public void alturaV(double v, double lado)
        {
            double altura;

            altura = v / Math.Pow(lado, 2);

            txtH.Text = Math.Round(altura,2).ToString();

        }

        //calculo lado prisma cuadrangular
        double l1, l2;
        public void prismaL()
        {
            double area;
            bool area1 = double.TryParse(txtA.Text, out area);
            bool altura1 = double.TryParse(txtH.Text, out altura);

            l1 = ((-4 * altura) - Math.Sqrt(Math.Pow((4 * altura), 2)- (4*2) * -area)) / (2*2);
            l2 = ((-4 * altura) + Math.Sqrt(Math.Pow((4 * altura), 2) - (4 * 2) * -area)) / (2 * 2);
            txtL.Text = Convert.ToString("L1= " + Math.Round(l1,2) + " L2= " + Math.Round(l2, 2));
            volumenArea();
        }

        public void volumenArea()
        {
            double v1, v2;
            bool altura1 = double.TryParse(txtH.Text, out altura);

            v1 = Math.Pow(l1, 2) * altura;
            v2 = Math.Pow(l2, 2) * altura;

            txtV.Text = Convert.ToString("V1= " + Math.Round(v1,2) + " V2= " + Math.Round(v2, 2));
        }
        

        public void prismaH()
        {
            double area, v;
            bool area1 = double.TryParse(txtA.Text, out area);
            bool lado1 = double.TryParse(txtL.Text, out lado);
 
            altura = (area - (2 * Math.Pow(lado, 2))) / (4*lado);
            txtH.Text = altura.ToString();

            v = Math.Pow(lado, 2) * altura;
            txtV.Text = v.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }



        // metodo para limpiar 
        public void limpiar()
        {
            txtL.Clear();
            txtH.Clear();
            txtV.Clear();
            txtA.Clear();
            txtL.Focus();
        }
    }
}

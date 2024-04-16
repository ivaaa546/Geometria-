using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Geometria.FORMULARIOS
{
    public partial class frmPrismaHexagonal : Form
    {
        public frmPrismaHexagonal()
        {
            InitializeComponent();
        }

        private void chkGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGeneral.Checked == true)
            {
                chkGeneral.Enabled = true;
                chk1.Enabled = false;
                chk2.Enabled = false;
                chk3.Enabled = false;
                chk4.Enabled = false;
                chk5.Enabled = false;
                chk6.Enabled = false;
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
                chk4.Enabled = true;
                chk5.Enabled = true;
                chk6.Enabled = true;
                txtV.Enabled = true;
                txtA.Enabled = true;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
                chk5.Enabled = false;
                chk6.Enabled = false;
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
                chk4.Enabled = true;
                chk5.Enabled = true;
                chk6.Enabled = true;
                txtV.Enabled = true;
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
                chk5.Enabled = false;
                chk6.Enabled = false;
                txtH.Enabled = false;
                txtL.Enabled = true;
                txtA.Enabled = false;

            }

            else
            {
                chkGeneral.Enabled = true;
                chk1.Enabled = true;
                chk2.Enabled = true;
                chk3.Enabled = true;
                chk4.Enabled = true;
                chk4.Enabled = true;
                chk5.Enabled = true;
                chk6.Enabled = true;
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
                chk5.Enabled = false;
                chk6.Enabled = false;

                txtAP.Enabled = false;

                txtA.Enabled = false;

            }

            else
            {
                chkGeneral.Enabled = true;
                chk1.Enabled = true;
                chk2.Enabled = true;
                chk3.Enabled = true;
                chk4.Enabled = true;
                chk4.Enabled = true;
                chk5.Enabled = true;
                chk6.Enabled = true;
                txtAP.Enabled = true;
                txtA.Enabled = true;
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
                chk5.Enabled = false;
                chk6.Enabled = false;
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
                chk5.Enabled = true;
                chk6.Enabled = true;
                txtL.Enabled = true;
                txtV.Enabled = true;
            }
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5.Checked == true)
            {
                chkGeneral.Enabled = false;
                chk1.Enabled = false;
                chk2.Enabled = false;
                chk3.Enabled = false;
                chk4.Enabled = false;
                chk5.Enabled = true;
                chk6.Enabled = false;
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
                chk5.Enabled = true;
                chk6.Enabled = true;
                txtH.Enabled = true;
                txtV.Enabled = true;
            }
        }

        private void chk6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6.Checked == true)
            {
                chkGeneral.Enabled = false;
                chk1.Enabled = false;
                chk2.Enabled = false;
                chk3.Enabled = false;
                chk4.Enabled = false;
                chk5.Enabled = false;
                chk6.Enabled = true;
                txtAP.Enabled = false;
                txtV.Enabled = false;

            }

            else
            {
                chkGeneral.Enabled = true;
                chk1.Enabled = true;
                chk2.Enabled = true;
                chk3.Enabled = true;
                chk4.Enabled = true;
                chk5.Enabled = true;
                chk6.Enabled = true;
                txtAP.Enabled = true;
                txtV.Enabled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double lado, altura, apotema;
            if (chkGeneral.Checked == true)
            {
                //obtener valor de cuadro de texto

                bool lado1 = double.TryParse(txtL.Text, out lado);
                bool altura1 = double.TryParse(txtH.Text, out altura);
                bool apotema1 = double.TryParse(txtAP.Text, out apotema);

                volumen(lado, altura, apotema);
                area(lado, altura, apotema);
            }

            else if (chk1.Checked == true)
            {
                double volumen;

                bool volumen1 = double.TryParse(txtV.Text, out volumen);
                bool altura1 = double.TryParse(txtH.Text, out altura);
                bool apotema1 = double.TryParse(txtAP.Text, out apotema);

                laAph(volumen, altura, apotema, 1);
                area(Convert.ToDouble(txtL.Text), altura, apotema);//metodo dentro de otro metodo
            }

            else if (chk2.Checked)
            {
                double volumen;

                bool volumen1 = double.TryParse(txtV.Text, out volumen);
                bool lado1 = double.TryParse(txtL.Text, out lado);
                bool apotema1 = double.TryParse(txtAP.Text, out apotema);

                laAph(volumen, lado, apotema, 2);
                area(lado, Convert.ToDouble(txtH.TabIndex), apotema);
            }

            else if (chk3.Checked)
            {
                double volumen;

                bool volumen1 = double.TryParse(txtV.Text, out volumen);
                bool lado1 = double.TryParse(txtL.Text, out lado);
                bool altura1 = double.TryParse(txtH.Text, out altura);

                laAph(volumen, lado, altura, 3);
                area(lado, altura, Convert.ToDouble(txtAP.Text));
            }

            else if (chk4.Checked)
            {
                double area;

                bool area1 = double.TryParse(txtA.Text, out area);
                bool apotema1 = double.TryParse(txtAP.Text, out apotema);
                bool altura1 = double.TryParse(txtH.Text, out altura);

                ladoArea(area, apotema, altura);

                volumen(Convert.ToDouble(txtL.Text), altura,apotema);
            }

            else if (chk5.Checked)
            {
                double area;

                bool area1 = double.TryParse(txtA.Text, out area);
                bool apotema1 = double.TryParse(txtAP.Text, out apotema);
                bool lado1 = double.TryParse(txtL.Text, out lado);

                alturaApotemaArea(area, lado, apotema,1);
                volumen(lado, Convert.ToDouble(txtH.Text), apotema);
            }

            else if (chk6.Checked)
            {
                double area;

                bool area1 = double.TryParse(txtA.Text, out area);
                bool altura1 = double.TryParse(txtH.Text, out altura);

                bool lado1 = double.TryParse(txtL.Text, out lado);

                alturaApotemaArea(area,lado,altura,2);
                volumen(lado,altura , Convert.ToDouble(txtAP.Text));
            }
        }

        //metodo para el calculo del volumen
        private void volumen(double lado, double altura, double apotema)
        {
            double v;
            v = 3 * lado * apotema * altura;

            //mostrar resultado
            txtV.Text = v.ToString();
        }

        //metodo area
        private void area(double lado, double altura, double apotema)
        {
            double area1;

            area1 = 6 * lado * (apotema + altura);
            txtA.Text = area1.ToString();
        }

        //metodo para calcular el lado, apotema o altura
        private void laAph(double volumen, double valor1, double valor2, int op)
        {
            switch (op)
            {
                case 1:
                    {

                        double lado;
                        lado = volumen / (3 * valor1 * valor2);
                        txtL.Text = lado.ToString();
                        break;
                    }
                case 2:
                    {
                        double altura;
                        altura = volumen / (3 * valor1 * valor2);
                        txtH.Text = altura.ToString();

                        break;
                    }
                case 3:
                    {
                        double apotema;
                        apotema = volumen / (3 * valor1 * valor2);
                        txtAP.Text = apotema.ToString();
                        break;
                    }
            }

        }

        public void ladoArea(double area, double apotema, double altura)
        {
            double lado;
            lado = area / (6*(apotema + altura));

            txtL.Text = Math.Round(lado,2).ToString();
        }

        public void alturaApotemaArea(double area, double var1, double var2, int op)
        {
            switch (op)
            {
                case 1:
                    {
                        double altura;

                        altura = (area / (6 * var1)) - var2;
                        txtH.Text = altura.ToString();
                        break;
                    }
                case 2:
                    {
                        double apotema;
                        apotema = (area / (6 * var1)) - var2;
                        txtAP.Text = apotema.ToString();

                        break;
                    }
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txtL.Clear();
            txtH.Clear();
            txtAP.Clear();
            txtV.Clear();
            txtA.Clear();
            txtL.Focus();

            //habilitar cudrdos de texto
           
            /*chkGeneral.Enabled = true;
            chk1.Enabled = true; 
            chk2.Enabled =true;
            chk3.Enabled = true;
            chk4 .Enabled = true;
            chk5.Enabled = true;
            chk6.Enabled = true;
            txtL.Enabled = true;
            txtH.Enabled = true;
            txtAP.Enabled = true;
            txtV.Enabled = true;
            txtA.Enabled = true;*/
        }

    }
}

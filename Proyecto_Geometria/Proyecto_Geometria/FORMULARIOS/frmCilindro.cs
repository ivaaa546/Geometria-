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
    public partial class frmCilindro : Form
    {
        public frmCilindro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double radio, altura;

            if(comboBox1.SelectedIndex == 0 )
            {
                bool radio1 = double.TryParse(txtR.Text, out radio);
                bool altura1 = double.TryParse(txtH.Text, out altura);

                areabase(radio);
                volumen(radio, altura);
            }


            else if (comboBox1.SelectedIndex == 1)
            {
                double volumen;
               
                bool altura1 = double.TryParse(txtH.Text, out altura);
                bool volumen1 = double.TryParse(txtV.Text, out volumen);
                radioVolumen(volumen, altura);
                areabase(Convert.ToDouble(txtR.Text));

            }

            else if(comboBox1.SelectedIndex == 2)
            {  
                double volumen;
                bool radio1 = double.TryParse(txtR.Text, out radio);
                bool volumen1 = double.TryParse(txtV.Text, out volumen);
                alturaVolumen(radio, volumen);

                areabase(radio);

            }
        }

        //calcuar el valor del radio en funcion del volumen y la altura
        private void radioVolumen(double volumen, double altura)
        {
            double radio;
            radio = Math.Sqrt(volumen / (3.1416 * altura) );
            txtR.Text = Math.Round(radio,2).ToString();
        }

        //metodo para calcular el valor de la altura

        private void alturaVolumen(double radio, double volumen)
        {
            double altura;
            altura = Math.Sqrt(volumen / (3.1416*radio));
            txtH.Text = Math.Round(altura,2).ToString();
        }

        //calculo volumen
        private void volumen(double radio, double altura)
        {
            double v;
            v = 3.1416 * Math.Pow(radio, 2) * altura;
            txtV.Text = v.ToString();
        }

        //area base 
        private void areabase(double radio)
        {
            double ab;
            ab = 3.1416 * Math.Pow(radio, 2);
            txtA.Text = Math.Round(ab,2).ToString();  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                txtV.Enabled = false;
                txtA.Enabled = false;
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                txtR.Enabled = false;
                txtA.Enabled = false;
            }

            else if(comboBox1.SelectedIndex == 2)
            {
                txtH.Enabled = false;
                txtA.Enabled = false;
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtR.Clear();
            txtH.Clear();
            txtV.Clear();
            txtA.Clear();

            //habiliar elementos
            txtR.Enabled=true;
            txtH.Enabled = true;
            txtV.Enabled=true;
            txtA.Enabled = true;

        }
    }
}

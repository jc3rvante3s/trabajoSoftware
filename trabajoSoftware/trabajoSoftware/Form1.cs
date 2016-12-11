using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajoSoftware
{
    public partial class Form1 : Form
    {
        double peso, altura,resultado;

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            peso = double.Parse(this.txtPeso.Text.Replace(",", "."));
            if(peso<=0 || peso>=200)
            {
                MessageBox.Show("Datos no validos en el campo peso", "Error",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            altura = double.Parse(this.txtAltura.Text.Replace(",","."));

            if (altura <= 0 || altura >= 2.50)
            {
                MessageBox.Show("Datos no validos en el campo altura", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            resultado = peso / (altura * altura);
            this.lblResultado.Text = "El indice de masa corporal que posee es: "+
                Math.Round(resultado,1);
            MostrarMensajes(resultado);
        }

        void MostrarMensajes(double resultado)
        {
            if (resultado >= 18.5 && resultado <= 24.9)
            {
                this.lblRespuesta.Text = "Ud. posee un indice de riesgo promedio";
            }
            else if (resultado > 25 && resultado <= 29.9)
            {
                this.lblRespuesta.Text = "Ud. posee un indice de riesgo un poco mayor del promedio";
            }
            if (resultado >= 30 && resultado <= 34.9)
            {
                this.lblRespuesta.Text = "Ud. posee un indice de riesgo moderado";
            }
            if (resultado >= 35 && resultado <= 39.9)
            {
                this.lblRespuesta.Text = "Ud. posee un indice de riesgo severo";
            }
            else if (resultado >= 40)
            {
                this.lblRespuesta.Text = "Ud. posee un indice de riesgo muy severo";
            }

        }
    }
}

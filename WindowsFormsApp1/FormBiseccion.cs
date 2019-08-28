using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1;

namespace WindowsFormsApp1
{
    public partial class FormBiseccion : Form
    {
        public FormBiseccion()
        {
            InitializeComponent();
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label7.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            

            if (textBox2.Text != "" && textBox3.Text != "")
            {
                double x1 = Convert.ToDouble(textBox2.Text);
                double x2 = Convert.ToDouble(textBox3.Text);
                Biseccion biseccion = new Biseccion();
                Salida salida = new Salida();
                salida = biseccion.MBiseccion(x1, x2);

                textBox4.Text = salida.Raiz.ToString();
                textBox5.Text = salida.NroIteraciones.ToString();
                textBox6.Text = salida.ErrorRelativo.ToString();

               // label11.Text = salida.Raiz.ToString();
               // label12.Text = salida.NroIteraciones.ToString();
                //label13.Text = salida.ErrorRelativo.ToString();

               
            }

           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void FormBiseccion_Load(object sender, EventArgs e)
        {

        }
    }
}

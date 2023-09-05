using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3_Ejercicio2_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int estrellas = int.Parse(txtb1.Text);
            int dias = int.Parse(txtb2.Text);

            switch (estrellas)
            {
                case 0:
                    if (dias > 0 && dias < 6)
                    {
                        int costo = dias * 100;
                        int desayuno = dias * 7;
                        int total = costo + desayuno;
                        lbl.Text = total.ToString() + " soles";
                    }
                    else if (dias > 5 && dias < 11)
                    {
                        int costo = dias * 85;
                        int desayuno = dias * 7;
                        int total = costo + desayuno;
                        lbl.Text = total.ToString() + " soles";
                    }
                    else if (dias > 11)
                    {
                        int costo = dias * 70;
                        int desayuno = dias * 7;
                        int total = costo + desayuno;
                        lbl.Text = total.ToString() + " soles";
                    }
                    break;

                case 1:
                    if (dias > 0 && dias < 6)
                    {
                        int costo = dias * 300;
                        int desayuno = dias * 7;
                        int total = costo + desayuno;
                        lbl.Text = total.ToString() + " soles";
                    }
                    else if (dias > 5 && dias < 11)
                    {
                        int costo = dias * 270;
                        int desayuno = dias * 7;
                        int total = costo + desayuno;
                        lbl.Text = total.ToString() + " soles";
                    }
                    else if (dias > 11)
                    {
                        int costo = dias * 250;
                        int desayuno = dias * 7;
                        int total = costo + desayuno;
                        lbl.Text = total.ToString() + " soles";
                    }
                    break;
            }

        }
    }
}

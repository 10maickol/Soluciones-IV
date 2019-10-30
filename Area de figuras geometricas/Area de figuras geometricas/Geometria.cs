using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Area_de_figuras_geometricas
{
    public partial class Geometria : Form
    {
        private bool isLado = true;
        public Geometria()
        {
            InitializeComponent();
            label_titile.Text = "Ingrese el valor del Lado";
        }

        private void rb_lado_CheckedChanged(object sender, EventArgs e)
        {
            isLado = true;
            label_titile.Text = "Ingrese el valor del Lado";
        }

        private void rb_radio_CheckedChanged(object sender, EventArgs e)
        {
            isLado = false;
            label_titile.Text = "Ingrese el valor del Radio";
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            String _val = txt_valor.Text;
            if (_val.Equals(""))
            {
                MessageBox.Show("ingrese un valor correcto");
            }
            else
            {
                
                Octogono oc = new Octogono("Octógono",Convert.ToDouble(_val), !isLado);
                txt_detalle.Text = oc.ToString();
                txt_resultado.Text = Math.Round(oc.CalcularArea(),3) + " m^2";

            }
        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double n = Convert.ToDouble(txt_valor.Text);
            }
            catch (Exception)
            {

                txt_valor.Text = "";
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            String valor1 = txtbase.Text;
            String valor2 = txtaltura.Text;

            if (valor1.Equals("")|| valor2.Equals(""))
            {
                MessageBox.Show("ingrese un valor correcto");
            }
            else
            {

                Romboide oc = new Romboide("Romboide", Convert.ToDouble(valor1), Convert.ToDouble(valor2));
                txtdetallearea.Text = oc.ToString();
                txtresultadoarea.Text = ""+oc.CalcularArea()+"m^2";

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

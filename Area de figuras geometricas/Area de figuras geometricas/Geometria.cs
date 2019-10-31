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

        private void txt_h_TextChanged(object sender, EventArgs e)
        {

            try
            {
                double n = Convert.ToDouble(txt_h.Text);
            }
            catch (Exception)
            {

                txt_h.Text = "";
            }
        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {

            try
            {
                double n = Convert.ToDouble(txt_a.Text);
            }
            catch (Exception)
            {

                txt_a.Text = "";
            }
        }

        private void txt_b_TextChanged(object sender, EventArgs e)
        {

            try
            {
                double n = Convert.ToDouble(txt_b.Text);
            }
            catch (Exception)
            {

                txt_b.Text = "";
            }
        }

        private void btn_calcular_trapecio_Click(object sender, EventArgs e)
        {
            String h = txt_h.Text;
            String a = txt_a.Text;
            String b = txt_b.Text;
            if (!h.Equals("")&& !a.Equals("")&& !b.Equals(""))
            {
                Trapecio tra = new Trapecio("Trapecio",Convert.ToDouble(h),Convert.ToDouble(a),Convert.ToDouble(b));
                label_desc.Text = tra.ToString();
                txt_result_tra.Text = Math.Round(tra.CalcularArea(), 3) + " m^2";
            }
            else
            {
                MessageBox.Show("Ingrese valores correctamente");
            }
            
        }
    }
}

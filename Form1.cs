using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Conversions
{
    public partial class Form1 : Form
        
    {
        Conversions objConversor = new Conversions();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnconvertir_Click_1(object sender, EventArgs e)
        {
            lblres.Text = Math.Round(objConversor.convertir
                (double.Parse(txtcantidad.Text), cbode.SelectedIndex, cboa.SelectedIndex, 1),2).ToString();
        }

        private void btnconvertir2_Click_1(object sender, EventArgs e)
        {
            lblres2.Text = Math.Round(objConversor.convertir
                (double.Parse(txtcantidad2.Text), cboa2.SelectedIndex, cbode2.SelectedIndex, 0), 2).ToString();
        }

        private void btnconvertir5_Click_1(object sender, EventArgs e)
        {
            lblres5.Text = Math.Round(objConversor.convertir(
                      double.Parse(txtcantidad5.Text), cboa5.SelectedIndex, cbode5.SelectedIndex, 2), 10).ToString();
        }

        private void btnconvertir4_Click(object sender, EventArgs e)
        {
            lblres4.Text = Math.Round(objConversor.convertir(
                      double.Parse(txtcantidad4.Text), cboa4.SelectedIndex, cbode4.SelectedIndex, 3), 10).ToString();
        }

        private void btncomvertir3_Click(object sender, EventArgs e)
        {
            lblres3.Text = Math.Round(objConversor.convertir(
                       double.Parse(txtcantidad3.Text), cboa3.SelectedIndex, cbode3.SelectedIndex, 4), 4).ToString();

        }
    }
}

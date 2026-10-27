using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryMedinaRepaso
{
    public partial class Calculo : Form
    {
        public Calculo()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            string monto;
            monto = txtMonto.Text;

            string interes;
            interes = cbxIVA.Text;

            decimal Monto = Convert.ToDecimal(txtMonto.Text);
            decimal Interes = Convert.ToDecimal(cbxIVA.Text);
            decimal Total = Monto * Interes;

            float resultado;
            resultado = (float)(Monto * Interes)/100;
            lblResultado.Text = "Resultado: " + resultado.ToString();



        }

        private void cbxIVA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

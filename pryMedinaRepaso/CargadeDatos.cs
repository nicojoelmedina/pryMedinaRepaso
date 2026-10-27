using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryMedinaRepaso
{
    public partial class CargadeDatos : Form
    {
        public CargadeDatos()
        {
            InitializeComponent();
        }

        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            int Codigo = Convert.ToInt32(txtCodigo.Text);
            string codigo;
            codigo = txtCodigo.Text;
            
            string nombre;
            nombre = txtNombre.Text;

            MessageBox.Show("Codigo: " + codigo + "\nNombre: " + nombre, "Datos Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

       
    }
}

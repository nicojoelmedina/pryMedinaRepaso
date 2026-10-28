using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryMedinaRepaso
{
    public partial class frmArray : Form
    {
        string[] VectorGrupoA = new string[4];
        string[] VectorGrupoB = new string[3];
        string[] VectorGrupoC = new string[3];
        public frmArray()
        {
            InitializeComponent();
        }


        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxGrupo.Text) 
            {
                case "Grupo A":
                    lstLista.Items.Clear();
                    lstLista.Items.Add("Cpu");
                    lstLista.Items.Add("Micro");
                    lstLista.Items.Add("Placa");
                    lstLista.Items.Add("Memoria");
                    break;
                case "Grupo B":
                    lstLista.Items.Clear();
                    lstLista.Items.Add("Visual");
                    lstLista.Items.Add("C#");
                    lstLista.Items.Add("Desktop");
                    break;
                case "Grupo C":
                    lstLista.Items.Clear();
                    lstLista.Items.Add("Server");
                    lstLista.Items.Add("Aws");
                    lstLista.Items.Add("Cloud");
                    break;

            }


        }

        private void frmArray_Load(object sender, EventArgs e)
        {
            cbxGrupo.Items.Add("Grupo A");
            cbxGrupo.Items.Add("Grupo B");
            cbxGrupo.Items.Add("Grupo C");

            VectorGrupoA[0] = "Cpu";
            VectorGrupoA[1] = "Micro";
            VectorGrupoA[2] = "Placa";
            VectorGrupoA[3] = "Memoria";

            for (int indice = 0; indice < VectorGrupoA.Length; indice++)
            {
                lstLista.Items.Add(VectorGrupoA[indice]);
            }

            VectorGrupoB[0] = "Visual";
            VectorGrupoB[1] = "C#";
            VectorGrupoB[2] = "Desktop";

            for (int indice = 0; indice < VectorGrupoB.Length; indice++)
            {
                lstLista.Items.Add(VectorGrupoB[indice]);
            }

            VectorGrupoC[0] = "Server";
            VectorGrupoC[1] = "Aws";
            VectorGrupoC[2] = "Cloud";

            for (int indice = 0; indice < VectorGrupoC.Length; indice++)
            {
                lstLista.Items.Add(VectorGrupoC[indice]);
            }

            cbxGrupo.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    }
}

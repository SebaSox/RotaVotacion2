using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotaVotacion2
{
    public partial class SistemaDeVotacion : Form
    {
        public SistemaDeVotacion()
        {
            InitializeComponent();
            TxtNumReu.Text = LblNumReu.Text;
        }

        private void BtnHabilitar_Click(object sender, EventArgs e)
        {
            HabilitarClubes Clubes = new HabilitarClubes();
            AddOwnedForm(Clubes);
            this.Hide();
            Clubes.ShowDialog();
            this.Show();
        }

        public void ActualizarTxtArea(List<string> Habilitados)
        {
            TxtClubesHabilitados.Text = "";
            int NumHabilitados= Habilitados.Count();
            LblClubesHabilitados.Text = NumHabilitados.ToString();
            int contador = 0;
            foreach (var item in Habilitados)
            {
                contador++;
                TxtClubesHabilitados.Text = TxtClubesHabilitados.Text + item; 
                    if (contador != NumHabilitados)
                {
                    TxtClubesHabilitados.Text = TxtClubesHabilitados.Text + ",  ";
                } 
            }
            //HabilitadosEnSistema.AddRange(Habilitados);
        }

        private void TxtNumReu_TextChanged(object sender, EventArgs e)
        {
            if (TxtNumReu.Text != null)
            {
                LblNumReu.Text = TxtNumReu.Text;
            }
            else
            {
                LblNumReu.Text = "0";
            }
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (TxtClubesHabilitados.Text != "")
            {
                if (TxtMocion.Text != "")
                {
                    //c.GenerarPregunta(Int32.Parse(LblNumReu.Text), TxtMocion.Text, TxtClubesHabilitados.Text);
                    Resultados Resul = new Resultados();
                    AddOwnedForm(Resul);
                    this.Hide();
                    Resul.LblTotales.Text = this.LblClubesHabilitados.Text;
                    Resul.ShowDialog();
                    TxtMocion.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tienes que escribir una pregunta previamente");
                }
            }
            else
            {
                MessageBox.Show("Tienes que seleccionar los clubes habilitados previamente");
            }
        }
    }
}

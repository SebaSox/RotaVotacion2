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
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
        }
        private void Resultados_Load(object sender, EventArgs e)
        {
            Temporizador.Start();
        }
        public int Contador = 0;
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Contador=Contador+1;
            ContadorDeVueltas.Text = Contador.ToString();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPausar_Click(object sender, EventArgs e)
        {
            Temporizador.Stop();
        }

        private void BtnReanudar_Click(object sender, EventArgs e)
        {
            Temporizador.Start();
        }
    }
}

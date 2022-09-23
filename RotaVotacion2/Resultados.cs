using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intermediario;


namespace RotaVotacion2
{
    public partial class Resultados : Form
    {
        IntermediarioCBD ICBD = new IntermediarioCBD();
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
            ActualizarResultados();

            if (LblTotales.Text == LblClubsYaVotados.Text)
            {
                Temporizador.Stop();
            }
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


        private void ActualizarResultados()
        {
            int Sumador = 0;
            int negativo = ICBD.ConsultarRespuestas(1);
            int Abstencion = ICBD.ConsultarRespuestas(2);
            int Positivo = ICBD.ConsultarRespuestas(3);
            Sumador = negativo + Abstencion + Positivo;
            LblClubsYaVotados.Text = Sumador.ToString();

            LblNegativo.Text = negativo.ToString();
            LblAbstencion.Text = Abstencion.ToString();
            LblPositivo.Text = Positivo.ToString();
        }
    }
}

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
    public partial class HabilitarClubes : Form
    {
        IntermediarioCBD ICBD = new IntermediarioCBD();
        public HabilitarClubes()
        {
            InitializeComponent();
            CargarChecks();
            
        }

        //Boton para cerrar sin pasar cambios
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //boton de confirmar y envia los datos
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            List<string> Habilitados = new List<string>();
            string tempo;

            for (int i = 0; i < Clubes_Habilitados.Items.Count; i++)
            {
                if (Clubes_Habilitados.GetItemChecked(i) == true)
                {
                    tempo = Clubes_Habilitados.Items[i].ToString();
                    Habilitados.Add(tempo);
                }
            }
            if (Habilitados.Count() == 0)
            {
                MessageBox.Show("Selecciona algun club antes de oprimir este boton");
            }
            else
            {
                if (ICBD.LimpiarClubesHabilitados()!=0)
                {
                    if (ICBD.CargarClubesHabilitados(Habilitados) != 0)
                    {
                        //el owner sirve para enviar datos al form padre
                        SistemaDeVotacion SisVot = Owner as SistemaDeVotacion;
                        SisVot.ActualizarTxtArea(Habilitados);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron cargar los campos de la tabla");
                    }
                }
                else
                {
                    MessageBox.Show("No se pudieron borrar los campos de la tabla");
                }

                

                
            }
        }






        //aca se encuentran los nombres de los clubes que hay que cargar
        private void CargarChecks()
        {

            //Carga los clubes que estan subidos y habilitados 
           
            foreach (var CheckClub in ICBD.ConsultarClubesHabilitados())
            {
                Clubes_Habilitados.Items.Add(CheckClub);
            }

        }
        //reiniciar los checks
        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            Clubes_Habilitados.Items.Clear();
            CargarChecks();
        }

        
    }
}

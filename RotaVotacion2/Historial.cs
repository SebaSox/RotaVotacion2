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
    public partial class Historial : Form
    {
        IntermediarioCBD ICBD = new IntermediarioCBD();
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            DGVPlanilla.DataSource= ICBD.HistorialMociones();
            TamañoDGV();
        }

        public void TamañoDGV()
        {
            this.DGVPlanilla.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

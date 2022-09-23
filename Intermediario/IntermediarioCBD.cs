using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos;
using System.Collections;


namespace Intermediario
{
    public class IntermediarioCBD
    {
        readonly ConeccionesBD CBD = new ConeccionesBD();

        //habilitar clubes
        public ArrayList ConsultarClubesHabilitados()
        {
            return CBD.ConsultarClubesHabilitados();
        }

        public int LimpiarClubesHabilitados()
        {
            return CBD.LimpiarClubesHabilitados();
        }

        public int CargarClubesHabilitados(List<string> Habilitados)
        {
            return CBD.CargarClubesHabilitados(Habilitados);
        }

        //Sistema de votacion

        public int CargarMocion(string Mocion, int NumReu)
        {
            return CBD.CargarMocion(Mocion, NumReu);
        }


        //Resultados

        public int ConsultarRespuestas(int NumVot)
        {
            return CBD.ConsultarRespuestas(NumVot);
        }

    }
}

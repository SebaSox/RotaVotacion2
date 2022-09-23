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
        ConeccionesBD CBD = new ConeccionesBD();
        public ArrayList ConsultarClubesHabilitados()
        {
            return CBD.ConsultarClubesHabilitados();
        }
    }
}

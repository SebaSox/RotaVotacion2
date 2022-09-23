using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace BaseDeDatos
{
    public class ConeccionesBD
    {
        static readonly string DatosConexion = "server= localhost; database=RotaVotacion;" 
            + "integrated security= true";
        readonly SqlConnection DCon = new SqlConnection(DatosConexion);


        //HabilitarClubes
        public ArrayList ConsultarClubesHabilitados()
        {
            ArrayList ResultadoArray = new ArrayList();            
            string Consulta = "SELECT NombreClub  FROM [RotaVotacion].[dbo].[Clubes] where EstadoGeneral = 1";
            SqlCommand cmd = new SqlCommand(Consulta, DCon);
            //asi es como putas imprimo un puto arraylist
            try
            {
                DCon.Open();
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    ResultadoArray.Add(data["NombreClub"].ToString());
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                DCon.Close();
            }
            return ResultadoArray;
        } 

        public int LimpiarClubesHabilitados()
        {
            int bandera = 0;
            string consulta = "UPDATE[dbo].[Clubes] SET [EstadoReunion] = 0 WHERE [EstadoReunion] = 1";
            DCon.Open();
            SqlCommand cmd = new SqlCommand(consulta, DCon);
            bandera = cmd.ExecuteNonQuery();
            DCon.Close();
            return bandera;
        }

        public int CargarClubesHabilitados(List<string> Habilitados)
        {
            int bandera = 0;
            foreach (var item in Habilitados)
            {
                string consulta = "UPDATE[dbo].[Clubes] SET[EstadoReunion] = 1 WHERE[NombreClub] = '" + item + "'";
                DCon.Open();
                SqlCommand cmd = new SqlCommand(consulta, DCon);
                bandera = cmd.ExecuteNonQuery();
                DCon.Close();
            }
            

            return bandera;
        }



        //SistemaDeVotacion
        public int CargarMocion(string Mocion, int NumReu)
        {
            var bandera = 0;
            string consulta = "INSERT INTO [dbo].[Mocion]([Mocion],[Fecha],[NumReu])VALUES ('" + Mocion+"', "+ "'"+
                DateTime.Now.ToString("dd-MM-yyyy") + "',"+ NumReu + ")";
            DCon.Open();
            SqlCommand cmd = new SqlCommand(consulta, DCon);
            bandera = cmd.ExecuteNonQuery();
            DCon.Close();
            return bandera;
        }

        //Resultados

        public int TraerUltimaMocion()
        {
            int UltiMocion = 0;
            string Consulta = "SELECT MAX(Id) as UltimaMocion FROM[RotaVotacion].[dbo].[Mocion]";
            SqlCommand cmd = new SqlCommand(Consulta, DCon);
            DCon.Open();
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                UltiMocion = Int32.Parse(data["UltimaMocion"].ToString());
            }

            DCon.Close();
            return UltiMocion;
        }

        public int ConsultarRespuestas(int NumVot) //El que va
        {
            int CantidadVotos = 0;
            string Consulta = "SELECT COUNT(voto) as CantVotos " +
                "FROM[RotaVotacion].[dbo].[Respuestas] WHERE Voto = " + NumVot + "and [IdMocion] =" + TraerUltimaMocion();
            SqlCommand cmd = new SqlCommand(Consulta, DCon);
            DCon.Open();
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                CantidadVotos = Int32.Parse(data["CantVotos"].ToString());
            }

            DCon.Close();
            return CantidadVotos;
        } 




        //public int ConsultarRespuestas(int NumVot)
        //{
        //    int CantidadVotos = 0;
        //    string Consulta = "SELECT COUNT(voto) as CantVotos " +
        //        "FROM[RotaVotacion].[dbo].[Respuestas] WHERE Voto = " + NumVot + "and [IdMocion] =" + 4;
        //    SqlCommand cmd = new SqlCommand(Consulta, DCon);
        //    DCon.Open();
        //    SqlDataReader data = cmd.ExecuteReader();
        //    if (data.Read())
        //    {
        //        CantidadVotos = Int32.Parse(data["CantVotos"].ToString());
        //    }

        //    DCon.Close();
        //    return CantidadVotos;
        //}


    }
}

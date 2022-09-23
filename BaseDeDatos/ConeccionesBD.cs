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
        static string DatosConexion = "server= localhost; database=RotaVotacion;" 
            + "integrated security= true";
        SqlConnection DCon = new SqlConnection(DatosConexion);



        public ArrayList ConsultarClubesHabilitados()
        {
            ArrayList ResultadoArray = new ArrayList();            
            string Consulta = "SELECT NombreClub  FROM [RotaVotacion].[dbo].[Clubes] where Estado = 1";
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



    }
}

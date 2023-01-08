using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class DiscosDatos
    {
       public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Estilo, ED.Descripcion TipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION ED where E.Id = D.IdEstilo and ED.Id = D.IdTipoEdicion";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantCanciones = lector.GetInt32(2);
                    aux.UrlImagen = (string)lector["UrlImagenTapa"];

                    aux.Style = new Estilo();
                    aux.Style.Descripcion = (string)lector["Estilo"];

                    aux.TipoEdicion = new Edicion();
                    aux.TipoEdicion.Descripcion = (string)lector["TipoEdicion"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
    }
}

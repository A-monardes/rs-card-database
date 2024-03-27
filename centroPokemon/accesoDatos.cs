using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace centroPokemon
{
    //accesoDatos encapsula los pasos necesarios, en forma de objetos, para conectarse a la base de datos SQL y leer sus datos. Lector simplemente toma y devuelve el valor leido por el reader de SQL. accesoDatos() es la estructura que pide la conexion de SQL con su conexion. setConsulta determina el tipo de comando y de texto que va a tomar de SQL y cuando se le invoque, dentro de un try, habria que pasarle la dirección de la base de datos SQL. EjecutarLectura tambien va dentro del try y justamente utiliza el lector de SQL para leer los datos. Por ultimo, cerrarConexion, efectivamente, cierra la conexion y tambíen cierra la lectura si esta tuviese un valor nulo.
    public class accesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public accesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=POKEMON_CARD; integrated security=true");
            comando = new SqlCommand();
        }
        public void setConsulta (string consulta) 
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void EjecutarLectura()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void cerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominion;

//Lo que hicimos acá fue crear una clase que lea los datos necesarios para los elementos, donde varios objetos de los que utilizamos se toman de accesoDatos, que ya tiene cargado el codigo para realizar los pasos necesarios de lectura de datos de SQL sin tener que hacerlo en cada clase cada vez que se necesite, de la manera más general posible

namespace centroPokemon
{
    internal class centroElementos
    {
        public List<Elementos> ListarElementos() 
        {
			List<Elementos> lista = new List<Elementos>();
			accesoDatos datos = new accesoDatos();

			try
			{
				datos.setConsulta("select Id, Descripcion from POKEMONS");
				datos.EjecutarLectura();

				while (datos.Lector.Read())
				{		
					Elementos aux = new Elementos();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion = (string)datos.Lector["Description"];

					lista.Add(aux);
				}

				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
        }
    }
}

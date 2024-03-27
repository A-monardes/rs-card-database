using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominion;

namespace centroPokemon
{
    public class CentroDeCartas
    {
        public List<CartaPokemon> Listar()
        {
            List<CartaPokemon> lista = new List<CartaPokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
            conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEMON_CARD; integrated security=true";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select Numero, Nombre, HP, UrlImagen, E.Descripcion as Tipo, D.Descripcion as Debilidad, R.Descripcion as Resistencia, Retirada, Artista, Costo1, Titulo1, Dano1, Ataque1, Costo2, Titulo2, Dano2, Ataque2, Costo3, Titulo3, Dano3, Ataque3, PowerTitulo, PokePower, BodyTitulo, PokeBody from POKEMONS, ELEMENTOS E, ELEMENTOS D , ELEMENTOS R, ATAQUES A where IdTipo = E.Id and IdDebilidad = D.Id and IdResistencia = R.Id and Numero = A.Id";

            comando.Connection = conexion;
            conexion.Open();
            lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    CartaPokemon p = new CartaPokemon();
                    p.Numero = lector.GetInt32(0);
                    p.Nombre = (string)lector["Nombre"];
                    p.HP = (int)lector["HP"];
                    p.UrlImagen = (string)lector["UrlImagen"];
                    p.Tipo = new Elementos();
                    p.Tipo.Descripcion = (string)lector["Tipo"];
                    p.Debilidad = new Elementos();
                    p.Debilidad.Descripcion = (string)lector["Debilidad"];
                    p.Resistencia = new Elementos();
                    p.Resistencia.Descripcion = (string)lector["Resistencia"];
                    p.Retirada = (string)lector["Retirada"];
                    p.Artista = (string)lector["Artista"];
                    p.Costo1 = (string)lector["Costo1"];
                    p.Titulo1 = (string)lector["Titulo1"];
                    p.Dano1 = (string)lector["Dano1"];
                    p.Ataque1 = (string)lector["Ataque1"];
                    p.Costo2 = (string)lector["Costo2"];
                    p.Titulo2 = (string)lector["Titulo2"];
                    p.Dano2 = (string)lector["Dano2"];
                    p.Ataque2 = (string)lector["Ataque2"];
                    p.Costo3 = (string)lector["Costo3"];
                    p.Titulo3 = (string)lector["Titulo3"];
                    p.Dano3 = (string)lector["Dano3"];
                    p.Ataque3 = (string)lector["Ataque3"];
                    p.PowerTitulo = (string)lector["PowerTitulo"];
                    p.PokePower = (string)lector["PokePower"];
                    p.BodyTitulo = (string)lector["BodyTitulo"];
                    p.PokeBody = (string)lector["PokeBody"];

                    lista.Add(p);
                }
                conexion.Close();

                return lista;
            }

            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

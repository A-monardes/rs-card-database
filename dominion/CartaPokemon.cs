using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominion
{
    public class CartaPokemon
    {
        [DisplayName("Número")]
        public int Numero {  get; set; }
        public string Nombre { get; set; }
        public int HP { get; set; }
        public string UrlImagen { get; set; }
        public string Retirada { get; set; }

        public Elementos Tipo { get; set; }
        public Elementos Debilidad { get; set; }

        public Elementos Resistencia { get; set; }
        public string Artista { get; set; }
        public string Costo1 { get; set; }
        public string Titulo1 { get; set; }
        public string Dano1 { get; set; }
        public string Ataque1 { get; set; }
        public string Costo2 { get; set;}
        public string Titulo2 { get; set;}
        public string Dano2 { get; set;}
        public string Ataque2 { get; set;}
        public string Costo3 { get; set;}
        public string Titulo3 { get;set;}
        public string Dano3 { get; set;}
        public string Ataque3 { get; set;}
        public string PowerTitulo {  get; set;}
        public string PokePower {  get; set;}
        public string BodyTitulo { get; set;}
        public string PokeBody {  get; set;}

    }
}

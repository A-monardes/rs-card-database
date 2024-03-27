using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominion;
using centroPokemon;

namespace Pokemon_Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CargaDeImagen(string imagen)
        {
            try
            {
                picboxCarta.Load(imagen);
            }
            catch (Exception)
            {
                picboxCarta.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/No-Image-Placeholder.svg/1665px-No-Image-Placeholder.svg.png");
                
            }
        }

        private void Ocultar()
        {
            dgvCartas.Columns["UrlImagen"].Visible = false;
            dgvCartas.Columns["Costo1"].Visible = false;
            dgvCartas.Columns["Titulo1"].Visible = false;
            dgvCartas.Columns["Dano1"].Visible = false;
            dgvCartas.Columns["Ataque1"].Visible = false;
            dgvCartas.Columns["Costo2"].Visible = false;
            dgvCartas.Columns["Titulo2"].Visible = false;
            dgvCartas.Columns["Dano2"].Visible = false;
            dgvCartas.Columns["Ataque2"].Visible = false;
            dgvCartas.Columns["Costo3"].Visible = false;
            dgvCartas.Columns["Titulo3"].Visible = false;
            dgvCartas.Columns["Dano3"].Visible = false;
            dgvCartas.Columns["Ataque3"].Visible = false;
            dgvCartas.Columns["PowerTitulo"].Visible = false;
            dgvCartas.Columns["PokePower"].Visible = false;
            dgvCartas.Columns["BodyTitulo"].Visible = false;
            dgvCartas.Columns["PokeBody"].Visible = false;

        }

        private List<CartaPokemon> pokemonList;
        private void Form1_Load(object sender, EventArgs e)
        {
            CentroDeCartas pokemon = new CentroDeCartas();
            pokemonList = pokemon.Listar();
            dgvCartas.DataSource = pokemonList;

            Ocultar();

            CargaDeImagen(pokemonList[0].UrlImagen);

            dgvCartas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            CargarAtaque(0);

        }

        private void dgvCartas_SelectionChanged(object sender, EventArgs e)
        {
            CartaPokemon pokemonActual = (CartaPokemon)dgvCartas.CurrentRow.DataBoundItem;
            CargaDeImagen(pokemonActual.UrlImagen);
            CargarAtaque(pokemonActual.Numero-1);
        }

        private void CargarAtaque(int ataques) 
        {
            lblCosto1.Text = pokemonList[ataques].Costo1;
            lblTitulo1.Text = pokemonList[ataques].Titulo1;
            lblDano1.Text = pokemonList[ataques].Dano1;
            lblAtaque1Text.Text = pokemonList[ataques].Ataque1;
            lblCosto2.Text = pokemonList[ataques].Costo2;
            lblTitulo2.Text = pokemonList[ataques].Titulo2;
            lblDano2.Text = pokemonList[ataques].Dano2;
            lblAtaque2Text.Text = pokemonList[ataques].Ataque2;
            lblCosto3.Text = pokemonList[ataques].Costo3;
            lblTitulo3.Text = pokemonList[ataques].Titulo3;
            lblDano3.Text = pokemonList[ataques].Dano3;
            lblAtaque3Text.Text = pokemonList[ataques].Ataque3;
            lblPowerTitulo.Text = pokemonList[ataques].PowerTitulo;
            lblPowerText.Text = pokemonList[ataques].PokePower;
            lblBodyTitulo.Text = pokemonList[ataques].BodyTitulo;
            lblBodyText.Text = pokemonList[ataques].PokeBody;

            if (lblBodyTitulo.Text == " ")
            {
                lblBody.Visible = false;
                lblBodyTitulo.Visible = false;
                lblBodyText.Visible = false;
            }
            else
            {
                lblBody.Visible = true;
                lblBodyTitulo.Visible = true;
                lblBodyText.Visible = true;
            }
            if (lblPowerTitulo.Text == " ")
            {
                lblPower.Visible = false;
                lblPowerText.Visible = false;
                lblPowerTitulo.Visible = false;
            }
            else
            {
                lblPower.Visible = true;
                lblPowerText.Visible = true;
                lblPowerTitulo.Visible = true;
            }
            if (lblAtaque1Text.Height > 70)
            {

                lblTitulo2.Visible = false;
                lblCosto2.Visible = false;
                lblDano2.Visible = false;
                lblAtaque2Text.Visible = false;
                //lblAtaque1Text.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
            }
            else
            {
                lblTitulo2.Visible = true;
                lblCosto2.Visible = true;
                lblDano2.Visible = true;
                lblAtaque2Text.Visible = true;
            }
        }
    }
}

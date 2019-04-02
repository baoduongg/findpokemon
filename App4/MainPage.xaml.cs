using Poke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var sttpoke = int.Parse(txtpokemon.Text);
            var pokemon = new Pokedex();
            lbten.Text = pokemon.GetPokemonName(sttpoke);
            imgpoke.Source = ImageSource.FromUri(new Uri(pokemon.GetPokemonImageUrl(sttpoke)));



        }


    }
}

using Newtonsoft.Json;
using RestSharp;
using System.Globalization;
using Tomagochi.Menus;

namespace Tomagochi{
    internal class Dex{
        public static void MonstrarPokemonInfo(string pokemon){
            Console.Clear();
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokemon}");
            var request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Menu.Linha();

                Pokemon pokectmonster = JsonConvert.DeserializeObject<Pokemon>(response.Content);

                var nome = AplicarTitleCase(pokectmonster.Name);
                Console.WriteLine($"Nome: {nome}");

                AlturaEPeso(pokectmonster);

                Escrever("Tipo: ");
                foreach (var type in pokectmonster.Types)
                {
                    var typeName = AplicarTitleCase(type.Type.Name);
                    Console.WriteLine(typeName);
                }

                Escrever("Habilidades: ");
                foreach (var ability in pokectmonster.Abilities)
                {
                    var abilityName = AplicarTitleCase(ability.Ability.Name);
                    Console.WriteLine(abilityName);
                }

                Escrever("Status: ");
                foreach (var stat in pokectmonster.Stats)
                {
                    var statName = AplicarTitleCase(stat.Stat.Name);
                    Console.WriteLine($"{statName}: {stat.Base_stat}");
                }
                Menu.Linha();
            }
            else
            {
                Escrever($"Sorry Dave. I did not found this Pokemon. You can try again.");
                MainMenu.Show();
            }
        }

        private static void AlturaEPeso(Pokemon pokectmonster)
        {
            Console.WriteLine();
            Console.WriteLine($"Peso: {pokectmonster.Weight}");
            Console.WriteLine($"Altura: {pokectmonster.Height}");
        }

        public static void Escrever(string mensagem){
            Console.WriteLine("");
            Console.WriteLine(mensagem);
        }

        public static string PegarNomeDoPokemon(){
            Console.Clear();
            Console.WriteLine("Qual o nome do Pokemon?");
            var pokemon = Console.ReadLine();
            return pokemon.ToLower();
        }

        public static string AplicarTitleCase(string text){
            CultureInfo cultura = CultureInfo.CurrentCulture;
            return cultura.TextInfo.ToTitleCase(text);
        }
    }
}

using Newtonsoft.Json;
using RestSharp;
using Tomagochi.Menus;

namespace Tomagochi{
    internal class Dex{

        public static Pokemon PegarPokemonInfo(string pokemon){
            Pokemon newPokemon = new();
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokemon.ToLower()}");
            var request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK){
                newPokemon = JsonConvert.DeserializeObject<Pokemon>(response.Content);
            }else{
                Console.WriteLine("Erro - Não encontrado.");
            }
            return newPokemon;
        }

        public static void EscreverPokemonInfo(Pokemon pokemon){
            MenuLib.Linha();

            MenuLib.MenuHeader($"{MenuLib.TitleCase(pokemon.Name)}");
            Console.Write($"Tipo: ");

            foreach(var hab in pokemon.Types){
                //Garante a primeira letra maiuscula
                var text = MenuLib.TitleCase(hab.Type.Name.Trim('-'));

                if(text.Length > 1){
                    foreach(var t in text){
                        if(t == '-'){
                            Console.Write($" ");
                            continue;
                        }
                        Console.Write($"{t}");
                    }
                }

                //Se não for a ultima habilidade adiciona uma virgula
                if(hab.Type.Name != pokemon.Types[pokemon.Types.Count()-1].Type.Name){
                    Console.Write($", ");
                }
            }
            Console.Write($".");
            Console.WriteLine(" ");

            Console.WriteLine($"Altura: {pokemon.Height}");
            Console.WriteLine($"Peso: {pokemon.Weight}");
            Console.WriteLine("Habilidades:");

            foreach(var hab in pokemon.Abilities){
                //Garante a primeira letra maiuscula
                var text = MenuLib.TitleCase(hab.Ability.Name.Trim('-'));

                if(text.Length > 1){
                    foreach(var t in text){
                        if(t == '-'){
                            Console.Write($" ");
                            continue;
                        }
                        Console.Write($"{t}");
                    }
                }

                //Se não for a ultima habilidade adiciona uma virgula
                if(hab.Ability.Name != pokemon.Abilities[pokemon.Abilities.Count()-1].Ability.Name){
                    Console.Write($", ");
                }
            }
            Console.Write($".");
            Console.WriteLine($" ");
            MenuLib.Linha();
        }

        public static string PegarNomeDoPokemon(){
            Console.Clear();
            Console.WriteLine("Qual o nome do Pokemon que deseja informações?");
            var pokemon = Console.ReadLine();
            return pokemon.ToLower();
        }
    }
}

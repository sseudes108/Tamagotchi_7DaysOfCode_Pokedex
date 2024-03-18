using Tomagochi.Menus;
using Tomagochi.Model;

namespace Tomagochi;
internal class Mascotes{
    public static List<Pokemon> mascotes = new();

    public static void AddMascote(Pokemon pokemon){
        var rand = new Random();
        pokemon.Alimentacao = rand.Next(10);
        pokemon.Humor = rand.Next(10);
        pokemon.Sono = rand.Next(10);
        Console.WriteLine($"{TomagochiLib.TitleCase(pokemon.Name)} adicionado para seus mascotes...");
        mascotes.Add(pokemon);
    }

    public static void MostrarInfoDoMascote(Pokemon pokemon){
        TomagochiLib.LimparTela();
        Console.WriteLine($"{TomagochiLib.TitleCase(pokemon.Name)}");

        Console.WriteLine($"Altura: {(float)pokemon.Height / 10} m.");
        Console.WriteLine($"Peso: {(float)pokemon.Weight / 10} Kg.");

        TomagochiLib.PularLinha();
        if (pokemon.Alimentacao >= 7){
            Console.WriteLine($"{TomagochiLib.TitleCase(pokemon.Name)} está sem fome");
        }else if(pokemon.Alimentacao < 7 && pokemon.Alimentacao > 4){
            Console.WriteLine($"{TomagochiLib.TitleCase(pokemon.Name)} está com fome");
        }
        else{
            Console.WriteLine($"{TomagochiLib.TitleCase(pokemon.Name)} está com muita fome");
        }

        if (pokemon.Humor >= 7){
            Console.WriteLine($"está muito feliz");
        }
        else if (pokemon.Humor < 7 && pokemon.Humor > 4){
            Console.WriteLine($"está feliz");
        }else{
            Console.WriteLine($"está triste");
        }

        if (pokemon.Sono >= 7){
            Console.WriteLine($"está sem sono");
        }
        else if (pokemon.Sono < 7 && pokemon.Sono > 4){
            Console.WriteLine($"está com sono");
        }else{
            Console.WriteLine($"está com muito sono");
        }

        TomagochiLib.PularLinha();
        Console.Write("Habilidades: ");
        foreach (var hab in pokemon.Abilities){
            //Garante a primeira letra maiuscula
            var text = TomagochiLib.TitleCase(hab.Ability.Name.Trim('-'));

            if (text.Length > 1){
                foreach (var t in text){
                    if (t == '-'){
                        Console.Write($" ");
                        continue;
                    }
                    Console.Write($"{t}");
                }
            }

            //Se não for a ultima habilidade adiciona uma virgula
            if (hab.Ability.Name != pokemon.Abilities[pokemon.Abilities.Count() - 1].Ability.Name){
                Console.Write($", ");
            }
        }
    }
}
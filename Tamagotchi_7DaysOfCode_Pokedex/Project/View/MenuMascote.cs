using Tomagochi.Model;

namespace Tomagochi.Menus;

internal class MenuMascotes{
    static Pokemon? _pokemon;
    static string? _pokemonNome;
    static string? _nome;

    public static void Show(Pokemon pokemon, string nome){
        TomagochiLib.LimparTela();
        
        _nome = nome;
        _pokemon = pokemon;
        _pokemonNome = TomagochiLib.TitleCase(pokemon.Name);

        TomagochiLib.Header($"{_pokemonNome}");
        TomagochiLib.PularLinha();

        TomagochiLib.MenuItem($"1 - Saber como {_pokemonNome} está");
        TomagochiLib.MenuItem($"2 - Alimentar");
        TomagochiLib.MenuItem($"3 - Brincar com {_pokemonNome}");
        TomagochiLib.MenuItem($"4 - Colorar {_pokemonNome} para dormir");
        TomagochiLib.PularLinha();
        
        TomagochiLib.MenuItem($"0 - Voltar");
        TomagochiLib.Linha();

        var selecao = TomagochiLib.ReceberSelecao();
        switch(selecao){
            case 1:
                MostrarInfoDoMascote(pokemon);
            break;

            case 2:
                Atividades.Alimentar(pokemon);

                MostrarInfoDoMascote(pokemon);
            break;

            case 3:
                Atividades.Brincar(pokemon);

                MostrarInfoDoMascote(pokemon);
            break;

            case 4:
                Atividades.ColocarParaDormir(pokemon);

                MostrarInfoDoMascote(pokemon);
            break;

            case 0:
                TomagochiLib.RetornarAoMenuInicial(_nome);
            break;
        }
    }

    public static void MostrarInfoDoMascote(Pokemon pokemon){
        Mascotes.MostrarInfoDoMascote(pokemon);
        TomagochiLib.PularLinha();
        TomagochiLib.Linha();

        TomagochiLib.PularLinha();
        Console.WriteLine("Pressione qualquer tecla para retornar...");
        Console.ReadKey();

        Show(_pokemon, _nome);
    }
}
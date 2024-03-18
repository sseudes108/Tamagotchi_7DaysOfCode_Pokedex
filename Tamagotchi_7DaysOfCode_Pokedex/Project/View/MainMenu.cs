using System.Xml.Schema;

namespace Tomagochi.Menus;
internal class MainMenu{
    static string? _nome;
    public static void Show(string nome){
        _nome = nome;
        TomagochiLib.Header("Menu");

        Console.WriteLine($"{_nome}, o que você deseja fazer?");
        Console.WriteLine($" ");

        TomagochiLib.MenuItem("1 - Adotar Um Mascote Virtual");
        TomagochiLib.MenuItem("2 - Ver Seus Mascotes");
        TomagochiLib.MenuItem("3 - Pokédex");
        Console.WriteLine($" ");

        TomagochiLib.MenuItem("0 - Sair");

        TomagochiLib.Linha();

        var selecao = TomagochiLib.ReceberSelecao();

        switch(selecao){
            case 1:
                Adotar.Show(_nome);
            break;

            case 2:
                if(Mascotes.mascotes.Count != 0){
                    TomagochiLib.LimparTela();
                    
                    var index = 0;
                    foreach(var mascote in Mascotes.mascotes){
                        Console.WriteLine($"{index + 1} - {TomagochiLib.TitleCase(mascote.Name)}");
                        index++;
                    }
                    TomagochiLib.Linha();
                    
                    Console.WriteLine($"{_nome}, selecione o mascote...");
                    var selected = TomagochiLib.ReceberSelecao();
                    MenuMascotes.Show(Mascotes.mascotes[selected - 1], _nome);
                }else{
                    TomagochiLib.Notificacao("Você não tem nenhum mascote");
                    TomagochiLib.RetornarAoMenuInicial(_nome);
                }

            break;

            case 3:
                TomagochiLib.Header("Pokédex");

                var pokemonName = Dex.PegarNomeDoPokemon();
                var pokemon = Dex.PegarPokemonInfo(pokemonName);
                if(pokemon != null){
                    Dex.EscreverPokemonInfo(pokemon);
                }
                
                TomagochiLib.RetornarAoMenuInicial(_nome);
            break;

            case 0:
                TomagochiLib.Sair(_nome);
            break;
        }
    }
}

namespace Tomagochi.Menus;

internal class Adotar{
    static string? _nome;
    static string? _pokemon;
    public static void Show(string nome){
        _nome = nome;
        TomagochiLib.Header("Adotar Um Mascote");

        Console.WriteLine($"{_nome}, escolha uma Espécie:");
        Console.WriteLine($" ");

        TomagochiLib.MenuItem("1 - Staryu");
        TomagochiLib.MenuItem("2 - Zubat");
        TomagochiLib.MenuItem("3 - Abra");
        Console.WriteLine($" ");

        TomagochiLib.MenuItem("0 - Voltar");

        TomagochiLib.Linha();

        var selecao = TomagochiLib.ReceberSelecao();

        switch(selecao){
            case 1:
                _pokemon = "Staryu";
            break;

            case 2:
                _pokemon = "Zubat";
            break;

            case 3:
                _pokemon = "Abra";
            break;
            default:
                MainMenu.Show(_nome);
            break;
        }
        PokemonSelecionado();
    }

    public static void PokemonSelecionado(){
        Console.Clear();
        TomagochiLib.Linha();

        Console.WriteLine($"{_nome}, O que deseja?:");
        Console.WriteLine($" ");

        TomagochiLib.MenuItem($"1 - Saber mais sobre {_pokemon}");
        TomagochiLib.MenuItem($"2 - Adotar {_pokemon}");
        Console.WriteLine($" ");
        
        TomagochiLib.MenuItem($"3 - Voltar");

        TomagochiLib.Linha();


        var selecao = TomagochiLib.ReceberSelecao();

        switch(selecao){
            case 1:
                Console.Clear();

                var pokemon = Dex.PegarPokemonInfo(_pokemon);
                Dex.EscreverPokemonInfo(pokemon);

                Console.WriteLine(" ");
                Console.WriteLine("\nPressione qualquer tecla para retornar...");
                Console.ReadKey();
                PokemonSelecionado();
            break;

            case 2:
                AdotarPokemon();
            break;

            case 3:
                Show(_nome);
            break;
        }
    }
    public static void AdotarPokemon(){
        Console.Clear();
        TomagochiLib.Linha();

        Console.WriteLine($"{_nome}, {_pokemon} adotado com sucesso. Seu ovo está chocando");
        Console.WriteLine(@"              
                      ......                      
                   ..######*:                     
                  .#@-....:+@*-                   
                 -@+.   ..::-#@+                  
               .*+:    .....:*#%#-                
               %-     .....::**#%@=               
             -##-      ....::*#####=              
             =%        .....:+*###%+              
            -%%      .+%@@+::*#####@+             
            -%#++++++@*:..#%*%#%%%%@+             
            -%@@@@@@@@=...=@@@@@@@@@+             
            :#%      *%@@@%*:**####%=             
             =@:      .:::..:*####%+              
             ..%-     ....:-****#%=.              
               .*+-.. .....=###@#-                
        ...      -=##..::=*#@@@#==-:              
         .. ..:.. .:+@@@@@@@@@@@@@@@@@@#:.        
       ..::.::  ...--=#%%@@@@@@@@@@@%%+=. ..      
                 ..:......:..=.:.:...              
        ");

        TomagochiLib.Linha();

        TomagochiLib.RetornarAoMenuInicial(_nome);
    }
}
namespace Tomagochi.Menus;

internal class Adotar{
    static string? _nome;
    static string? _pokemon;
    public static void Show(string nome){
        _nome = nome;
        MenuLib.MenuHeader("Adotar Um Mascote");

        Console.WriteLine($"{_nome}, escolha uma Espécie:");
        MenuLib.MenuItem("1 - Staryu");
        MenuLib.MenuItem("2 - Zubat");
        MenuLib.MenuItem("3 - Abra");
        MenuLib.MenuItem("0 - Voltar");

        MenuLib.Linha();

        var selecao = MenuLib.ReceberSelecao();

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
        MenuLib.Linha();

        Console.WriteLine($"{_nome}, O que deseja?:");
        MenuLib.MenuItem($"1 - Saber mais sobre {_pokemon}");
        MenuLib.MenuItem($"2 - Adotar {_pokemon}");
        MenuLib.MenuItem($"3 - Voltar");

        MenuLib.Linha();


        var selecao = MenuLib.ReceberSelecao();

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
    public static void AdotarPokemon()
    {
        Console.Clear();
        MenuLib.Linha();

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

        MenuLib.Linha();

        MenuLib.RetornarAoMenuInicial(_nome);
    }
}
namespace Tomagochi7DaysOfCode.Menus;

internal class MenuSelecaoPokemon{

    public static void Show(){
        Menu.MenuHeader("Seleção de Pokémon");
        Console.WriteLine("1 - Zubat");
        Console.WriteLine("2 - Bulbasaur");
        Console.WriteLine("3 - Charmander");
        Console.WriteLine("4 - Squirtle");
        Console.WriteLine("5 - Chikorita");
        Console.WriteLine("0 - Menu Principal");
        Menu.Linha();

        var entrada = Menu.ReceberSelecao();

        switch (entrada)
        {
            case 1:
                Dex.MonstrarPokemonInfo("zubat");
                RemostrarMenu();
                break;
            case 2:
                Dex.MonstrarPokemonInfo("bulbasaur");
                RemostrarMenu();
                break;
            case 3:
                Dex.MonstrarPokemonInfo("charmander");
                RemostrarMenu();
                break;
            case 4:
                Dex.MonstrarPokemonInfo("squirtle");
                RemostrarMenu();
                break;
            case 5:
                Dex.MonstrarPokemonInfo("chikorita");
                RemostrarMenu();
                break;
            case 0:
                MainMenu.Show();
                break;
            default:
                Console.WriteLine("I don't understand you, Dave");
                break;
        }
    }
    private static void RemostrarMenu()
    {
        Thread.Sleep(1500);
        Console.WriteLine("Pressione qualquer tecla...");
        Console.ReadKey();
        Show();
    }
}

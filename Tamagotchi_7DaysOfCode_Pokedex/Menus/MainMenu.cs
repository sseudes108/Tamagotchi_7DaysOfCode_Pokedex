using Tomagochi7DaysOfCode.Menus;

namespace Tomagochi7DaysOfCode{
    internal class MainMenu{
        public static void Show(){
            Menu.MenuHeader("Menu Principal");
            Console.WriteLine("1 - Pokédex");
            Console.WriteLine("2 - Selecionar Pokémon");
            Console.WriteLine("0 - Sair");
            Menu.Linha();

            var entrada = Menu.ReceberSelecao();

            switch(entrada)
            {
                case 1:
                    var inputPokemon = Dex.PegarNomeDoPokemon();
                    Dex.MonstrarPokemonInfo(inputPokemon);
                    RemostrarMenu();
                break;

                case 2:
                    MenuSelecaoPokemon.Show();
                break;

                case 0:
                    Environment.Exit(0);
                break;

                default:
                    Show();
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
}

namespace Tomagochi.Menus;
    internal class MainMenu{
        static string? _nome;
        public static void Show(string nome){
            _nome = nome;
            MenuLib.MenuHeader("Menu");

            Console.WriteLine($"{_nome}, o que você deseja fazer?");
            Console.WriteLine($" ");

            MenuLib.MenuItem("1 - Adotar Um Mascote Virtual");
            MenuLib.MenuItem("2 - Ver Seus Mascotes");
            MenuLib.MenuItem("3 - Pokédex");
            MenuLib.MenuItem("0 - Sair");

            MenuLib.Linha();

            var selecao = MenuLib.ReceberSelecao();

            switch(selecao){
                case 1:
                    Adotar.Show(_nome);
                break;

                case 2:
                break;

                case 3:
                    MenuLib.MenuHeader("Pokédex");
                    
                    var pokemonName = Dex.PegarNomeDoPokemon();
                    var pokemon = Dex.PegarPokemonInfo(pokemonName);
                    Dex.EscreverPokemonInfo(pokemon);

                    MenuLib.RetornarAoMenuInicial(_nome);
                break;

                case 0:
                    MenuLib.Sair(_nome);
                break;
            }
        }
    }

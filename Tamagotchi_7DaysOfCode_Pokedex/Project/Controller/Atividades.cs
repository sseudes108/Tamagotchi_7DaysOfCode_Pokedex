namespace Tomagochi;

using Tomagochi.Menus;
using Tomagochi.Model;

internal class Atividades{
    public static void Brincar(Pokemon pokemon){
        Console.WriteLine($"Brincando {TomagochiLib.TitleCase(pokemon.Name)}");
        Thread.Sleep(2000);

        pokemon.Humor ++;
        pokemon.Alimentacao--;

        TomagochiLib.PularLinha();
    }

    public static void Alimentar(Pokemon pokemon){
        Console.WriteLine($"Alimentando {TomagochiLib.TitleCase(pokemon.Name)}");
        Thread.Sleep(2000);

        pokemon.Humor++;
        pokemon.Alimentacao++;
        pokemon.Sono--;

        TomagochiLib.PularLinha();
    }

    public static void ColocarParaDormir(Pokemon pokemon){
        Console.WriteLine($"Colocando {TomagochiLib.TitleCase(pokemon.Name)} para dormir.");
        Thread.Sleep(2000);

        pokemon.Alimentacao++;
        pokemon.Sono++;

        TomagochiLib.PularLinha();
    }
}
using System.Globalization;

namespace Tomagochi.Menus;

internal class MenuLib{
    public static void MenuHeader(string nomeMenu){
        Console.Clear();
        var tamanhodText = nomeMenu.Length;

        var maxHifens = 50;
        var maxMenosTexto = maxHifens - tamanhodText;
        var maxCadaLado = maxMenosTexto / 2;

        //contador dos "Hifens"
        var hif = 0;

        //Começo da linha
        do{
            Console.Write("-");
            hif++;
        }while(hif < maxCadaLado);

        //Nome do Menu
        Console.Write(" ");
        Console.Write(nomeMenu);
        Console.Write(" ");

        //completa a linha até o caracter designado
        do{
            Console.Write("-");
            hif++;
        }while(hif < maxCadaLado * 2);
        Console.WriteLine();
    }

    public static void Linha(){
        var hif = 0;
        do{
            Console.Write("-");
            hif++;
        }while(hif < 52);
        Console.WriteLine("");
    }

    public static string EntradaTexto(){
        CultureInfo culture = CultureInfo.CurrentCulture;
        Console.WriteLine("Qual é o seu nome?");
        var nome = Console.ReadLine();
        var nomeTitleCase = culture.TextInfo.ToTitleCase(nome);
        return nomeTitleCase;
    }

    public static string TitleCase(string text){
        CultureInfo culture = CultureInfo.CurrentCulture;
        var nomeTitleCase = culture.TextInfo.ToTitleCase(text);
        return nomeTitleCase;
    }
    
    public static int ReceberSelecao(){
        var input = Console.ReadLine();
        int.TryParse(input.ToString(), out int result);
        return result;
    }

    public static void MenuItem(string nomeDoItem){
        Console.WriteLine(nomeDoItem);
    }
    public static void RetornarAoMenuInicial(string nome){
        Thread.Sleep(3000);
        Console.WriteLine("Pressione qualquer tecla para retornar ao menu inicial....");
        Console.ReadLine();
        MainMenu.Show(nome);
    }
    public static void Sair(string nome){
        Console.WriteLine($"Adeus, {nome}.");
        Thread.Sleep(3000);
        Environment.Exit(0);
    }
}
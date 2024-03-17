using System.Globalization;

namespace Tomagochi.Menus;

internal class TomagochiLib{
    public static void Header(string nomeHeader){
        Console.Clear();
        var tamanhoText = nomeHeader.Length;

        var maxHifens = 50;
        var maxMenosTexto = maxHifens - tamanhoText;
        var maxCadaLado = maxMenosTexto / 2;

        //contador dos "Hifens"
        var hif = 0;

        //Começo da linha
        do{
            Console.Write("-");
            hif++;
        }while(hif < maxCadaLado);

        //Nome do header
        Console.Write(" ");
        Console.Write(nomeHeader);
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
        Console.WriteLine("Qual é o seu nome?");
        var nome = Console.ReadLine();
        var nomeTitleCase = TitleCase(nome);
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
        Console.WriteLine("Pressione qualquer tecla para retornar ao menu inicial...");
        Console.ReadKey();
        MainMenu.Show(nome);
    }
   
    public static void Sair(string nome){
        Console.WriteLine($"Adeus, {nome}.");
        Thread.Sleep(3000);
        Environment.Exit(0);
    }
}
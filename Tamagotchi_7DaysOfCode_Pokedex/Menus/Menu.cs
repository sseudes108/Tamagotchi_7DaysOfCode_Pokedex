namespace Tomagochi7DaysOfCode.Menus{
    internal class Menu{
        public static void MenuHeader(string menuName)
        {
            Console.Clear();
            Console.WriteLine(menuName);
            Console.WriteLine("------------------------");
        }

        public static int ReceberSelecao()
        {
            var input = Console.ReadLine();
            int.TryParse(input.ToString(), out int result);
            return result;
        }

        public static void Linha()
        {
            Console.WriteLine($"------------------------");
        }
    }
}

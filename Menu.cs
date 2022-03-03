namespace Date
{
    public static class Menu
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Selecione o pais que deseja saber a hora: ");
            Console.WriteLine("1 - Alemanha");
            Console.WriteLine("2 - Brasil ");
            Console.WriteLine("3 - Coreia do sul");
            Console.WriteLine("4 - Estados unidos");
            Console.WriteLine("5 - Espanha");
            Console.WriteLine("6 - França");
            Console.WriteLine("7 - Italia");
            Console.WriteLine("8 - Japão");
            Console.WriteLine("9 - Reino unido");
            Console.WriteLine("0 - Sair");
            Console.WriteLine(" ");
            short opc = short.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    CountriesFourHours();
                    break;
                case 2:
                    Brazil();
                    break;
                case 3:
                    CountriesTwelveHours();
                    break;
                case 4:
                    UnitedStates();
                    break;
                case 5:
                    CountriesFourHours();
                    break;
                case 6:
                    CountriesFourHours();
                    break;
                case 7:
                    CountriesFourHours();
                    break;
                case 8:
                    CountriesTwelveHours();
                    break;
                case 9:
                    UnitedKingdom();
                    break;
                case 0:
                    Console.WriteLine("Até a proxima!");
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente!");
                    ShowMenu();
                    break;

            }
        }
        public static void SubMenu()
        {
            Console.WriteLine("Deseja realizar outra consulta?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("0 - Não");
            Console.WriteLine(" ");
            short opc = short.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    ShowMenu();
                    break;
                case 0:
                    Console.WriteLine("Até a proxima!");
                    System.Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
        public static void Brazil()
        {
            Console.Clear();

            var date = DateTime.Now;
            Console.WriteLine(date);

            SubMenu();

        }
        public static void UnitedStates()
        {
            Console.Clear();

            var date = DateTime.Now;
            Console.WriteLine(date.AddHours(2));
            SubMenu();
        }
        public static void UnitedKingdom()
        {
             Console.Clear();

            var date = DateTime.Now;
            Console.WriteLine(date.AddHours(3));
            SubMenu();
        }
        public static void CountriesTwelveHours ()
        {
            Console.Clear();

            var date = DateTime.Now;
            Console.WriteLine(date.AddHours(12));
            SubMenu();
        }
        public static void CountriesFourHours()
        {
            Console.Clear();

            var date = DateTime.Now;
            Console.WriteLine(date.AddHours(4));
            SubMenu();
        }
    }
}
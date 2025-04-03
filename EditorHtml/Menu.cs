namespace EditoHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
        }

        public static void DrawScreen()
        {
            FirstLastLine();
            
            for(int lines =0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                System.Console.Write("\n");
            }

            FirstLastLine();            
        }

        public static void FirstLastLine()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }
    }
}



using System.Runtime.ConstrainedExecution;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            FirstLastLine();
             
            for(int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for(int i = 0; i <= 38; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            FirstLastLine();            
        }

        public static void FirstLastLine()
        {
            Console.Write("+");
            for (int i = 0; i <= 38; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }
    
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2); //Determina onde irá colocar o cursor de escrever
            Console.Write("Editor HTML");
            Console.SetCursorPosition(3,3);
            System.Console.WriteLine("==============");
            Console.SetCursorPosition(3,4);
            System.Console.WriteLine("Selecione uma opção abaixo: ");
            Console.SetCursorPosition(3,6);
            System.Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3,7);
            System.Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,9);
            System.Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            System.Console.Write("Qual opção deseja selecionar: ");
        }
    
        //Handle == Manipular
        public static void HandleMenuOption(short option)
        {
            switch(option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(""); break;
                case 0: 
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}



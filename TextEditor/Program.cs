﻿using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();   
        }
        static void Menu()
        {
            Console.Clear();    
            System.Console.WriteLine("O que você deseja fazer? ");
            System.Console.WriteLine("1 - Abrir arquivo");
            System.Console.WriteLine("2 - Criar um novo arquivo");
            System.Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());
            
            switch(option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            System.Console.WriteLine("Qual caminho do arquivo? ");
            string path = Console.ReadLine();

            using(var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                System.Console.WriteLine(text);
            }

            System.Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            System.Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            System.Console.WriteLine("-------------------------");
            string text = string.Empty;

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
                
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape); //Só ira parar o while quando o usuário apertar o ESC
        
            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            System.Console.WriteLine("Qual caminho para salvar o arquivo? ");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso! ");
            Console.ReadLine();
            Menu();
        }
    }
}
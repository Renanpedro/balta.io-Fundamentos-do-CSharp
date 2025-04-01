using System;
using System.Net;

class Program
{
    public static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {

        // Console.Clear();
        System.Console.WriteLine("");
        Console.WriteLine("S = Segundo => 10s = 10 segundos");
        Console.WriteLine("M = Minuto => 1m = 1 minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine().ToLower();
        if(data.Length != 1)
        {
            char type = char.Parse(data.Substring(data.Length-1, 1)); // Pega o ultimo caracter informado
            int time = int.Parse(data.Substring(0, data.Length-1)); 
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;

            if(time == 0)
                Environment.Exit(0);

            PreStart(time * multiplier);
        } 
        else
        {   
            System.Console.WriteLine("Valor informado errado, informe a quantidade em numero e ao final S para segundos ou M para minutos: ");
            Menu();
        }        
    }

    static void PreStart(int time)
    {
        Console.Clear();
        System.Console.WriteLine("Ready....");
        Thread.Sleep(1000);
        System.Console.WriteLine("Set....");
        Thread.Sleep(1000);
        System.Console.WriteLine("Go....");
        Thread.Sleep(2500);

        Start(time);
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while(currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000); //Aguarda 1 seg antes de validar o while novamente
        }

        Console.Clear();
        Console.WriteLine("Stopwatch finalizado...");
        Thread.Sleep(2500);
        Menu();
    }
}
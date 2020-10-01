using System;

namespace Cebolinha_
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase; 

            //<--- inicio (digite)--->//
            Console.Write("Digite algo do seu interese");
            frase = Console.ReadLine();
            Console.Write("\n");

            Console.WriteLine($" { frase.Replace("r" , "l").Replace("R" , "L") } "); 
            //<---fim (digite)--->//

            //<---inicio(sair)--->//
            Console.WriteLine("ConsoleKeyInfo a tecla ENTER para sair");
            Console.ReadKey();
            //<---fim (sair)--->//

            {
                
            }
        }
    }
}

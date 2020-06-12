using System;

namespace Aula16_Sprint4_MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroi cascao = new Heroi();
            System.Console.WriteLine("------Personagem 1------");
            System.Console.WriteLine();
            System.Console.WriteLine($"Nome={cascao.Nome ?? "null"}\nVida={cascao.Vida}\nAtaque={cascao.Ataque}\nEspecial={cascao.Especial ?? "null"} ");
            System.Console.WriteLine();

            Heroi iaun = new Heroi(100);
            System.Console.WriteLine("------Personagem 2------");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine($"Vida={iaun.Vida}");
            System.Console.WriteLine();

            Heroi palhari = new Heroi("Palhari", 120,20,"Voar");
            System.Console.WriteLine("------Personagem 3------");
            System.Console.WriteLine();
            System.Console.WriteLine($"Nome={palhari.Nome ?? "Palhari"}\nVida={palhari.Vida}\nAtaque={palhari.Ataque}\nEspecial={palhari.Especial} ");
            System.Console.WriteLine();

            Console.ReadLine();
            
        }
    }
}

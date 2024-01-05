using System;
using dotnet_POO.src.Entities;
// Criando instâncias das classes

internal class Program
{
    private static void Main(string[] args)
    {
        // Criando instâncias das classes
        Knight arus = new Knight("Arus ", 42, 10, 10, "Knight", " de espada");
        Ninja wedge = new Ninja("Wedge ", 42, 10, 10, "Ninja", " lançou Shuriken Throw");
        WhiteWizard jenica = new WhiteWizard("Jenica ", 42, 10, 10, "WhiteWizard", "Escudo Protetor");
        BlackWizard topapa = new BlackWizard("Topapa ", 42, 10, 10, "BlackWizard", "Bola de Fogo");

        // Criando uma instância de Enemy (substitua EnemyClass pela classe real que você está usando para inimigos)
        Minions minions = new Minions("Minions", 42, 5, 0, "InimigoType", "Ataque direto");

        Console.WriteLine(arus.PerformAttack(minions));
        Console.WriteLine(wedge.PerformAttack(minions));
        Console.WriteLine(jenica.PerformAttack(minions));
        Console.WriteLine(topapa.PerformAttack(minions));


       
    }
}
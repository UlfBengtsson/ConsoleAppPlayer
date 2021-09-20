using ConsoleAppPlayer.Models;
using System;

namespace ConsoleAppPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Calle", "Human", "Man");
            Player player2 = new Player("Adam", "Human", "Man");
            Player player3 = new Player("Oskar", "Human", "Man");
            
            Console.WriteLine(player1.Status());
            Console.WriteLine(player2.Status());
            Console.WriteLine(player3.Status());
        }
    }
}

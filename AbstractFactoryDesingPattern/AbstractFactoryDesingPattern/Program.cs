using System;
using AbstractFactoryDesingPattern.Classes;
using AbstractFactoryDesingPattern.İnterfaces;

namespace AbstractFactoryDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFootballFactory Spain = new BundesLigaFactory();

            FootballWorld fworld = new FootballWorld(Spain);

            Console.WriteLine(fworld.GetFootballTeamColor());
            Console.WriteLine(fworld.GetFootballTopScorer());

            Console.ReadKey();
        }
    }
}

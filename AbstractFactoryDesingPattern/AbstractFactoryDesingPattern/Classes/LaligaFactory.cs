using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryDesingPattern.İnterfaces;

namespace AbstractFactoryDesingPattern.Classes
{
    public class LaligaFactory : IFootballFactory
    {
        public IPlayer CreatePlayer()
        {
            return new LaligaPlayer();
        }

        public ITeam CreateTeam()
        {
            return new RealMadrid();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryDesingPattern.İnterfaces;

namespace AbstractFactoryDesingPattern.Classes
{
    public class BundesLigaFactory : IFootballFactory
    {
        public IPlayer CreatePlayer()
        {
            return new BundesLigaPlayer();
        }

        public ITeam CreateTeam()
        {
            return new BorussiaDortmund();
            {
               
            }
        }
    }
}

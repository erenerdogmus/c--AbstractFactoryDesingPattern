    using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryDesingPattern.İnterfaces;

namespace AbstractFactoryDesingPattern.Classes
{
    public class SeriesAFactory : IFootballFactory
    {
        public IPlayer CreatePlayer()
        {
            return new SeriesAPlayer();
        }

        public ITeam CreateTeam()
        {
            return new Juventus();
        }
    }
}

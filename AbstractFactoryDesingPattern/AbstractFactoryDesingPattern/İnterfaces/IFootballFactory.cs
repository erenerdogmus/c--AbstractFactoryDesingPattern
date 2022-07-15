using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesingPattern.İnterfaces
{
    public interface IFootballFactory
    {
        ITeam CreateTeam();
        IPlayer CreatePlayer();
    }
}

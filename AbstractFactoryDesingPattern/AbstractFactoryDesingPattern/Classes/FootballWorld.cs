using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryDesingPattern.İnterfaces;
namespace AbstractFactoryDesingPattern.Classes
{
    class FootballWorld
    {
        private readonly ITeam _team;
        private readonly IPlayer _player;

        public FootballWorld(IFootballFactory factory)
        {
            _team = factory.CreateTeam();
            _player = factory.CreatePlayer();
        }

        public string GetFootballTeamColor()
        {
            return _team.GetTeamColor();
        }

        public string GetFootballTopScorer()
        {
            return _player.GetTopScorer();
        }
    }
}

using AbstractFactoryDesingPattern.İnterfaces;

namespace AbstractFactoryDesingPattern.Classes
{
    public class Juventus : ITeam
    {
        public string GetTeamColor()
        {
            return "Black And White";
        }
    }
}
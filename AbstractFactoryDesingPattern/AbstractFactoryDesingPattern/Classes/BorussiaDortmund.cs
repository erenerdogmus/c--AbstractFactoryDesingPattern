using AbstractFactoryDesingPattern.İnterfaces;

namespace AbstractFactoryDesingPattern.Classes
{
    public class BorussiaDortmund : ITeam
    {
        public string GetTeamColor()
        {
            return "Black and Yellow";
        }
    }
}
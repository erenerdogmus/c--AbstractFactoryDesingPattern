using AbstractFactoryDesingPattern.İnterfaces;

namespace AbstractFactoryDesingPattern.Classes
{
    public class RealMadrid : ITeam
    {
        public string GetTeamColor()
        {
            return "Blue And White";
        }
    }
}
using AbstractFactoryDesingPattern.İnterfaces;

namespace AbstractFactoryDesingPattern.Classes
{
    public class SeriesAPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Cristiano Ronaldo";
        }
    }
}
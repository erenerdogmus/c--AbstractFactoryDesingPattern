using AbstractFactoryDesingPattern.İnterfaces;

namespace AbstractFactoryDesingPattern.Classes
{
    public class LaligaPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Lionel Messi";
        }
    }
}
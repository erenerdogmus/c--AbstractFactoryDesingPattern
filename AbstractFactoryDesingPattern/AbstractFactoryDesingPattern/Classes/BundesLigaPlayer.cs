using AbstractFactoryDesingPattern.İnterfaces;

namespace AbstractFactoryDesingPattern.Classes
{
    public class BundesLigaPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Robert Lewandowski";
        }
    }
}
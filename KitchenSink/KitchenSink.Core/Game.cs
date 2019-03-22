using System.Collections.Generic;

namespace KitchenSink.Core
{
    public class Game : IGame
    {
        public Score score { get; set; } = new Score();
        public PointsCounter pointsCounter { get; set; } = new PointsCounter();
        public List<Level> levels { get; set; } = new List<Level>();

        public Set<Screen> sreens { get; set; } = new Set<Screen>();

        public void start()
        {

        }

        public void end()
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurRate
{
    public class Market
    {
        public decimal curRate { get; private set; }

        private int day;
        private const double k = 0.02;
        private Random random = new Random();

        public Player player { get; private set; }

        public Market(decimal curRate)
        {
            this.curRate = curRate;
            this.day = 1;

            player = new Player(1000, this);
        }        

        public KeyValuePair<int, decimal> NextDay()
        {
            curRate = curRate * (decimal)(1 + k * (random.NextDouble() - 0.5));
            KeyValuePair<int, decimal> results = new KeyValuePair<int, decimal>(day++, curRate);

            return results;
        }

    }
}

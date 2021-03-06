using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurRate
{
    public class Player
    {
        public decimal rubles { get; private set; }
        public int euros { get; private set; }

        private Market market;

        public Player(int rubles, Market market)
        {
            this.rubles = rubles;
            this.market = market;
        }

        public void BuyEuros(int amount)
        {
            rubles -= market.curRate * amount;
            euros += amount;
        }

        public void SellEuros(int amount)
        {
            rubles += amount * market.curRate;
            euros -= amount;
        }
    }
}

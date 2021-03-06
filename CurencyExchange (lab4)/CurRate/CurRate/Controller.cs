using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurRate
{
    class Controller
    {
        private Form1 form;
        public Market market { get; private set; }        
        public KeyValuePair<int, decimal> results { get; private set; }
        public Controller(Form1 form)
        {
            this.form = form;                       
            this.market = new Market(this.form.GetFirstRate());
        }

        public void NextStep()
        {            
            market.player.BuyEuros(form.GetBuyingAmount());
            market.player.SellEuros(form.GetSellingAmount());

            results = market.NextDay();
        }

    }
}

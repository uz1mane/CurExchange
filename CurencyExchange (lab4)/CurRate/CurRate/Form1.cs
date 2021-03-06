using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurRate
{
    public partial class Form1 : Form
    {
        private Controller controller;        

        public Form1()
        {
            InitializeComponent();

            chart1.Series[0].Points.Clear();

            controller = new Controller(this);            

            edSellingAmount.Enabled = false;
            edBuyingAmount.Enabled = false;
        }

        public decimal GetFirstRate()
        {
            decimal firstRate = edRate.Value;            
            chart1.Series[0].Points.AddXY(0, firstRate);

            return firstRate;         
        }

        public int GetBuyingAmount()
        {
            return (int)edBuyingAmount.Value;
        }

        public int GetSellingAmount()
        {
            return (int)edSellingAmount.Value;
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            edRate.Enabled = false;

            edSellingAmount.Enabled = true;
            edBuyingAmount.Enabled = true;           
            
            controller.NextStep();

            edBuyingAmount.Maximum = (int)(controller.market.player.rubles / controller.market.curRate);
            edSellingAmount.Maximum = (controller.market.player.euros);

            edBuyingAmount.Value = 0;
            edSellingAmount.Value = 0;

            lbRubles.Text = "Рублей на счете : " + Math.Round(controller.market.player.rubles, 2).ToString();
            lbEuros.Text = "Евро на счете     : " + controller.market.player.euros.ToString();

            edRate.Value = controller.results.Value;
            chart1.Series[0].Points.AddXY(controller.results.Key, controller.results.Value);
        }       
    }
}

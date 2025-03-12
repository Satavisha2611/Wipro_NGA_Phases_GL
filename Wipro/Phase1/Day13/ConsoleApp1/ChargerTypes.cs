using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AmericanCharger
    {
        void Connect()
        {
            Console.WriteLine("Charging using 2 pins.");
        }
    }

    public class ChargerAdapter : IndianSocket
    {
        private AmericanCharger charger;
        public ChargerAdapter(AmericanCharger charger)
        {
            this.charger = charger;
        }

        public void Charger()
        {
            Console.WriteLine("Charging from 3 pin.");
        }
    }

}

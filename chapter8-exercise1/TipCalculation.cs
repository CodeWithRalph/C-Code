using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter8_exercise1
{
    class TipCalculation
    {
        TipCalculation() {
        }
        void calculateTip(decimal price, double tip) {
            Console.WriteLine("total of the meal plus the tip: ${0:#.00}", price * Convert.ToDecimal(1 + tip));
        }
        void calculateTip(decimal price, int tip)
        {
            Console.WriteLine("total of the meal plus the tip: ${0:#.00}", price + tip);
        }

        public static void Main(String[] args) {
            TipCalculation total = new TipCalculation();
            total.calculateTip(100, 0.15);
            total.calculateTip(100, 5);

            String value = "10";
            int tipAmount;
            if (int.TryParse(value, out tipAmount)) { 
                // integer goes here
            }else
            {
                // double goes here
            }


        }
    }
}

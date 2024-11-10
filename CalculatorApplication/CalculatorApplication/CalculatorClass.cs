using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T num1, T num2);

    public class CalculatorClass
    {
        public Formula<double> displayFormula;

        public double GetSum(double txtBoxInput1, double txtBoxInput2)
        {
            return txtBoxInput1 + txtBoxInput2;
        }

        public double GetDifference(double txtBoxInput1, double txtBoxInput2)
        {
            return txtBoxInput1 - txtBoxInput2;
        }

        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
                displayFormula += value;
            }
            remove
            {
                Console.WriteLine("Remove the Delegate");
                displayFormula -= value;
            }
        }

        public double GetProduct(double txtBoxInput1, double txtBoxInput2)
        {
            return txtBoxInput1 * txtBoxInput2;
        }

        public double GetQuotient(double txtBoxInput1, double txtBoxInput2)
        {
            if (txtBoxInput2 == 0)
            {
                MessageBox.Show("Cannot divide by zero!");
                return 0;
            }
            return txtBoxInput1 / txtBoxInput2;
        }
    }
}
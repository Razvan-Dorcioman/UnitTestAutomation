using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationTests
{
    public class ConversionRate
    {
        public static bool Inverse { get; set; }

        public Dictionary<string, double> ConversionRateList = new Dictionary<string, double>()
        {
            { "EURtoRON", 4.81 },
            { "EURtoUSD", 1.13 },
            { "EURtoCAD", 1.52 },
            { "EURtoGBP", 0.86 },
            { "RONtoEUR", 0.21 },
            { "RONtoUSD", 0.23 },
            { "RONtoCAD", 0.32 },
            { "RONtoGBP", 0.18 },
            { "USDtoRON", 4.26 },
            { "USDtoEUR", 0.89 },
            { "USDtoCAD", 1.34 },
            { "USDtoGBP", 0.77 },
            { "CADtoRON", 3.17 },
            { "CADtoEUR", 0.66 },
            { "CADtoUSD", 0.74 },
            { "CADtoGBP", 0.57 },
            { "GBPtoRON", 5.56 },
            { "GBPtoEUR", 1.16 },
            { "GBPtoUSD", 1.30 },
            { "GBPtoCAD", 1.75 },
        };

        public ConversionRate()
        {
            Inverse = false;
        }

        public double Convert(string firstText, string firstCombo, string secondCombo, out double convRate)
        {
            double result;
            if (double.TryParse(firstText, out result))
            {
                if (CompareCoins(firstCombo, secondCombo))
                {
                    convRate = 1;
                }
                else
                {
                    string conversion = firstCombo + "to" + secondCombo;

                    convRate = ConversionRateList[conversion];
                }
                return result * convRate;
            }

            MessageBox.Show("Invalid number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            convRate = -1;
            return -1;
        }

        private bool CompareCoins(string firstCombo, string secondCombo)
        {
            return firstCombo == secondCombo;
        }
    }
}

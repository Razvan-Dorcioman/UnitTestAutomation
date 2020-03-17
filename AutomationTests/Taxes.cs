using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests
{
    public class Taxes
    {
        public string rateType;
        public decimal homePrice;
        public decimal downPayment;
        public decimal downPaymentPercentage = 15;
        public int lengthOfLoan = 10;
        public decimal interestRate;
        public string rateMonthlyType;


        public decimal monthlyCreditRate;
        public decimal[] creditRateDecreasing;
        public decimal totalAmountPayable;
        public decimal differenceFirstHome = 0;
        public double euro = 4.81;


        public void SetRateType(string value)
        {
            rateType = value;
        }

        public void SetHomePrice(string value)
        {
            homePrice = Convert.ToDecimal(value);
        }

        public void SetDownPayment(string value)
        {
            downPayment = Convert.ToDecimal(value);
        }

        public void SetDownPaymentPercentage(decimal value)
        {
            downPaymentPercentage = value;
        }

        public void SetLengthOfLoan(decimal value)
        {
            lengthOfLoan = (int)value;
        }

        public void SetRateMonthlyType(string value)
        {
            rateMonthlyType = value;
        }

        public string GetMonthlyCreditRate()
        {
            if(rateMonthlyType == "equal")
            {
                return Convert.ToString(monthlyCreditRate); 
            }
            else if (rateMonthlyType == "decreasing")
            {
                return Convert.ToString(creditRateDecreasing[0]);
            }
            return "";
        }

        public string GetTotalAmountPayable()
        {
            return Convert.ToString(totalAmountPayable);
        }

        public bool ValidateDownPayment(string valueDownPayment, string valueHomePrice)
        {
            int minim = 0;
            int maxim = 100;
            if(rateType == "firstHome")
            {
                minim = 5;   
            }
            else if(rateType == "realEstateInvestments")
            {
                minim = 15;
            }

            decimal numberDownPayment;
            decimal numberHomePrice;

            if(Decimal.TryParse(valueDownPayment, out numberDownPayment) && Decimal.TryParse(valueHomePrice, out numberHomePrice))
            {
                decimal val = (numberDownPayment / numberHomePrice) * 100;
                if ((Convert.ToDecimal(val) < minim) || (Convert.ToDecimal(val) > maxim))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            

            return true;
        }

        public bool ValidateDownPaymentProcent(decimal value)
        {
            int minim = 0;
            int maxim = 100;
            if (rateType == "firstHome")
            {
                minim = 5;
            }
            else if (rateType == "realEstateInvestments")
            {
                minim = 15;
            }

            if(value<minim || value > maxim)
            {
                return false;
            }

            return true;
        }

        public string calculateDownPaymentByProcent(decimal procent)
        {
            return (Convert.ToDecimal(homePrice) * procent / 100).ToString();
        }

        public decimal calculateDownPaymentProcent()
        {
            return (Convert.ToDecimal(downPayment) / Convert.ToDecimal(homePrice)) * 100;
        }

        public string calculateDownPayment()
        {
            return (Convert.ToDecimal(homePrice) * Convert.ToDecimal(downPaymentPercentage) / 100).ToString();
        }
        public bool CheckIfPropsAreEmpthy()
        {
            if(rateType != "" && homePrice != 0 && downPayment != 0 && downPaymentPercentage != 0 && lengthOfLoan != 0 && interestRate != 0 && rateMonthlyType != "")
            {
                return true;
            }
            return false;
        }

        public bool validateInterestRate(string value)
        {
            int ok = 1;
            decimal number;
            if (Decimal.TryParse(value, out number))
            {
                if (number > 10)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            for (int i = 0; i < value.Length && ok != 0; i++)
            {
                Console.WriteLine(value[i]);
                if (value[i] != ',' && Char.IsDigit(value[i]) == false)
                {
                    return false;
                }
            }
            if (value == "")
            {
                return false;
            }

            if (ok == 1)
            {
                interestRate = Convert.ToDecimal(value);
            }
            else
            {
                return false;
            }
            return true;
        }

        public void CalculateRate()
        {

            if(rateType == "firstHome")
            {
                CalculateRateForFirstHome();
            }
            else if(rateType == "realEstateInvestments")
            {
                if(rateMonthlyType == "equal")
                {
                    CalculateRateForEqualRealStateInvestments();
                }
                else if(rateMonthlyType == "decreasing")
                {
                    CalculateRateForDecreasingRealStateInvestments();
                }
            }
        }

        public void CalculateRateForFirstHome()
        {
            if(homePrice <= Convert.ToDecimal(66000*euro))
            {
                monthlyCreditRate = ((homePrice - downPayment) * interestRate / 100) / (12 * (1 - Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + (interestRate / 1200)), (-1) * Convert.ToDouble(lengthOfLoan * 12)))));
                differenceFirstHome = 0;
            }
            else
            {
                differenceFirstHome = homePrice - Convert.ToDecimal(66000 * euro);
                monthlyCreditRate = ((Convert.ToDecimal(66000 * euro) - downPayment) * interestRate / 100) / (12 * (1 - Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + (interestRate / 1200)), (-1) * Convert.ToDouble(lengthOfLoan * 12)))));

            }
            totalAmountPayable = lengthOfLoan * 12 * monthlyCreditRate;
        }

        public void CalculateRateForEqualRealStateInvestments()
        {
            monthlyCreditRate = ((homePrice-downPayment) * interestRate / 100) / (12 * (1 - Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + (interestRate / 1200)), (-1) * Convert.ToDouble(lengthOfLoan * 12)))));
            totalAmountPayable = lengthOfLoan * 12 * monthlyCreditRate;
        }

        public void CalculateRateForDecreasingRealStateInvestments()
        {
            creditRateDecreasing = new decimal[12 * (int)lengthOfLoan];
            decimal sumaRate = 0;
            for (int i = 0;  i< (12*lengthOfLoan); i++)
            {
                var currentMonth = homePrice / (12 * lengthOfLoan) + (homePrice - sumaRate) * (interestRate / 1200);
                creditRateDecreasing[i] = decimal.Round(currentMonth, 2, MidpointRounding.AwayFromZero);
                sumaRate +=creditRateDecreasing[i];
            }

            totalAmountPayable = sumaRate;
        }
        //tests
        //stop the loop
        //validation after 1 sec
    }
}

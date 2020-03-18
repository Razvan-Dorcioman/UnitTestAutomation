﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests
{
    public class Taxes
    {
        public string rateType = "";
        public decimal homePrice = 0;
        public decimal downPayment = 0;
        public decimal downPaymentPercentage = 15;
        public int lengthOfLoan = 10;
        public decimal interestRate = 0;
        public string rateMonthlyType = "";


        public decimal monthlyCreditRate = 0;
        public decimal[] creditRateDecreasing;
        public decimal totalAmountPayable = 0;
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
            else
            {
                return false;
            }

            decimal numberDownPayment;
            decimal numberHomePrice;

            if(valueDownPayment != "" && valueHomePrice != "")
            {
                if (Decimal.TryParse(valueDownPayment, out numberDownPayment) && Decimal.TryParse(valueHomePrice, out numberHomePrice))
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
            else
            {
                return false;
            }

            if(value < minim || value > maxim)
            {
                return false;
            }
            return true;
        }

        public string calculateDownPaymentByProcent(string procent)
        {
            decimal value = homePrice * Convert.ToDecimal(procent) / 100;
            return (decimal.Round(value, 2, MidpointRounding.AwayFromZero)).ToString();
        }

        public decimal calculateDownPaymentProcent()
        {
            decimal value = (downPayment / homePrice) * 100;
            return decimal.Round(value, 2, MidpointRounding.AwayFromZero);
        }

        public string calculateDownPayment()
        {
            decimal value = homePrice * downPaymentPercentage / 100;
            return (decimal.Round(value, 2, MidpointRounding.AwayFromZero)).ToString();
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

            interestRate = Convert.ToDecimal(value);

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
                differenceFirstHome = decimal.Round((homePrice - Convert.ToDecimal(66000 * euro)), 2, MidpointRounding.AwayFromZero);
                monthlyCreditRate = ((Convert.ToDecimal(66000 * euro) - downPayment) * interestRate / 100) / (12 * (1 - Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + (interestRate / 1200)), (-1) * Convert.ToDouble(lengthOfLoan * 12)))));

            }
            totalAmountPayable = lengthOfLoan * 12 * monthlyCreditRate + downPayment + differenceFirstHome;
            monthlyCreditRate = decimal.Round(monthlyCreditRate, 2, MidpointRounding.AwayFromZero);
            totalAmountPayable = decimal.Round(totalAmountPayable, 2, MidpointRounding.AwayFromZero);
        }

        public void CalculateRateForEqualRealStateInvestments()
        {
            monthlyCreditRate = ((homePrice-downPayment) * interestRate / 100) / (12 * (1 - Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + (interestRate / 1200)), (-1) * Convert.ToDouble(lengthOfLoan * 12)))));
            totalAmountPayable = lengthOfLoan * 12 * monthlyCreditRate + downPayment;
            monthlyCreditRate = decimal.Round(monthlyCreditRate, 2, MidpointRounding.AwayFromZero);
            totalAmountPayable = decimal.Round(totalAmountPayable, 2, MidpointRounding.AwayFromZero);
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
        //stop the loop
    }
}

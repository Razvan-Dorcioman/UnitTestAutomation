using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationTests.Test
{
    [TestClass]
    public class TaxesTest
    {
        
        private TestContext testContextInstance;
        public Taxes taxesManager { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            taxesManager = new Taxes();
        }


        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [Owner("Iulia")]
        public void TestSetRateType()
        {
            taxesManager.SetRateType("firstHome");
            Assert.AreEqual("firstHome", taxesManager.rateType);
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestSetHomePrice()
        {
            taxesManager.SetHomePrice("50000");
            Assert.AreEqual(50000, taxesManager.homePrice);
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestSetDownPayment()
        {
            taxesManager.SetDownPayment("5000");
            Assert.AreEqual(5000, taxesManager.downPayment);
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestSetDownPaymentPercentage()
        {
            taxesManager.SetDownPaymentPercentage(50);
            Assert.AreEqual(50, taxesManager.downPaymentPercentage);
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestSetLengthOfLoan()
        {
            taxesManager.SetLengthOfLoan(10);
            Assert.AreEqual(10, taxesManager.lengthOfLoan);
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestSetRateMonthlyType()
        {
            taxesManager.SetRateMonthlyType("equal");
            Assert.AreEqual("equal", taxesManager.rateMonthlyType);
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestGetMonthlyCreditRateForEqualRateSuccess()
        {
            taxesManager.rateMonthlyType = "equal";
            taxesManager.monthlyCreditRate = 500;
            Assert.AreEqual("500", taxesManager.GetMonthlyCreditRate());
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestGetMonthlyCreditRateForEqualRateFail()
        {
            taxesManager.rateMonthlyType = "equal";
            taxesManager.monthlyCreditRate = 500;
            Assert.AreNotEqual("50", taxesManager.GetMonthlyCreditRate());
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestGetMonthlyCreditRateForDecreasingRateSuccess()
        {
            taxesManager.rateMonthlyType = "decreasing";
            taxesManager.lengthOfLoan = 10;
            taxesManager.creditRateDecreasing = new decimal[12 * (int)taxesManager.lengthOfLoan];
            taxesManager.creditRateDecreasing[0] = 500;
            Assert.AreEqual("500", taxesManager.GetMonthlyCreditRate());
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestGetMonthlyCreditRateForDecreasingRateFail()
        {
            taxesManager.rateMonthlyType = "decreasing";
            taxesManager.lengthOfLoan = 10;
            taxesManager.creditRateDecreasing = new decimal[12 * (int)taxesManager.lengthOfLoan];
            taxesManager.creditRateDecreasing[0] = 500;
            Assert.AreNotEqual("50", taxesManager.GetMonthlyCreditRate());
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestGetMonthlyCreditRateFail()
        {
            taxesManager.rateMonthlyType = "asd";
            Assert.AreEqual("", taxesManager.GetMonthlyCreditRate());
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestGetTotalAmountPayable()
        {
            taxesManager.totalAmountPayable = 15000;
            Assert.AreEqual("15000", taxesManager.GetTotalAmountPayable());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentFirstHomeSuccess()
        {
            taxesManager.rateType = "firstHome";
            Assert.IsTrue(taxesManager.ValidateDownPayment("1000", "10000"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentRealEstateInvestmentsFail()
        {
            taxesManager.rateType = "realEstateInvestments";
            Assert.IsFalse(taxesManager.ValidateDownPayment("1000", "10000"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentInvalidParamFail()
        {
            taxesManager.rateType = "firstHome";
            Assert.IsFalse(taxesManager.ValidateDownPayment("10a00", "10000"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentEmpthyParamFail()
        {
            taxesManager.rateType = "firstHome";
            Assert.IsTrue(taxesManager.ValidateDownPayment("1000", ""));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("BlackBox")]
        public void TestValidateDownPaymentEmpthyRateTypeFail()
        {
            Assert.IsFalse(taxesManager.ValidateDownPayment("2000", "20000"));
        }
        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentProcentFirstHomeSuccessSmallest()
        {
            taxesManager.rateType = "firstHome";
            Assert.IsTrue(taxesManager.ValidateDownPaymentProcent(5));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentProcentFirstHomeSuccessBigest()
        {
            taxesManager.rateType = "firstHome";
            Assert.IsTrue(taxesManager.ValidateDownPaymentProcent(100));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentProcentFirstHomeFail()
        {
            taxesManager.rateType = "firstHome";
            Assert.IsFalse(taxesManager.ValidateDownPaymentProcent(110));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("BlackBox")]
        public void TestValidateDownPaymentProcentEmpthyRateTypeFail()
        {
            Assert.IsFalse(taxesManager.ValidateDownPaymentProcent(100));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentProcentRealEstateInvestmentsFail()
        {
            taxesManager.rateType = "realEstateInvestments";
            Assert.IsFalse(taxesManager.ValidateDownPaymentProcent(10));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateDownPaymentByProcentSuccess()
        {
            taxesManager.homePrice = 10123;
            Assert.AreEqual("1720.91", taxesManager.calculateDownPaymentByProcent("17"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateDownPaymentProcentSuccess()
        {
            taxesManager.homePrice = 10123;
            taxesManager.downPayment = Convert.ToDecimal(1720.91);
            Assert.AreEqual(17, taxesManager.calculateDownPaymentProcent());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateDownPayment()
        {
            taxesManager.downPaymentPercentage = 17;
            taxesManager.homePrice = 10123;
            Assert.AreEqual("1720.91", taxesManager.calculateDownPayment());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCheckIfPropsAreEmpthySuccess()
        {
            taxesManager.rateType = "firstHome";
            taxesManager.homePrice = 10000;
            taxesManager.downPayment = 1500;
            taxesManager.interestRate = 5;
            taxesManager.rateMonthlyType = "equal";
            Assert.IsTrue(taxesManager.CheckIfPropsAreEmpthy());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCheckIfPropsAreEmpthyMissingRateMonthlyTypeFail()
        {
            taxesManager.rateType = "firstHome";
            taxesManager.homePrice = 10000;
            taxesManager.downPayment = 1500;
            taxesManager.interestRate = 5;
            Assert.IsFalse(taxesManager.CheckIfPropsAreEmpthy());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCheckIfPropsAreEmpthyMissingInterestRateFail()
        {
            taxesManager.rateType = "firstHome";
            taxesManager.homePrice = 10000;
            taxesManager.downPayment = 1500;
            taxesManager.rateMonthlyType = "equal";
            Assert.IsFalse(taxesManager.CheckIfPropsAreEmpthy());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCheckIfPropsAreEmpthyMissingDownPaymentFail()
        {
            taxesManager.rateType = "firstHome";
            taxesManager.homePrice = 10000;
            taxesManager.interestRate = 5;
            taxesManager.rateMonthlyType = "equal";
            Assert.IsFalse(taxesManager.CheckIfPropsAreEmpthy());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCheckIfPropsAreEmpthyMissingHomePrice()
        {
            taxesManager.rateType = "firstHome";
            taxesManager.downPayment = 1500;
            taxesManager.interestRate = 5;
            taxesManager.rateMonthlyType = "equal";
            Assert.IsFalse(taxesManager.CheckIfPropsAreEmpthy());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCheckIfPropsAreEmpthyMissingRateTypeFail()
        {
            taxesManager.homePrice = 10000;
            taxesManager.downPayment = 1500;
            taxesManager.interestRate = 5;
            taxesManager.rateMonthlyType = "equal";
            Assert.IsFalse(taxesManager.CheckIfPropsAreEmpthy());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("BlackBox")]
        public void TestValidateInterestRateSuccess()
        {
            Assert.IsTrue(taxesManager.validateInterestRate("10"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("BlackBox")]
        public void TestValidateInterestRateFailTooHigh()
        {
            Assert.IsFalse(taxesManager.validateInterestRate("15"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("BlackBox")]
        public void TestValidateInterestRateFailNotDecimal()
        {
            Assert.IsFalse(taxesManager.validateInterestRate("1g4"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateRateFirstHomeEqualBigger()
        {
            taxesManager.rateType = "firstHome";
            taxesManager.homePrice = 777777;
            taxesManager.downPayment = Convert.ToDecimal(116666.55);
            taxesManager.downPaymentPercentage = 15;
            taxesManager.lengthOfLoan = 10;
            taxesManager.interestRate = 5;
            taxesManager.rateMonthlyType = "equal";
            taxesManager.CalculateRate();
            Assert.AreEqual(Convert.ToDecimal(2129.73), taxesManager.monthlyCreditRate);
            Assert.AreEqual(Convert.ToDecimal(832550.68), taxesManager.totalAmountPayable);
            Assert.AreEqual(Convert.ToDecimal(460317), taxesManager.differenceFirstHome);
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateRateFirstHomeEqualRateEqualValue()
        {
            taxesManager.rateType = "firstHome";
            taxesManager.homePrice = 66000 * Convert.ToDecimal(taxesManager.euro);
            taxesManager.downPayment = 47619;
            taxesManager.downPaymentPercentage = 15;
            taxesManager.lengthOfLoan = 10;
            taxesManager.interestRate = 5;
            taxesManager.rateMonthlyType = "equal";
            taxesManager.CalculateRate();
            Assert.AreEqual(Convert.ToDecimal(2862.08), taxesManager.monthlyCreditRate);
            Assert.AreEqual(Convert.ToDecimal(391068.90), taxesManager.totalAmountPayable);
            Assert.AreEqual(Convert.ToDecimal(0), taxesManager.differenceFirstHome);
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateRateFirstHomeEqualSmaller()
        {
            taxesManager.rateType = "firstHome";
            taxesManager.homePrice = 10000;
            taxesManager.downPayment = 1500;
            taxesManager.downPaymentPercentage = 15;
            taxesManager.lengthOfLoan = 10;
            taxesManager.interestRate = 5;
            taxesManager.rateMonthlyType = "equal";
            taxesManager.CalculateRate();
            Assert.AreEqual(Convert.ToDecimal(90.16), taxesManager.monthlyCreditRate);
            Assert.AreEqual(Convert.ToDecimal(12318.68), taxesManager.totalAmountPayable);
            Assert.AreEqual(Convert.ToDecimal(0), taxesManager.differenceFirstHome);
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateRateRealEstateInvestmentsEqualSucces()
        {
            taxesManager.rateType = "realEstateInvestments";
            taxesManager.homePrice = 777777;
            taxesManager.downPayment = Convert.ToDecimal(116666.55);
            taxesManager.downPaymentPercentage = 15;
            taxesManager.lengthOfLoan = 10;
            taxesManager.interestRate = 5;
            taxesManager.rateMonthlyType = "equal";
            taxesManager.CalculateRate();
            Assert.AreEqual(Convert.ToDecimal(7012.10), taxesManager.monthlyCreditRate);
            Assert.AreEqual(Convert.ToDecimal(958118.80), taxesManager.totalAmountPayable);
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateRateRealEstateInvestmentsDecreasingSucces()
        {
            taxesManager.rateType = "realEstateInvestments";
            taxesManager.homePrice = 777777;
            taxesManager.downPayment = Convert.ToDecimal(116666.55);
            taxesManager.downPaymentPercentage = 15;
            taxesManager.lengthOfLoan = 10;
            taxesManager.interestRate = 5;
            taxesManager.rateMonthlyType = "decreasing";
            taxesManager.CalculateRate();
            Assert.AreEqual(Convert.ToDecimal(9722.21), taxesManager.creditRateDecreasing[0]);
            Assert.AreEqual(Convert.ToDecimal(5915.31), taxesManager.creditRateDecreasing[taxesManager.creditRateDecreasing.Length-1]);
            Assert.AreEqual(Convert.ToDecimal(919571.75), taxesManager.totalAmountPayable);
        }
    }
}

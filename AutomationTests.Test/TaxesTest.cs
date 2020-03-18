using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationTests.Test
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class TaxesTest
    {
        public Taxes TaxesManager { get; set; }


        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            TaxesManager = new Taxes();
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestSetRateType()
        {
            TaxesManager.SetRateType("firstHome");
            Assert.AreEqual("firstHome", TaxesManager.rateType);
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestSetHomePrice()
        {
            TaxesManager.SetHomePrice("50000");
            Assert.AreEqual(50000, TaxesManager.homePrice);
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestSetDownPayment()
        {
            TaxesManager.SetDownPayment("5000");
            Assert.AreEqual(5000, TaxesManager.downPayment);
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestSetDownPaymentPercentage()
        {
            TaxesManager.SetDownPaymentPercentage(50);
            Assert.AreEqual(50, TaxesManager.downPaymentPercentage);
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestSetLengthOfLoan()
        {
            TaxesManager.SetLengthOfLoan(10);
            Assert.AreEqual(10, TaxesManager.lengthOfLoan);
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestSetRateMonthlyType()
        {
            TaxesManager.SetRateMonthlyType("equal");
            Assert.AreEqual("equal", TaxesManager.rateMonthlyType);
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestGetMonthlyCreditRateForEqualRateSuccess()
        {
            TaxesManager.rateMonthlyType = "equal";
            TaxesManager.monthlyCreditRate = 500;
            Assert.AreEqual("500", TaxesManager.GetMonthlyCreditRate());
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestGetMonthlyCreditRateForEqualRateFail()
        {
            TaxesManager.rateMonthlyType = "equal";
            TaxesManager.monthlyCreditRate = 500;
            Assert.AreNotEqual("50", TaxesManager.GetMonthlyCreditRate());
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestGetMonthlyCreditRateForDecreasingRateSuccess()
        {
            TaxesManager.rateMonthlyType = "decreasing";
            TaxesManager.lengthOfLoan = 10;
            TaxesManager.creditRateDecreasing = new decimal[12 * TaxesManager.lengthOfLoan];
            TaxesManager.creditRateDecreasing[0] = 500;
            Assert.AreEqual("500", TaxesManager.GetMonthlyCreditRate());
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestGetMonthlyCreditRateForDecreasingRateFail()
        {
            TaxesManager.rateMonthlyType = "decreasing";
            TaxesManager.lengthOfLoan = 10;
            TaxesManager.creditRateDecreasing = new decimal[12 * TaxesManager.lengthOfLoan];
            TaxesManager.creditRateDecreasing[0] = 500;
            Assert.AreNotEqual("50", TaxesManager.GetMonthlyCreditRate());
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestGetMonthlyCreditRateFail()
        {
            TaxesManager.rateMonthlyType = "asd";
            Assert.AreEqual("", TaxesManager.GetMonthlyCreditRate());
        }

        [TestMethod]
        [Owner("Iulia")]
        public void TestGetTotalAmountPayable()
        {
            TaxesManager.totalAmountPayable = 15000;
            Assert.AreEqual("15000", TaxesManager.GetTotalAmountPayable());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentFirstHomeSuccess()
        {
            TaxesManager.rateType = "firstHome";
            Assert.IsTrue(TaxesManager.ValidateDownPayment("1000", "10000"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentRealEstateInvestmentsFail()
        {
            TaxesManager.rateType = "realEstateInvestments";
            Assert.IsFalse(TaxesManager.ValidateDownPayment("1000", "10000"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentInvalidParamFail()
        {
            TaxesManager.rateType = "firstHome";
            Assert.IsFalse(TaxesManager.ValidateDownPayment("10a00", "10000"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentEmpthyParamFail()
        {
            TaxesManager.rateType = "firstHome";
            Assert.IsTrue(TaxesManager.ValidateDownPayment("1000", ""));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentProcentFirstHomeSuccessSmallest()
        {
            TaxesManager.rateType = "firstHome";
            Assert.IsTrue(TaxesManager.ValidateDownPaymentProcent(5));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentProcentFirstHomeSuccessBigest()
        {
            TaxesManager.rateType = "firstHome";
            Assert.IsTrue(TaxesManager.ValidateDownPaymentProcent(100));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentProcentFirstHomeFail()
        {
            TaxesManager.rateType = "firstHome";
            Assert.IsFalse(TaxesManager.ValidateDownPaymentProcent(110));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("BlackBox")]
        public void TestValidateDownPaymentProcentEmpthyRateTypeFail()
        {
            Assert.IsFalse(TaxesManager.ValidateDownPaymentProcent(100));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestValidateDownPaymentProcentRealEstateInvestmentsFail()
        {
            TaxesManager.rateType = "realEstateInvestments";
            Assert.IsFalse(TaxesManager.ValidateDownPaymentProcent(10));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateDownPaymentByProcentSuccess()
        {
            TaxesManager.homePrice = 10123;
            Assert.AreEqual("1720.91", TaxesManager.calculateDownPaymentByProcent("17"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateDownPaymentProcentSuccess()
        {
            TaxesManager.homePrice = 10123;
            TaxesManager.downPayment = Convert.ToDecimal(1720.91);
            Assert.AreEqual(17, TaxesManager.calculateDownPaymentProcent());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateDownPayment()
        {
            TaxesManager.downPaymentPercentage = 17;
            TaxesManager.homePrice = 10123;
            Assert.AreEqual("1720.91", TaxesManager.calculateDownPayment());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCheckIfPropsAreEmpthySuccess()
        {
            TaxesManager.rateType = "firstHome";
            TaxesManager.homePrice = 10000;
            TaxesManager.downPayment = 1500;
            TaxesManager.interestRate = 5;
            TaxesManager.rateMonthlyType = "equal";
            Assert.IsTrue(TaxesManager.CheckIfPropsAreEmpthy());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCheckIfPropsAreEmpthyMissingRateMonthlyTypeFail()
        {
            TaxesManager.rateType = "firstHome";
            TaxesManager.homePrice = 10000;
            TaxesManager.downPayment = 1500;
            TaxesManager.interestRate = 5;
            Assert.IsFalse(TaxesManager.CheckIfPropsAreEmpthy());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCheckIfPropsAreEmpthyMissingInterestRateFail()
        {
            TaxesManager.rateType = "firstHome";
            TaxesManager.homePrice = 10000;
            TaxesManager.downPayment = 1500;
            TaxesManager.rateMonthlyType = "equal";
            Assert.IsFalse(TaxesManager.CheckIfPropsAreEmpthy());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCheckIfPropsAreEmpthyMissingDownPaymentFail()
        {
            TaxesManager.rateType = "firstHome";
            TaxesManager.homePrice = 10000;
            TaxesManager.interestRate = 5;
            TaxesManager.rateMonthlyType = "equal";
            Assert.IsFalse(TaxesManager.CheckIfPropsAreEmpthy());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCheckIfPropsAreEmpthyMissingHomePrice()
        {
            TaxesManager.rateType = "firstHome";
            TaxesManager.downPayment = 1500;
            TaxesManager.interestRate = 5;
            TaxesManager.rateMonthlyType = "equal";
            Assert.IsFalse(TaxesManager.CheckIfPropsAreEmpthy());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCheckIfPropsAreEmpthyMissingRateTypeFail()
        {
            TaxesManager.homePrice = 10000;
            TaxesManager.downPayment = 1500;
            TaxesManager.interestRate = 5;
            TaxesManager.rateMonthlyType = "equal";
            Assert.IsFalse(TaxesManager.CheckIfPropsAreEmpthy());
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("BlackBox")]
        public void TestValidateInterestRateSuccess()
        {
            Assert.IsTrue(TaxesManager.validateInterestRate("10"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("BlackBox")]
        public void TestValidateInterestRateFailTooHigh()
        {
            Assert.IsFalse(TaxesManager.validateInterestRate("15"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("BlackBox")]
        public void TestValidateInterestRateFailNotDecimal()
        {
            Assert.IsFalse(TaxesManager.validateInterestRate("1g4"));
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateRateFirstHomeEqualBigger()
        {
            TaxesManager.rateType = "firstHome";
            TaxesManager.homePrice = 777777;
            TaxesManager.downPayment = Convert.ToDecimal(116666.55);
            TaxesManager.downPaymentPercentage = 15;
            TaxesManager.lengthOfLoan = 10;
            TaxesManager.interestRate = 5;
            TaxesManager.rateMonthlyType = "equal";
            TaxesManager.CalculateRate();
            Assert.AreEqual(Convert.ToDecimal(2129.73), TaxesManager.monthlyCreditRate);
            Assert.AreEqual(Convert.ToDecimal(832550.68), TaxesManager.totalAmountPayable);
            Assert.AreEqual(Convert.ToDecimal(460317), TaxesManager.differenceFirstHome);
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateRateFirstHomeEqualRateEqualValue()
        {
            TaxesManager.rateType = "firstHome";
            TaxesManager.homePrice = 66000 * Convert.ToDecimal(TaxesManager.euro);
            TaxesManager.downPayment = 47619;
            TaxesManager.downPaymentPercentage = 15;
            TaxesManager.lengthOfLoan = 10;
            TaxesManager.interestRate = 5;
            TaxesManager.rateMonthlyType = "equal";
            TaxesManager.CalculateRate();
            Assert.AreEqual(Convert.ToDecimal(2862.08), TaxesManager.monthlyCreditRate);
            Assert.AreEqual(Convert.ToDecimal(391068.90), TaxesManager.totalAmountPayable);
            Assert.AreEqual(Convert.ToDecimal(0), TaxesManager.differenceFirstHome);
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateRateFirstHomeEqualSmaller()
        {
            TaxesManager.rateType = "firstHome";
            TaxesManager.homePrice = 10000;
            TaxesManager.downPayment = 1500;
            TaxesManager.downPaymentPercentage = 15;
            TaxesManager.lengthOfLoan = 10;
            TaxesManager.interestRate = 5;
            TaxesManager.rateMonthlyType = "equal";
            TaxesManager.CalculateRate();
            Assert.AreEqual(Convert.ToDecimal(90.16), TaxesManager.monthlyCreditRate);
            Assert.AreEqual(Convert.ToDecimal(12318.68), TaxesManager.totalAmountPayable);
            Assert.AreEqual(Convert.ToDecimal(0), TaxesManager.differenceFirstHome);
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateRateRealEstateInvestmentsEqualSucces()
        {
            TaxesManager.rateType = "realEstateInvestments";
            TaxesManager.homePrice = 777777;
            TaxesManager.downPayment = Convert.ToDecimal(116666.55);
            TaxesManager.downPaymentPercentage = 15;
            TaxesManager.lengthOfLoan = 10;
            TaxesManager.interestRate = 5;
            TaxesManager.rateMonthlyType = "equal";
            TaxesManager.CalculateRate();
            Assert.AreEqual(Convert.ToDecimal(7012.10), TaxesManager.monthlyCreditRate);
            Assert.AreEqual(Convert.ToDecimal(958118.80), TaxesManager.totalAmountPayable);
        }

        [TestMethod]
        [Owner("Iulia")]
        [TestCategory("WhiteBox")]
        public void TestCalculateRateRealEstateInvestmentsDecreasingSucces()
        {
            TaxesManager.rateType = "realEstateInvestments";
            TaxesManager.homePrice = 777777;
            TaxesManager.downPayment = Convert.ToDecimal(116666.55);
            TaxesManager.downPaymentPercentage = 15;
            TaxesManager.lengthOfLoan = 10;
            TaxesManager.interestRate = 5;
            TaxesManager.rateMonthlyType = "decreasing";
            TaxesManager.CalculateRate();
            Assert.AreEqual(Convert.ToDecimal(9722.21), TaxesManager.creditRateDecreasing[0]);
            Assert.AreEqual(Convert.ToDecimal(5915.31),
                TaxesManager.creditRateDecreasing[TaxesManager.creditRateDecreasing.Length - 1]);
            Assert.AreEqual(Convert.ToDecimal(919571.75), TaxesManager.totalAmountPayable);
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
    }
}
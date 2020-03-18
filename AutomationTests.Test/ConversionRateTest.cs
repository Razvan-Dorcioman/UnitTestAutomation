using System;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationTests.Test
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ConversionRateTest
    {
        private const string FileName = @"FileToDeploy.txt";
        private string _badFileName;
        private string _goodFileName;
        public TestContext TestContext { get; set; }
        public ConversionRate ConversionRateManager { get; set; }

        public void SetGoodFileName()
        {
            _goodFileName = ConfigurationManager.AppSettings["GoodFileName"];
            if (_goodFileName.Contains("[AppPath]"))
                _goodFileName = _goodFileName.Replace("[AppPath]",
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
        }

        public void SetBadFileName()
        {
            _badFileName = ConfigurationManager.AppSettings["BadFileName"];
            if (_badFileName.Contains("[AppPath]"))
                _badFileName = _badFileName.Replace("[AppPath]",
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
        }

        [TestMethod]
        [Description("Check to see if a file does exists!")]
        [Owner("Razvan Dorcioman")]
        [Priority(0)]
        [TestCategory("BlackBox")]
        public void FileNameDoesExist()
        {
            bool fromCall;

            TestContext.WriteLine("Testing the file: " + _goodFileName);
            fromCall = ConversionRateManager.FileExists(_goodFileName);

            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [Priority(0)]
        [TestCategory("BlackBox")]
        public void FileNameDoesNotExist()
        {
            bool fromCall;

            fromCall = ConversionRateManager.FileExists(_badFileName);

            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [Priority(1)]
        [TestCategory("WhiteBox")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            ConversionRateManager.FileExists("");
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [Priority(1)]
        [TestCategory("WhiteBox")]
        public void FileNameNullOrEmpty_TryCatch()
        {
            try
            {
                ConversionRateManager.FileExists("");
            }
            catch (ArgumentNullException)
            {
                return;
            }

            Assert.Fail("Calling FileExists method didn't throw exception!!!");
        }

        [TestMethod]
        [TestCategory("DontRun")]
        [Ignore]
        public void DontRunThisTest()
        {
            Assert.Fail("This test should be ignored");
        }

        [TestMethod]
        [Timeout(4000)]
        [TestCategory("Timeout Fail")]
        public void SimulateTimeout()
        {
            Thread.Sleep(3000);
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [DeploymentItem(FileName)]
        [TestCategory("BlackBox")]
        public void FileNameDoesExistUsingDeploymentItem()
        {
            var fileName = TestContext.DeploymentDirectory + @"\" + FileName;
            TestContext.WriteLine("Deploy the file: " + fileName);

            var fromCall = ConversionRateManager.FileExists(fileName);

            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [TestCategory("BlackBox")]
        public void ConvertSuccessTest()
        {
            double convRateTest;
            var res = ConversionRateManager.Convert("1", "EUR", "RON", out convRateTest);
            Assert.AreEqual(4.81, convRateTest);
            Assert.AreEqual(4.81, res);

            res = ConversionRateManager.Convert("1", "EUR", "USD", out convRateTest);
            Assert.AreEqual(1.13, convRateTest);
            Assert.AreEqual(1.13, res);

            res = ConversionRateManager.Convert("1", "EUR", "CAD", out convRateTest);
            Assert.AreEqual(1.52, convRateTest);
            Assert.AreEqual(1.52, res);

            res = ConversionRateManager.Convert("1", "EUR", "GBP", out convRateTest);
            Assert.AreEqual(0.86, convRateTest);
            Assert.AreEqual(0.86, res);

            res = ConversionRateManager.Convert("1", "RON", "EUR", out convRateTest);
            Assert.AreEqual(0.21, convRateTest);
            Assert.AreEqual(0.21, res);

            res = ConversionRateManager.Convert("1", "RON", "USD", out convRateTest);
            Assert.AreEqual(0.23, convRateTest);
            Assert.AreEqual(0.23, res);

            res = ConversionRateManager.Convert("1", "RON", "CAD", out convRateTest);
            Assert.AreEqual(0.32, convRateTest);
            Assert.AreEqual(0.32, res);

            res = ConversionRateManager.Convert("1", "RON", "GBP", out convRateTest);
            Assert.AreEqual(0.18, convRateTest);
            Assert.AreEqual(0.18, res);

            res = ConversionRateManager.Convert("1", "USD", "RON", out convRateTest);
            Assert.AreEqual(4.26, convRateTest);
            Assert.AreEqual(4.26, res);

            res = ConversionRateManager.Convert("1", "USD", "EUR", out convRateTest);
            Assert.AreEqual(0.89, convRateTest);
            Assert.AreEqual(0.89, res);

            res = ConversionRateManager.Convert("1", "USD", "CAD", out convRateTest);
            Assert.AreEqual(1.34, convRateTest);
            Assert.AreEqual(1.34, res);

            res = ConversionRateManager.Convert("1", "USD", "GBP", out convRateTest);
            Assert.AreEqual(0.77, convRateTest);
            Assert.AreEqual(0.77, res);

            res = ConversionRateManager.Convert("1", "CAD", "RON", out convRateTest);
            Assert.AreEqual(3.17, convRateTest);
            Assert.AreEqual(3.17, res);

            res = ConversionRateManager.Convert("1", "CAD", "EUR", out convRateTest);
            Assert.AreEqual(0.66, convRateTest);
            Assert.AreEqual(0.66, res);

            res = ConversionRateManager.Convert("1", "CAD", "USD", out convRateTest);
            Assert.AreEqual(0.74, convRateTest);
            Assert.AreEqual(0.74, res);

            res = ConversionRateManager.Convert("1", "CAD", "GBP", out convRateTest);
            Assert.AreEqual(0.57, convRateTest);
            Assert.AreEqual(0.57, res);

            res = ConversionRateManager.Convert("1", "GBP", "RON", out convRateTest);
            Assert.AreEqual(5.56, convRateTest);
            Assert.AreEqual(5.56, res);

            res = ConversionRateManager.Convert("1", "GBP", "EUR", out convRateTest);
            Assert.AreEqual(1.16, convRateTest);
            Assert.AreEqual(1.16, res);

            res = ConversionRateManager.Convert("1", "GBP", "USD", out convRateTest);
            Assert.AreEqual(1.30, convRateTest);
            Assert.AreEqual(1.30, res);

            res = ConversionRateManager.Convert("1", "GBP", "CAD", out convRateTest);
            Assert.AreEqual(1.75, convRateTest);
            Assert.AreEqual(1.75, res);
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [TestCategory("WhiteBox")]
        public void ConvertSuccessTestSameCoin()
        {
            double convRateTest;
            var res = ConversionRateManager.Convert("25", "EUR", "EUR", out convRateTest);

            Assert.AreEqual(1, convRateTest);
            Assert.AreEqual(25, res);
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [TestCategory("BlackBox")]
        public void ConvertFailTest()
        {
            double convRateTest;
            var res = ConversionRateManager.Convert("1", "EUR", "RON", out convRateTest);

            Assert.AreNotEqual(55.21, convRateTest);
            Assert.AreNotEqual(4.31, res);
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [TestCategory("WhiteBox")]
        public void ConvertFailInputTest()
        {
            double convRateTest;
            var res = ConversionRateManager.Convert("1a", "EUR", "RON", out convRateTest);


            Assert.AreEqual(-1, convRateTest);
            Assert.AreEqual(-1, res);
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [ExpectedException(typeof(ArgumentNullException))]
        [TestCategory("WhiteBox")]
        public void ConvertTest_ThrowException()
        {
            double convRateTest;
            ConversionRateManager.Convert("", "EUR", "RON", out convRateTest);
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [TestCategory("WhiteBox")]
        public void ConvertTest_ThrowExceptionTryCatch()
        {
            try
            {
                double convRateTest;
                ConversionRateManager.Convert("", "EUR", "RON", out convRateTest);
            }
            catch (ArgumentNullException)
            {
                return;
            }

            Assert.Fail("This test should throw an exception!!");
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        public void GetInverseBool()
        {
            Assert.IsFalse(ConversionRate.Inverse);
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [TestCategory("WhiteBox")]
        public void SaveHistoryWhenFileExists()
        {
            var data = "TestingSaveHistory";
            ConversionRateManager.SaveHistory(data, _goodFileName);

            var result = File.ReadAllText(_goodFileName);

            Assert.IsTrue(result.Contains(data));
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [TestCategory("WhiteBox")]
        public void SaveHistoryWhenFileNotExists()
        {
            var data = "TestingSaveHistory";
            ConversionRateManager.SaveHistory(data, _badFileName);

            var result = File.ReadAllText(_badFileName);

            Assert.IsTrue(result.Contains(data));
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [TestCategory("WhiteBox")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SaveHistory_ThrowException()
        {
            ConversionRateManager.SaveHistory("");
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [TestCategory("BlackBox")]
        public void CompareCoinsSuccess()
        {
            var fromCall = ConversionRateManager.CompareCoins("EUR", "EUR");

            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [TestCategory("BlackBox")]
        public void CompareCoinsFail()
        {
            var fromCall = ConversionRateManager.CompareCoins("EUR", "CAD");

            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [Owner("Razvan Dorcioman")]
        [TestCategory("WhiteBox")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CompareCoins_ThrowException()
        {
            ConversionRateManager.CompareCoins("", "CAD");
        }

        #region Class Initialize and Cleanup

        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            tc.WriteLine("We are in Class Initialize Method!");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
        }

        #endregion

        #region Test Initialize and Cleanup

        [TestInitialize]
        public void TestInitialize()
        {
            ConversionRateManager = new ConversionRate();

            if (TestContext.TestName == nameof(FileNameDoesExist) ||
                TestContext.TestName == nameof(SaveHistoryWhenFileExists))
            {
                SetGoodFileName();
                if (!string.IsNullOrEmpty(_goodFileName))
                {
                    TestContext.WriteLine("Creating the file: " + _goodFileName);
                    File.AppendAllText(_goodFileName, "Lorem Ipsum Text");
                }
            }

            if (TestContext.TestName == nameof(FileNameDoesNotExist) ||
                TestContext.TestName == nameof(SaveHistoryWhenFileNotExists))
            {
                SetBadFileName();
                TestContext.WriteLine("Setting the bad file: " + _badFileName);
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (TestContext.TestName == nameof(FileNameDoesExist) ||
                TestContext.TestName == nameof(SaveHistoryWhenFileExists))
                if (!string.IsNullOrEmpty(_goodFileName))
                {
                    TestContext.WriteLine("Deleting the file: " + _goodFileName);
                    File.Delete(_goodFileName);
                }

            if (TestContext.TestName == nameof(FileNameDoesNotExist) ||
                TestContext.TestName == nameof(SaveHistoryWhenFileNotExists))
            {
                TestContext.WriteLine("Deleting the file: " + _badFileName);
                File.Delete(_badFileName);
            }
        }

        #endregion
    }
}
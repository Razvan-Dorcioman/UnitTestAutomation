using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.IO;

namespace AutomationTests.Test
{
    [TestClass]
    public class ConversionRateTest
    {

        private string _goodFileName;
        private string _badFileName;
        public TestContext TestContext { get; set; }
        public ConversionRate ConversionRateManager { get; set; }
        
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

            if (TestContext.TestName == nameof(FileNameDoesExist))
            {
                SetGoodFileName();
                if (!string.IsNullOrEmpty(_goodFileName))
                {
                    TestContext.WriteLine("Creating the file: " + _goodFileName);
                    File.AppendAllText(_goodFileName, "Lorem Ipsum Text");
                }
            }

            if (TestContext.TestName == nameof(FileNameDoesNotExist))
            {

            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (TestContext.TestName == nameof(FileNameDoesExist))
            {
                if (!string.IsNullOrEmpty(_goodFileName))
                {
                    TestContext.WriteLine("Deleting the file: " + _goodFileName);
                    File.Delete(_goodFileName);
                }
            }
        }
        #endregion

        public void SetGoodFileName()
        {
            _goodFileName = ConfigurationManager.AppSettings["GoodFileName"];
            if (_goodFileName.Contains("[AppPath]"))
            {
                _goodFileName = _goodFileName.Replace("[AppPath]",
                    Environment.GetFolderPath((Environment.SpecialFolder.ApplicationData)));
            }
        }

        public void SetBadFileName()
        {
            _badFileName = ConfigurationManager.AppSettings["BadFileName"];
            if (_badFileName.Contains("[AppPath]"))
            {
                _badFileName = _badFileName.Replace("[AppPath]",
                    Environment.GetFolderPath((Environment.SpecialFolder.ApplicationData)));
            }
        }

        [TestMethod]
        public void FileNameDoesExist()
        {
            bool fromCall;
            
            TestContext.WriteLine("Testing the file: " + _goodFileName);
            fromCall = ConversionRateManager.FileExists(_goodFileName);

            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            bool fromCall;

            SetBadFileName();
            TestContext.WriteLine("Setting the bad file: " + _badFileName);

            fromCall = ConversionRateManager.FileExists(_badFileName);
            
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            ConversionRateManager.FileExists("");
        }

        [TestMethod]
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
        public void ConvertSuccessTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ConvertFailTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ConvertTest_ThrowException()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ConvertTest_ThrowExceptionTryCatch()
        {
            Assert.Inconclusive();
        }
    }
}

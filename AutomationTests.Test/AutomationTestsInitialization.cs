using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationTests.Test
{
    /// <summary>
    /// Summary description for AutomationTestsInitialization
    /// </summary>
    [TestClass]
    public class AutomationTestsInitialization
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext tc)
        {
            tc.WriteLine("We are in the Assembly Initialize Method!!!");

            //initialize here

        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            //cleanup here

        }
    }
}

using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationTests.Test
{
    /// <summary>
    ///     Summary description for AutomationTestsInitialization
    /// </summary>
    [TestClass]
    [ExcludeFromCodeCoverage]
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
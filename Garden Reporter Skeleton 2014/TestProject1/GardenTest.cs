using Garden_Reporter_2013;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for GardenTest and is intended
    ///to contain all GardenTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GardenTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetAccountBalance
        ///</summary>
        [TestMethod()]
        public void GetAccountBalanceTest()
        {
            double gardenWidth = 0F; 
            double gardenHeight = 0F;
            string ownerName = "Bob";
            Garden target = new Garden(gardenWidth, gardenHeight, ownerName);

            target.AddCharge(15);
            target.AddCharge(5.5);
            target.AddCharge(10.25);

            double expected = 30.75;
            double actual;
            actual = target.GetAccountBalance();
            Assert.AreEqual(expected, actual);
        }
    }
}

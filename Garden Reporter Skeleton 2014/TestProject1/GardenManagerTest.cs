using Garden_Reporter_2013;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for GardenManagerTest and is intended
    ///to contain all GardenManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GardenManagerTest
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
        ///A test for AreaReporter
        ///</summary>
        [TestMethod()]
        public void AreaReporterTest()
        {

            GardenManager target = new GardenManager(); 
            Garden currentGarden = new Garden(10, 20, "Bob");
            string expected = "Bob           :  200.00";
            string actual;
            actual = target.AreaReporter(currentGarden);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ChargesReporter
        ///</summary>
        [TestMethod()]
        public void ChargesReporterTest()
        {
            GardenManager target = new GardenManager(); // TODO: Initialize to an appropriate value
            Garden currentGarden = new Garden(10, 20, "Bob");
            currentGarden.AddCharge(123.45);
            currentGarden.AddCharge(678.90);
            string expected = "Bob           :   $802.35";
            string actual;
            actual = target.ChargesReporter(currentGarden);
            Assert.AreEqual(expected, actual);
        }
    }
}

using Weather_Station;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace Weather_Station_Tests
{
    
    
    /// <summary>
    ///This is a test class for IObserverTest and is intended
    ///to contain all IObserverTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IObserverTest
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


        internal virtual IObserver CreateIObserver()
        {
            ListBox testListBox = new ListBox();
            ISubject testSubject = new Subject();
            // TODO: Instantiate an appropriate concrete class.
            IObserver target = new AverageReadings(testListBox, testSubject);
            return target;
        }

        /// <summary>
        ///A test for Compute
        ///</summary>
        [TestMethod()]
        public void ComputeTest()
        {
            IObserver target = CreateIObserver(); // TODO: Initialize to an appropriate value
            int newValue = 1; // TODO: Initialize to an appropriate value
            double avgValue = 0F; // TODO: Initialize to an appropriate value
            int count = 1; // TODO: Initialize to an appropriate value
            double expected = 2F; // TODO: Initialize to an appropriate value
            double actual;

            avgValue += target.Compute(newValue, avgValue, count);

            // Simulate adding new value
            newValue = 2;
            count++;

            avgValue += target.Compute(newValue, avgValue, count);

            // Simulate adding new value
            newValue = 3;
            count++;

            avgValue += target.Compute(newValue, avgValue, count);

            actual = avgValue;
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

using Clocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace ClocksTests
{
    
    
    /// <summary>
    ///This is a test class for Form1_DigitalTest and is intended
    ///to contain all Form1_DigitalTest Unit Tests
    ///</summary>
    [TestClass()]
    public class Form1_DigitalTest
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
        ///A test for Digital Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Clocks.exe")]
        public void Form1_DigitalConstructorTest()
        {
            Label digitalClock = new Label(); // TODO: Initialize to an appropriate value
            Form1_Accessor.Digital target = new Form1_Accessor.Digital(digitalClock);
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for Clocks.Form1.IClock.hide
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Clocks.exe")]
        public void hideTest()
        {
            Label param0 = new Label(); // TODO: Initialize to an appropriate value
            Form1_Accessor.IClock_Accessor target = new Form1_Accessor.Digital(param0); // TODO: Initialize to an appropriate value
            target.hide();
            
            bool expected = false;
            bool result = param0.Visible;

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        ///A test for Clocks.Form1.IClock.show
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Clocks.exe")]
        public void showTest()
        {
            Label param0 = new Label(); // TODO: Initialize to an appropriate value
            Form1_Accessor.IClock_Accessor target = new Form1_Accessor.Digital(param0); // TODO: Initialize to an appropriate value
            target.show();

            bool expected = true;
            bool result = param0.Visible;

            Assert.AreEqual(expected, result);
        }
    }
}

using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bridge_Tests
{
    
    
    /// <summary>
    ///This is a test class for BridgeTest and is intended
    ///to contain all BridgeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BridgeTest
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
        ///A test for bDeal_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void bDeal_ClickTest()
        {
            Bridge_Accessor target = new Bridge_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.bDeal_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for bSort_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void bSort_ClickTest()
        {
            Bridge_Accessor target = new Bridge_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.bSort_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}

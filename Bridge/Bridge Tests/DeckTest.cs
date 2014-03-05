using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bridge_Tests
{
    
    
    /// <summary>
    ///This is a test class for DeckTest and is intended
    ///to contain all DeckTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DeckTest
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
        ///A test for dealHand
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void dealHandTest()
        {
            Deck_Accessor target = new Deck_Accessor(); // TODO: Initialize to an appropriate value
            string cardinal = string.Empty; // TODO: Initialize to an appropriate value
            Hand_Accessor expected = null; // TODO: Initialize to an appropriate value
            Hand_Accessor actual;
            actual = target.dealHand(cardinal);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for dealHands
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void dealHandsTest()
        {
            Deck_Accessor target = new Deck_Accessor(); // TODO: Initialize to an appropriate value
            Hand_Accessor[] expected = null; // TODO: Initialize to an appropriate value
            Hand_Accessor[] actual;
            actual = target.dealHands();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

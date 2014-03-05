using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bridge_Tests
{
    
    
    /// <summary>
    ///This is a test class for CardTest and is intended
    ///to contain all CardTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CardTest
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
        ///A test for getRank
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void getRankTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Card_Accessor target = new Card_Accessor(param0); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.getRank();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getSuit
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void getSuitTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Card_Accessor target = new Card_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getSuit();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getValue
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void getValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Card_Accessor target = new Card_Accessor(param0); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.getValue();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getValueFromRank
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void getValueFromRankTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Card_Accessor target = new Card_Accessor(param0); // TODO: Initialize to an appropriate value
            int cardRank = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.getValueFromRank(cardRank);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

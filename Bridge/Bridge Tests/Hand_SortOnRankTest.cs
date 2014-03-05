using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bridge_Tests
{
    
    
    /// <summary>
    ///This is a test class for Hand_SortOnRankTest and is intended
    ///to contain all Hand_SortOnRankTest Unit Tests
    ///</summary>
    [TestClass()]
    public class Hand_SortOnRankTest
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
        ///A test for SortOnRank Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void Hand_SortOnRankConstructorTest()
        {
            Hand_Accessor.SortOnRank target = new Hand_Accessor.SortOnRank();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Compare
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void CompareTest()
        {
            Hand_Accessor.SortOnRank target = new Hand_Accessor.SortOnRank(); // TODO: Initialize to an appropriate value
            Card_Accessor a = null; // TODO: Initialize to an appropriate value
            Card_Accessor b = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Compare(a, b);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

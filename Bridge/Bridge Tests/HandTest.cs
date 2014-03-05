using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Bridge_Tests
{
    
    
    /// <summary>
    ///This is a test class for HandTest and is intended
    ///to contain all HandTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HandTest
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
        ///A test for Hand Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void HandConstructorTest()
        {
            string cardinal = string.Empty; // TODO: Initialize to an appropriate value
            List<Card_Accessor> cards = null; // TODO: Initialize to an appropriate value
            Hand_Accessor target = new Hand_Accessor(cardinal, cards);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CompareTo
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void CompareToTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Hand_Accessor target = new Hand_Accessor(param0); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CompareTo(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for calculateHCP
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void calculateHCPTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Hand_Accessor target = new Hand_Accessor(param0); // TODO: Initialize to an appropriate value
            target.calculateHCP();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for displayHand
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void displayHandTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Hand_Accessor target = new Hand_Accessor(param0); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            string[] actual;
            actual = target.displayHand();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getHCP
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void getHCPTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Hand_Accessor target = new Hand_Accessor(param0); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.getHCP();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getSuitCards
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void getSuitCardsTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Hand_Accessor target = new Hand_Accessor(param0); // TODO: Initialize to an appropriate value
            string suit = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getSuitCards(suit);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for sortIntoSuits
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bridge.exe")]
        public void sortIntoSuitsTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Hand_Accessor target = new Hand_Accessor(param0); // TODO: Initialize to an appropriate value
            target.sortIntoSuits();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}

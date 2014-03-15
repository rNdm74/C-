using Text_Encryptor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Text_Encyptor_Tests
{
    
    
    /// <summary>
    ///This is a test class for PlainTextTest and is intended
    ///to contain all PlainTextTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PlainTextTest
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
        ///A test for PlainText Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Text Encryptor.exe")]
        public void PlainTextConstructorTest()
        {
            PlainText_Accessor target = new PlainText_Accessor();
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for Encrypt
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Text Encryptor.exe")]
        public void EncryptTest()
        {
            PlainText_Accessor target = new PlainText_Accessor(); // TODO: Initialize to an appropriate value
            string text = "test"; // TODO: Initialize to an appropriate value
            string expected = "test"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Encrypt(text);
            Assert.AreEqual(expected, actual);
        }
    }
}

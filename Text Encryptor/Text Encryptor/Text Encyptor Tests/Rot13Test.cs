using Text_Encryptor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Text_Encyptor_Tests
{
    
    
    /// <summary>
    ///This is a test class for Rot13Test and is intended
    ///to contain all Rot13Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Rot13Test
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
        ///A test for Rot13 Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Text Encryptor.exe")]
        public void Rot13ConstructorTest()
        {
            Rot13_Accessor target = new Rot13_Accessor();
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for Encrypt
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Text Encryptor.exe")]
        public void EncryptTest()
        {
            Rot13_Accessor target = new Rot13_Accessor(); // TODO: Initialize to an appropriate value
            string text = "test"; // TODO: Initialize to an appropriate value
            string expected = "grfg"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Encrypt(text);
            Assert.AreEqual(expected, actual);
        }
    }
}

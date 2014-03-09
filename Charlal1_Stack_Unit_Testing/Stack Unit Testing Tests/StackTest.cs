using Stack_Unit_Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Stack_Unit_Testing_Tests
{
    
    
    /// <summary>
    ///This is a test class for StackTest and is intended
    ///to contain all StackTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StackTest
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

        #region Count()
        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void CountTestDefault()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);
            target.Push(item);
            target.Push(item);

            int expected = 3; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void CountTestEmptyStack()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void CountTestFullStack()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);

            int expected = 5; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count();
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region IsEmpty()
        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void IsEmptyTestStackEmpty()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value

            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsEmpty();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void IsEmptyTestStackHasItem()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);

            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsEmpty();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void IsEmptyTestAfterItemsPopped()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);
            item = target.Pop();

            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsEmpty();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void IsEmptyTestAfterFillingStackThenPoppingStack()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);
            item = target.Pop();
            item = target.Pop();
            item = target.Pop();
            item = target.Pop();
            item = target.Pop();

            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsEmpty();
            Assert.AreEqual(expected, actual);
        }
        #endregion
                
        #region Peek()
        [TestMethod()]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void PeekTestEmptyStack()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value

            string actual;
            actual = target.Peek();
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void PeekTestFullStack()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);

            string expected = "Hello"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Peek();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void PeekTestCheckDoesntRemoveItem()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);
            item = target.Peek();

            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void PeekTestHelperDefault()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);

            string expected = "Hello"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Peek();
            Assert.AreEqual(expected, actual);
        }
        #endregion
                        
        #region Pop()    
        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void PopTestDefault()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);
            item = target.Pop();

            int expected = 3; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void PopTestEmptyStack()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
           
            string actual;
            actual = target.Pop();
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void PopTestFullStack()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);
            item = target.Pop();

            int expected = 4; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void PopTestEmptyStackThenPush()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = target.Pop(); // TODO: Initialize to an appropriate value                
            item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);
            string actual;
            actual = target.Peek();
        }

        [TestMethod()]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void PopTestEmptyStackMultipleTimes()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = target.Pop(); // TODO: Initialize to an appropriate value                
            item = target.Pop();
            item = target.Pop();
            item = target.Pop();
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void PopTestFullNullStack()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = null; // TODO: Initialize to an appropriate value
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);

            string expected = null; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Pop();

            Assert.AreEqual(expected, actual);
        }
        #endregion
                
        #region Push()
        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void PushTestEmptyStack()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);

            string expected = "Hello"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Pop();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void PushTestItemsInStack()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);
            target.Push(item);

            string expected = "Hello"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Pop();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void PushTestFillStackWithStringArray()
        {
            string[] ARRAY = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };            
            Stack_Accessor<string> target = new Stack_Accessor<string>(ARRAY.Length); // TODO: Initialize to an appropriate value

            for (int i = 0; i < ARRAY.Length; i++)
            {
                target.Push(ARRAY[i]);
            }

            string expected = "Friday"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Pop();
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        [ExpectedException(typeof(System.StackOverflowException))]
        public void PushTestPushStackIsFullException()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = "Hello"; // TODO: Initialize to an appropriate value
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void PushTestPushNullFullStack()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            string item = null; // TODO: Initialize to an appropriate value
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);
            target.Push(item);

            string expected = null; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Pop();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void PushTestPushCastsStack()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value
            int item = 987654321; // TODO: Initialize to an appropriate value
            target.Push(item.ToString());
            target.Push(item.ToString());
            target.Push(item.ToString());
            target.Push(item.ToString());
            target.Push(item.ToString());

            string expected = "987654321"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Pop();
            Assert.AreEqual(expected, actual);
        }
        #endregion
                
        #region Constructor
        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void StackConstructorTestString()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<string> target = new Stack_Accessor<string>(param0); // TODO: Initialize to an appropriate value

            Assert.IsNotNull(target);
        }

        [TestMethod()]
        [DeploymentItem("Stack Unit Testing.exe")]
        public void StackConstructorTestInt()
        {
            int param0 = 5; // TODO: Initialize to an appropriate value
            Stack_Accessor<int> target = new Stack_Accessor<int>(param0); // TODO: Initialize to an appropriate value

            Assert.IsNotNull(target);
        }
        #endregion
    }
}

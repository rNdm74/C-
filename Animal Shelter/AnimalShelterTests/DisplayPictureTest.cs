using Animal_Shelter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AnimalShelterTests
{
    
    
    /// <summary>
    ///This is a test class for DisplayPictureTest and is intended
    ///to contain all DisplayPictureTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DisplayPictureTest
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
        ///A test for DisplayPicture Constructor
        ///</summary>
        [TestMethod()]
        public void DisplayPictureConstructorTest()
        {
            PictureBox[] pbPets = null; // TODO: Initialize to an appropriate value
            DisplayPicture target = new DisplayPicture(pbPets);
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for display
        ///</summary>
        [TestMethod()]
        public void displayTest()
        {
            PictureBox[] pbPets = new PictureBox[]{new PictureBox()}; // TODO: Initialize to an appropriate value
            DisplayPicture target = new DisplayPicture(pbPets); // TODO: Initialize to an appropriate value
            List<Animal> animals = new List<Animal>();
            string[] animalData = new string[]{"Spike","Cat"};
            animals.Add(new Animal(animalData));
            target.display(animals);
        }
    }
}

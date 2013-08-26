using imdbSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ImdbSearchTests
{
    
    
    /// <summary>
    ///This is a test class for ImdbSearchTest and is intended
    ///to contain all ImdbSearchTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ImdbSearchTest
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
        ///A test for single word movieFound
        ///</summary>
        [TestMethod()]
        public void movieSingleWordTest()
        {
            ImdbSearch target = new ImdbSearch(); // TODO: Initialize to an appropriate value
            string movieName = "Memento"; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.movieFound(movieName);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for multiple words movieFound
        ///</summary>
        [TestMethod()]
        public void movieMultipleWordsTest()
        {
            ImdbSearch target = new ImdbSearch(); // TODO: Initialize to an appropriate value
            string movieName = "The Lord of the rings"; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.movieFound(movieName);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for single word movieFound
        ///</summary>
        [TestMethod()]
        public void movieWrongTextTest()
        {
            ImdbSearch target = new ImdbSearch(); // TODO: Initialize to an appropriate value
            string movieName = "REWQ"; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.movieFound(movieName);
            Assert.AreEqual(expected, actual);
        }
    }
}

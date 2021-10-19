namespace FileDataTests
{
    using FileData;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test class for file processor tests.
    /// </summary>
    [TestClass]
    public class FileProcessorTests
    {
        /// <summary>
        /// The less arguments message
        /// </summary>
        private const string LESS_ARGUMENTS_MESSAGE = "Not enough argumanets passed";
        /// <summary>
        /// The invalid arguments message
        /// </summary>
        private const string Invalid_ARGUMENTS_MESSAGE = "Invalid arguments passed";
        /// <summary>
        /// The file processor
        /// </summary>
        public IFileProcessor fileProcessor = new FileProcessor();

        /// <summary>
        /// Verifies the null arguments.
        /// </summary>
        [TestMethod]
        public void VerifyNullArguments()
        {
            //Arrage
            string[] arguments = null;

            //Act
            string result = fileProcessor.ProcessInput(arguments);

            //Assert
            Assert.AreEqual(result, LESS_ARGUMENTS_MESSAGE);
        }

        /// <summary>
        /// Verifies the less arguments.
        /// </summary>
        [TestMethod]
        public void VerifyLessArguments()
        {
            //Arrage
            string[] arguments = new string[] { "-s" };

            //Act
            string result = fileProcessor.ProcessInput(arguments);

            //Assert
            Assert.AreEqual(result, LESS_ARGUMENTS_MESSAGE);
        }


        /// <summary>
        /// Verifies the size of the file.
        /// </summary>
        [TestMethod]
        public void VerifyFileSize()
        {
            //Arrage
            string[] arguments = new string[] { "-s", "C:Test" };

            //Act
            string result = fileProcessor.ProcessInput(arguments);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreNotEqual(result, LESS_ARGUMENTS_MESSAGE);
        }


        /// <summary>
        /// Verifies the file version.
        /// </summary>
        [TestMethod]
        public void VerifyFileVersion()
        {
            //Arrage
            string[] arguments = new string[] { "--v", "C:Test" };

            //Act
            string result = fileProcessor.ProcessInput(arguments);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreNotEqual(result, LESS_ARGUMENTS_MESSAGE);
        }



        /// <summary>
        /// Verifies the invalid argumment.
        /// </summary>
        [TestMethod]
        public void VerifyInvalidArgumment()
        {
            //Arrage
            string[] arguments = new string[] { "--t", "C:Test" };

            //Act
            string result = fileProcessor.ProcessInput(arguments);

            //Assert
            Assert.AreEqual(result, Invalid_ARGUMENTS_MESSAGE);
        }
    }
}

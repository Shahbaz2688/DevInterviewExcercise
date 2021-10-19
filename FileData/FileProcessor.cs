namespace FileData
{
    using System;
    using System.Linq;
    using ThirdPartyTools;

    /// <summary>
    /// Processes the file.
    /// </summary>
    /// <seealso cref="IFileProcessor" />
    public class FileProcessor : IFileProcessor
    {
        /// <summary>
        /// The file details
        /// </summary>
        private readonly FileDetails _fileDetails;

        /// <summary>
        /// The less arguments message
        /// </summary>
        private const string LESS_ARGUMENTS_MESSAGE = "Not enough argumanets passed";
        private const string Invalid_ARGUMENTS_MESSAGE = "Invalid arguments passed";

        /// <summary>
        /// Initializes a new instance of the <see cref="FileProcessor"/> class.
        /// </summary>
        public FileProcessor()
        {
            _fileDetails = new FileDetails();
        }

        /// <summary>
        /// Processes the input.
        /// </summary>
        /// <param name="arguments">The arguments.</param>
        public string ProcessInput(string[] arguments)
        {
            string result;
            if (arguments != null && arguments.Length > 1)
            {
                result = ProcessResult(arguments);
            }
            else
            {
                result = LESS_ARGUMENTS_MESSAGE;
            }
            return result;
        }

        /// <summary>
        /// Processes the result.
        /// </summary>
        /// <param name="arguments">The arguments.</param>
        /// <returns>The processed result.</returns>
        private string ProcessResult(string[] arguments)
        {
            string result = "";

            string firstArgument = arguments[0];
            string secondArgument = arguments[1];

            if (!string.IsNullOrWhiteSpace(firstArgument) && !string.IsNullOrWhiteSpace(secondArgument))
            {

                string[] versionTypes = GetVersionTypes();
                string[] sizeTypes = GetSizeTypes();

                if (versionTypes.Contains(firstArgument))
                {
                    result = _fileDetails.Version(secondArgument);
                }
                else if (sizeTypes.Contains(firstArgument))
                {
                    result = _fileDetails.Size(secondArgument).ToString();
                }
                else
                {
                    result = Invalid_ARGUMENTS_MESSAGE;
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the version types.
        /// </summary>
        /// <returns>The version types.</returns>
        private string[] GetVersionTypes()
        {
            return new string[]
            {
                "-v", "--v", "/v", "--version"
            };
        }

        /// <summary>
        /// Gets the size types.
        /// </summary>
        /// <returns>The size types.</returns>
        private string[] GetSizeTypes()
        {
            return new string[]
            {
                "-s", "--s", "/s", "--size"
            };
        }

    }
}

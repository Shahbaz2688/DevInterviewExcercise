using System;

namespace FileData
{
    /// <summary>
    /// The program class.
    /// </summary>
    public static class Program
    {
        /// <summary>s
        /// The file processor
        /// </summary>
        private static IFileProcessor fileProcessor = new FileProcessor();

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            string result = fileProcessor.ProcessInput(args);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}

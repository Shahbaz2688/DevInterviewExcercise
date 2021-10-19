namespace FileData
{
    /// <summary>
    /// The file processor interface.
    /// </summary>
    public interface IFileProcessor
    {
        /// <summary>
        /// Processes the input.
        /// </summary>
        /// <param name="arguments">The arguments.</param>
        string ProcessInput(string[] arguments);
    }
}
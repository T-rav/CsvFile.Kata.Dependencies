namespace CsvFile.Kata.Dependencies
{
    public interface IFileSystem
    {
        void WriteLine(string fileName, string line);
    }
}

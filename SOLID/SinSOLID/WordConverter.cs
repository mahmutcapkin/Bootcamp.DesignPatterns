namespace SOLID.SinSOLID
{
    public class WordConverter
    {
        public void ConvertToWord(File file)
        {
            if (file.FileExtension == "word")
            {
                Console.WriteLine($"{file.FileName} file converted to {file.FileExtension} format");
            }
            else
            {
                Console.WriteLine("file could not be converted");
            }

        }
    }
}

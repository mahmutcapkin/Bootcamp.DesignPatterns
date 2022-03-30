namespace SOLID.SinSOLID
{
    public class PdfConverter
    {
        public void ConvertToPdf(File file)
        {
            if (file.FileExtension == "pdf")
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

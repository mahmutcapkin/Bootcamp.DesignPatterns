namespace SOLID.SinSOLID
{
    public class ExcelConverter
    {
        public void ConvertToExcel(File file)
        {
            if (file.FileExtension == "excel")
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

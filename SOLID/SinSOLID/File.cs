namespace SOLID.SinSOLID
{
    //srp prensibine göre kohezyonu düşük olduğundan bu class'ın ayrılarak tek bir görevi yerine getirmesi gerekmektedir.
    public class File
    {
        public string? FileName { get; set; }
        public int FileSize { get; set; }
        public string? FileExtension { get; set; }

        //public void ConvertToPdf(File file)
        //{
        //    if (FileExtension == "pdf")
        //    {
        //        Console.WriteLine($"{FileName} file converted to {FileExtension} format");
        //    }
        //    else
        //    {
        //        Console.WriteLine("file could not be converted");
        //    }

        //}
        //public void ConvertToWord(File file)
        //{
        //    if (FileExtension == "word")
        //    {
        //        Console.WriteLine($"{FileName} file converted to {FileExtension} format");
        //    }
        //    else
        //    {
        //        Console.WriteLine("file could not be converted");
        //    }

        //}

        //public void ConvertToExcel(File file)
        //{
        //    if (FileExtension == "excel")
        //    {
        //        Console.WriteLine($"{FileName} file converted to {FileExtension} format");
        //    }
        //    else
        //    {
        //        Console.WriteLine("file could not be converted");
        //    }

        //}

        //public void SendFile(File file)
        //{
        //    Console.WriteLine($"{FileName} file sended");
        //}
    }
}

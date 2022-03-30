
using SOLID.SinSOLID;
using File = SOLID.SinSOLID.File;
using Converter = SOLID.OinSOLID.Converter;
using SOLID.OinSOLID;
using SOLID.LinSOLID;
using SOLID.IinSOLID;
using SOLID.DinSOLID;

// SRP
File file = new();
file.FileName = "testfiles";
file.FileSize = 120;
file.FileExtension = "pdf";

PdfConverter pdfConverter = new PdfConverter();
pdfConverter.ConvertToPdf(file);

ExcelConverter excelConverter = new ExcelConverter();
excelConverter.ConvertToExcel(file);

WordConverter wordConverter = new WordConverter();
wordConverter.ConvertToWord(file);
//////////////////

////OCP
Pdf pdf = new();
Converter converter = new Converter(pdf);
/////////////////


////LSP
void Logging(Logger logger)
{
    logger.Log();
}

CacheLogger cacheLogger = new CacheLogger();
Logging(cacheLogger);

FileLogger fileLogger = new FileLogger();
Logging(fileLogger);

/////////////////////

////ISP

Aircraft aircraft = new();
aircraft.Back();
aircraft.Forward();
aircraft.Rise();
Console.WriteLine("--------------");
Ship ship = new Ship();
ship.Back();
ship.Forward();
ship.Float();
///////////////////////


//DIP

ProductService productService = new(new Mysql());
productService.SaveProduct("test");

/////












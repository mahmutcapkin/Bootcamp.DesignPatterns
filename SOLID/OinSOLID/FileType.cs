namespace SOLID.OinSOLID;

    public abstract class FileType
    {
        public abstract void ConvertType();
    }

    //OCP'nin uygulanmadan önceki hali

    //public class FileType
    //{

    //}
    //public class Pdf : FileType
    //{
    //    public void Convert()
    //    {

    //    }
    //}

    //public class Word : FileType
    //{
    //    public void Convert()
    //    {

    //    }
    //}

    //public class Converter()
    //{
    //    public enum FileTypes
    //{
    //    pdf,
    //    word
    //}
    //public FileTypes _types;
    //private Word word;
    //private Pdf pdf;
    //public Converter(FileTypes types)
    //{
    //    _types = types;
    //    word = new Word();
    //    pdf = new Pdf();

    //}

    //private void WordConvert()
    //{
    //    word.FileConvert();
    //}

    //private void PdfConvert()
    //{
    //    pdf.FileConvert();
    //}

    //public void FileConvert()
    //{
    //    switch (_types)
    //    {
    //        case FileTypes.pdf:
    //            PdfConvert();
    //            break;
    //        case FileTypes.word:
    //            WordConvert();
    //            break;
    //        default:
    //            break;
    //    }
    //}
    //}







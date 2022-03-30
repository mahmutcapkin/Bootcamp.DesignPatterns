namespace SOLID.OinSOLID;

    public class Converter
    {
        private FileType _type;
        public Converter(FileType type)
        {
           _type=type;
        }
        public void FileConvert(FileType fileType)
        {
            _type.ConvertType();
        }
    }


using ExcelDataReader;
using System.Data;
using System.IO;

namespace AprLoader
{
    public class ExcelLoader
    {
        private IExcelDataReader dataReader;
        public DataSet DataSet;
        public ExcelLoader(string path)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);
            if (path.Contains(".xlsx"))
            {
                dataReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }
            else if (path.Contains(".xls"))
            {
                dataReader = ExcelReaderFactory.CreateBinaryReader(stream);
            }
            else
            {
                throw new InvalidDataException("Неверный формат файла! Допустимы только .xls и .xlsx");
            }
            DataSet = dataReader.AsDataSet();
            dataReader.Close();
            stream.Close();
        }
    }
}

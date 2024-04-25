using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    /// <summary>
    /// Bir excel dosyasından pdf raporu üretebilirsiniz.
    /// </summary>
    public class ReportGenerator
    {
        private string excelFilePath;

        public ReportGenerator(string excelFilePath)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(excelFilePath);
            if (!isValidFile(excelFilePath))
            {
                throw new ArgumentException("Excel dosyası yok veya uygun formatta değil!");

            }

        }


        bool isFileExists(string filePath) => File.Exists(excelFilePath);

        bool isValidFormat(string formatDetail) => true;

        bool isValidFile(string filePath) => isFileExists(filePath) && isValidFormat("format");

        /// <summary>
        /// Bu fonksiyon, belirtilen adrese rapor dosyasını pdf olarak kaydeder
        /// </summary>
        /// <param name="filePath">Dosyanın kaydedileceği adres ve dosya adını (.pdf uzantısı ile) giriniz.</param>
        public void Create(string filePath)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HuongDanThucHanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 1. Đọc và tạo tập tin dạng văn bản (Text File)

        // TODO: Hàm ghi và đọc file văn bản
        private void WriteReadText(string filename, string[] text)
        {

        }

        // TODO: Sự kiện khi nhấn nút Ghi/Đọc Text
        private void btnWriteReadText_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 2. Đọc tập tin JSON

        // TODO: Sự kiện khi nhấn nút Đọc JSON
        private void btnReadJSON_Click(object sender, EventArgs e)
        {

        }

        // TODO: Hàm nạp danh sách học sinh từ file JSON
        private List<StudentInfo> LoadJSON(string Path)
        {
            return new List<StudentInfo>();
        }

        #endregion

        #region 3. Đọc và Ghi tập tin XML

        // TODO: Sự kiện khi nhấn nút Đọc XML
        private void btnReadXML_Click(object sender, EventArgs e)
        {

        }

        // TODO: Hàm nạp danh sách sách từ file XML
        private List<BookInfo> LoadXML(string Path)
        {
            return new List<BookInfo>();
        }

        // TODO: Sự kiện nút Ghi XML bằng XmlWriter
        private void btnWriteXmlWriter_Click(object sender, EventArgs e)
        {

        }

        // TODO: Sự kiện nút Ghi XML bằng XmlSerializer
        private void btnWriteXmlSerializer_Click(object sender, EventArgs e)
        {

        }

        // TODO: Hàm Serialize danh sách sách ra file XML
        private static void SaveToXmlFile(List<Book> books, string fileName)
        {

        }

        #endregion

        #region Helper Methods

        // TODO: Hàm hỗ trợ lấy đường dẫn file
        private string GetFilePath(string fileName)
        {
            return fileName;
        }

        #endregion
    }
}

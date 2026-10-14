using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace HuongDanThucHanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 1. Đọc và tạo tập tin dạng văn bản (Text File)

        private void WriteReadText(string filename, string[] text)
        {
            File.WriteAllLines(filename, text);

            string result = "Đã ghi vào file '" + filename + "' thành công!\r\n\r\nNội dung file đọc lại:\r\n";
            foreach (string s in File.ReadAllLines(filename))
            {
                result += s + "\r\n";
            }

            MessageBox.Show(result);
        }

        private void btnWriteReadText_Click(object sender, EventArgs e)
        {
            string fileName = "sample_output.txt";
            string[] sampleText = new string[]
            {
                "Chào mừng đến với Lab 03 - Thao Tác Tập Tin!",
                "1. Tập tin văn bản (Text File)",
                "2. Tập tin JSON (Newtonsoft.Json)",
                "3. Tập tin XML (XmlDocument, XmlWriter, XmlSerializer)"
            };

            WriteReadText(fileName, sampleText);
        }

        #endregion

        #region 2. Đọc tập tin JSON

        private void btnReadJSON_Click(object sender, EventArgs e)
        {
            string noiDung = "";
            string duongDan = GetFilePath("students.json");

            if (!File.Exists(duongDan))
            {
                MessageBox.Show("Không tìm thấy tập tin " + duongDan);
                return;
            }

            List<StudentInfo> danhSach = LoadJSON(duongDan);
            for (int i = 0; i < danhSach.Count; i++)
            {
                StudentInfo info = danhSach[i];
                noiDung += "Sinh viên " + (i + 1) + " có MSSV: " + info.MSSV
                    + ", họ tên: " + info.Hoten + ", điểm TB: " + info.Diem + "\r\n";
            }
            MessageBox.Show(noiDung);
        }

        private List<StudentInfo> LoadJSON(string duongDan)
        {
            // StudentFile có cùng cấu trúc với tập tin students.json.
            string json = File.ReadAllText(duongDan);
            StudentFile? duLieu = JsonConvert.DeserializeObject<StudentFile>(json);
            if (duLieu != null && duLieu.sinhvien != null)
            {
                return duLieu.sinhvien;
            }

            return new List<StudentInfo>();
        }

        #endregion

        #region 3. Đọc và Ghi tập tin XML

        private void btnReadXML_Click(object sender, EventArgs e)
        {
            string duongDan = GetFilePath("books.xml");

            if (!File.Exists(duongDan))
            {
                MessageBox.Show("Không tìm thấy tập tin " + duongDan);
                return;
            }

            List<BookInfo> books = LoadXML(duongDan);
            string noiDung = "Danh mục sách (" + books.Count + " cuốn):\r\n\r\n";
            for (int i = 0; i < books.Count; i++)
            {
                BookInfo book = books[i];
                noiDung += "Sách " + (i + 1) + ":\r\n"
                    + " - Tên sách: " + book.Title + "\r\n"
                    + " - Tác giả: " + book.Author + "\r\n"
                    + " - Nhà xuất bản: " + book.Publisher + " (" + book.YearPublished + ")\r\n"
                    + " - Giá: $" + book.Price + "\r\n"
                    + " - ISBN: " + book.ISBN + "\r\n\r\n";
            }

            MessageBox.Show(noiDung);
        }

        private List<BookInfo> LoadXML(string duongDan)
        {
            List<BookInfo> list = new List<BookInfo>();
            XmlDocument doc = new XmlDocument();
            doc.Load(duongDan);

            XmlNode? catalog = doc.SelectSingleNode("catalog");
            if (catalog == null)
            {
                return list;
            }

            foreach (XmlNode node in catalog.ChildNodes)
            {
                if (node.Name != "book")
                {
                    continue;
                }

                string isbn = "";
                string namXuatBan = "";
                if (node.Attributes != null)
                {
                    XmlNode? maSach = node.Attributes["ISBN"];
                    XmlNode? nam = node.Attributes["yearpublished"];
                    if (maSach != null && maSach.Value != null)
                    {
                        isbn = maSach.Value;
                    }
                    if (nam != null && nam.Value != null)
                    {
                        namXuatBan = nam.Value;
                    }
                }

                int yearPublished;
                int.TryParse(namXuatBan, out yearPublished);

                string title = "";
                XmlNode? titleNode = node["title"];
                if (titleNode != null)
                {
                    title = titleNode.InnerText;
                }

                string firstName = "";
                string lastName = "";
                XmlNode? authorNode = node["author"];
                if (authorNode != null)
                {
                    XmlNode? firstNameNode = authorNode["first-name"];
                    XmlNode? lastNameNode = authorNode["last-name"];
                    if (firstNameNode != null)
                    {
                        firstName = firstNameNode.InnerText;
                    }
                    if (lastNameNode != null)
                    {
                        lastName = lastNameNode.InnerText;
                    }
                }
                string author = (firstName + " " + lastName).Trim();

                string publisher = "";
                XmlNode? publisherNode = node["publisher"];
                if (publisherNode != null)
                {
                    publisher = publisherNode.InnerText;
                }

                double price = 0;
                XmlNode? priceNode = node["price"];
                if (priceNode != null)
                {
                    double.TryParse(priceNode.InnerText, out price);
                }

                BookInfo book = new BookInfo(isbn, yearPublished, title, author, publisher, price);
                list.Add(book);
            }

            return list;
        }

        private void btnWriteXmlWriter_Click(object sender, EventArgs e)
        {
            string fileName = "books_writer_output.xml";

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "  ";

            using (XmlWriter writer = XmlWriter.Create(fileName, settings))
            {
                string pi = "type=\"text/xsl\" href=\"book.xsl\"";
                writer.WriteProcessingInstruction("xml-stylesheet", pi);
                writer.WriteDocType("book", null, null, "<!ENTITY h \"hardcover\">");
                writer.WriteComment("This is a book sample XML");
                writer.WriteStartElement("book");
                writer.WriteAttributeString("ISBN", "9831123212");
                writer.WriteAttributeString("yearpublished", "2002");
                writer.WriteElementString("author", "Mahesh Chand");
                writer.WriteElementString("title", "Visual C# Programming");
                writer.WriteElementString("price", "44.95");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }

            string content = File.ReadAllText(fileName);
            MessageBox.Show($"Đã tạo file '{fileName}' thành công bằng XmlWriter!\r\n\r\nNội dung file:\r\n{content}");
        }

        private void btnWriteXmlSerializer_Click(object sender, EventArgs e)
        {
            string fileName = "books_serialized_output.xml";

            List<Book> books = new List<Book>();
            books.Add(new Book("9831123212", "A Programmer's Guide to ADO .Net using C#", "Mahesh Chand", 44.99m, 2002));
            books.Add(new Book("9781484234", "Pro Entity Framework Core 1", "Adam Freeman", 44.99m, 2018));

            SaveToXmlFile(books, fileName);

            string content = File.ReadAllText(fileName);
            MessageBox.Show($"Đã serialize danh sách sách ra file '{fileName}' thành công!\r\n\r\nNội dung XML:\r\n{content}");
        }

        private static void SaveToXmlFile(List<Book> books, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, books);
            }
        }

        #endregion

        #region Helper Methods

        private string GetFilePath(string fileName)
        {
            if (File.Exists(fileName))
            {
                return fileName;
            }

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string fullPath = System.IO.Path.Combine(baseDir, fileName);
            if (File.Exists(fullPath))
            {
                return fullPath;
            }

            return fileName;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Serialization;
using System.IO;

namespace bookstore
{
    //класс хранилища книг
    [XmlRoot("Storage")]
    public class Storage
    {
        DataSet _dataset;

        //временный костыль
        [XmlArray("Books")]
        [XmlArrayItem("Book")]
        List<Book> _books;
        public Storage()
        {
            _dataset = new DataSet();
        }

        public void ReadDB(string dbpath)
        {
            //возможно поменять на boolean
            _dataset.ReadXml(dbpath);
        }


        public void WriteDb(List<Book> books, string dbpath)
        {
            // возможно поменять на boolean
            using (StreamWriter writer = new StreamWriter(dbpath))
            {
                _books = books;
                (new XmlSerializer(typeof(Storage))).Serialize(writer, this);
            }
        }

        public DataSet GetDataSet()
        {
            return _dataset;
        }
    }
}

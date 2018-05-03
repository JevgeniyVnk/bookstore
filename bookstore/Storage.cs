using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace bookstore
{
    //класс хранилища книг
    public class Storage
    {
        DataSet _dataset;
        public Storage()
        {
            _dataset = new DataSet();
        }

        public void ReadDB(string dbpath)
        {
            _dataset.ReadXml(dbpath);
        }

        public DataSet GetDataSet()
        {
            return _dataset;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace bookstore
{
    
    class Provider
    {
        private Storage _storage;
        private List<Book> _books;

        public Book GetBook(int index) => index >= 0 && index < _books.Count ? _books[index] : null;

        public Provider()
        {    
            _storage = new Storage();
            _books = new List<Book>();
        }

        public void PrepareBookCollection()
        {
            DataSet ds = GetDataSet();
            //надеемся, что не получим инвалид каст
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string name = Convert.ToString(row["name"]);
                double price = Convert.ToDouble(row["price"]);
                string author = row["author"]?.ToString();
                string describtion = row["describtion"]?.ToString();
                int count = Convert.ToInt32(row["count"]);
                _books.Add(new Book(name, count, price, author, describtion));
            }
        }
        /// <summary>
        ///асинхронно считывает инфу из базы
        ///и пихает все в список книг
        /// </summary>
        /// <returns></returns>
  
        public async Task ReadDbData(string login, string password, string bdpath)
        {
            try
            {
                await Task.Run(() => _storage.ReadDB(bdpath));
                await Task.Run(() => PrepareBookCollection());
            }
            catch
            {
                throw new Exception("Произошла ошибка при чтении данных из бд");
            }
        }

        public DataSet GetDataSet()
        {
            return _storage.GetDataSet();
        }

        public async Task WriteDbData(/*тут чето будет*/)
        {
            //TODO асинхронно обновить xml согласно списку книг
            //await Task.Run(() =>)
        }
    }
}

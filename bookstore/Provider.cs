﻿using System;
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
        public Provider()
        {    
            _storage = new Storage();
        }

        /// <summary>
        ///асинхронно подрубается к базе
        /// </summary>
        /// <returns></returns>
  
        public async Task ReadDbData(string login, string password, string bdpath)
        {
            await Task.Run(() => _storage.ReadDB(bdpath));
        }

        public async Task WriteDbData(/*тут чето будет*/)
        {
            //await Task.Run(() =>)
        }
    }
}

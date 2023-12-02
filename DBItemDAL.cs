using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OM2
{
    internal class DBItemDAL<T> where T : IID
    {
        private int counter = 1;

        public List<T> Items { get; set; } = new List<T>();

        public int Add(T item)
        {
            item.Id = counter++;
            Items.Add(item);

            return item.Id;
        }
    }
}
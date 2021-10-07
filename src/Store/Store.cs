using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DEBUG
using System.Windows.Forms;

namespace CourseCrawler
{
    internal class Store
    {
        private Store() 
        {
            _box = new();
        }

        private static readonly Lazy<Store> lazy = new Lazy<Store>(() => new Store());

        private readonly Dictionary<string, dynamic> _box;

        public static Store Instance 
        {
            get => lazy.Value;
        }

        public bool Exist(string storeItemName)
        {
            return _box.ContainsKey(storeItemName);
        }

        public T Use<T>(string storeItemName)
        {
            bool hasItem = _box.TryGetValue(storeItemName, out var item);
            if (!hasItem) throw new KeyNotFoundException($"[ERR][Store.Use]: Item name: {storeItemName} not found in the store!");
            return item;
        }

        public void Update(string storeItemName, dynamic item)
        {
            if (Exist(storeItemName))
            {
                _box[storeItemName.Trim()] = item;
            }
            else
            {
                _box.Add(storeItemName.Trim(), item);
            }
        }
    }
}

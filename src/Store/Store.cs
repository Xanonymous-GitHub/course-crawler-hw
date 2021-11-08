using System;
using System.Collections.Generic;

namespace CourseCrawler
{
    public class Store
    {
        private Store() 
        {
            _box = new();
        }

        private static readonly Lazy<Store> lazy = new(() => new());

        private readonly ObservableDictionary<string, dynamic> _box;

        public static Store Instance 
        {
            get => lazy.Value;
        }

        // Exist
        public bool Exist(string storeItemName)
        {
            return _box.ContainsKey(storeItemName);
        }

        // Use
        public T Use<T>(string storeItemName)
        {
            bool hasItem = _box.TryGetValue(storeItemName, out var item);
            if (!hasItem) throw new KeyNotFoundException($"[ERR][Store.Use]: Item name: {storeItemName} not found in the store!");
            return item;
        }

        // Update
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

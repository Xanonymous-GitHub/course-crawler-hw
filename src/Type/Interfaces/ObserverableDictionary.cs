﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;

namespace CourseCrawler
{
    [DebuggerDisplay("Count={Count}")]
    public class ObservableDictionary<TKey, TValue> :
        ICollection<KeyValuePair<TKey, TValue>>, IDictionary<TKey, TValue>,
        INotifyCollectionChanged, INotifyPropertyChanged
    {
        readonly IDictionary<TKey, TValue> dictionary;

        /// <summary>Event raised when the collection changes.</summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged = (sender, args) => { };

        /// <summary>Event raised when a property on the collection changes.</summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, args) => { };

        public bool ShouldNotifyChanges = true;

        /// <summary>
        /// Initializes an instance of the class.
        /// </summary>
        public ObservableDictionary() : this(new Dictionary<TKey, TValue>()) { }

        /// <summary>
        /// Initializes an instance of the class using another dictionary as 
        /// the key/value store.
        /// </summary>
        public ObservableDictionary(IDictionary<TKey, TValue> dictionary)
        {
            this.dictionary = dictionary;
        }

        // DirectlyNotifyPropertyChanged
        public void DirectlyNotifyPropertyChanged()
        {
            if (ShouldNotifyChanges)
                PropertyChanged(this, new(nameof(dictionary.Values)));
        }

        // AddWithNotification
        void AddWithNotification(KeyValuePair<TKey, TValue> item) => AddWithNotification(item.Key, item.Value);

        // AddWithNotification
        void AddWithNotification(TKey key, TValue value)
        {
            dictionary.Add(key, value);

            if (ShouldNotifyChanges)
            {
                CollectionChanged(this, new(NotifyCollectionChangedAction.Add, new KeyValuePair<TKey, TValue>(key, value)));
                PropertyChanged(this, new(nameof(dictionary.Count)));
                PropertyChanged(this, new(nameof(dictionary.Keys)));
                PropertyChanged(this, new(nameof(dictionary.Values)));
            }
        }

        // RemoveWithNotification
        bool RemoveWithNotification(TKey key)
        {
            if (dictionary.TryGetValue(key, out TValue value) && dictionary.Remove(key))
            {
                if (ShouldNotifyChanges)
                {
                    CollectionChanged(this, new(NotifyCollectionChangedAction.Remove, new KeyValuePair<TKey, TValue>(key, value)));
                    PropertyChanged(this, new(nameof(dictionary.Count)));
                    PropertyChanged(this, new(nameof(dictionary.Keys)));
                    PropertyChanged(this, new(nameof(dictionary.Values)));
                }

                return true;
            }

            return false;
        }

        // UpdateWithNotification
        void UpdateWithNotification(TKey key, TValue value)
        {
            if (dictionary.TryGetValue(key, out TValue existing))
            {
                dictionary[key] = value;

                if (ShouldNotifyChanges)
                {
                    CollectionChanged(this, new(NotifyCollectionChangedAction.Replace,
                            new KeyValuePair<TKey, TValue>(key, value),
                            new KeyValuePair<TKey, TValue>(key, existing)
                        )
                    );

                    PropertyChanged(this, new(nameof(dictionary.Values)));
                }
            }
            else
            {
                AddWithNotification(key, value);
            }
        }

        /// <summary>
        /// Allows derived classes to raise custom property changed events.
        /// </summary>
        protected void RaisePropertyChanged(PropertyChangedEventArgs args)
        {
            if (ShouldNotifyChanges)
                PropertyChanged(this, args);
        }

        #region IDictionary<TKey,TValue> Members

        /// <summary>
        /// Adds an element with the provided key and value to the <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </summary>
        /// <param name="key">The object to use as the key of the element to add.</param>
        /// <param name="value">The object to use as the value of the element to add.</param>
        public void Add(TKey key, TValue value)
        {
            AddWithNotification(key, value);
        }

        /// <summary>
        /// Determines whether the <see cref="T:System.Collections.Generic.IDictionary`2" /> contains an element with the specified key.
        /// </summary>
        /// <param name="key">The key to locate in the <see cref="T:System.Collections.Generic.IDictionary`2" />.</param>
        /// <returns>
        /// true if the <see cref="T:System.Collections.Generic.IDictionary`2" /> contains an element with the key; otherwise, false.
        /// </returns>
        public bool ContainsKey(TKey key) => dictionary.ContainsKey(key);

        /// <summary>
        /// Gets an <see cref="T:System.Collections.Generic.ICollection`1" /> containing the keys of the <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.Generic.ICollection`1" /> containing the keys of the object that implements <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
        public ICollection<TKey> Keys
        {
            get => dictionary.Keys;
        }

        /// <summary>
        /// Removes the element with the specified key from the <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </summary>
        /// <param name="key">The key of the element to remove.</param>
        /// <returns>
        /// true if the element is successfully removed; otherwise, false.  This method also returns false if <paramref name="key" /> was not found in the original <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </returns>
        public bool Remove(TKey key) => RemoveWithNotification(key);

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key whose value to get.</param>
        /// <param name="value">When this method returns, the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value" /> parameter. This parameter is passed uninitialized.</param>
        /// <returns>
        /// true if the object that implements <see cref="T:System.Collections.Generic.IDictionary`2" /> contains an element with the specified key; otherwise, false.
        /// </returns>
        public bool TryGetValue(TKey key, out TValue value) => dictionary.TryGetValue(key, out value);

        /// <summary>
        /// Gets an <see cref="T:System.Collections.Generic.ICollection`1" /> containing the values in the <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.Generic.ICollection`1" /> containing the values in the object that implements <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
        public ICollection<TValue> Values
        {
            get => dictionary.Values;
        }

        /// <summary>
        /// Gets or sets the element with the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public TValue this[TKey key]
        {
            get => dictionary[key];
            set { UpdateWithNotification(key, value); }
        }

        #endregion

        #region ICollection<KeyValuePair<TKey,TValue>> Members

        // ICollection
        void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
        {
            AddWithNotification(item);
        }

        // ICollection
        void ICollection<KeyValuePair<TKey, TValue>>.Clear()
        {
            dictionary.Clear();

            if (ShouldNotifyChanges)
            {
                CollectionChanged(this, new(NotifyCollectionChangedAction.Reset));
                PropertyChanged(this, new(nameof(dictionary.Count)));
                PropertyChanged(this, new(nameof(dictionary.Keys)));
                PropertyChanged(this, new(nameof(dictionary.Values)));
            }
        }

        // ICollection
        bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item) => dictionary.Contains(item);

        // ICollection
        void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            dictionary.CopyTo(array, arrayIndex);
        }

        // ICollection
        int ICollection<KeyValuePair<TKey, TValue>>.Count
        {
            get => dictionary.Count;
        }

        // ICollection
        bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
        {
            get => dictionary.IsReadOnly;
        }

        // ICollection
        bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item) => RemoveWithNotification(item.Key);

        #endregion

        #region IEnumerable<KeyValuePair<TKey,TValue>> Members


        // IEnumerator
        IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() => dictionary.GetEnumerator();

        // IEnumerator
        IEnumerator IEnumerable.GetEnumerator() => dictionary.GetEnumerator();

        #endregion
    }
}

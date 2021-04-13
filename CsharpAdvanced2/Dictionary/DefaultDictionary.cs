﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionary
{
    public class DefaultDictionary<TKey, TValue> : IDictionary<TKey, TValue> where TKey : notnull
    {
        private readonly IDictionary<TKey, TValue> _innerDictionary
            = new Dictionary<TKey, TValue>();

        readonly Func<TValue> defaultFactory;

        public DefaultDictionary(Func<TValue> init)
        {
            defaultFactory = init;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return _innerDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public virtual void Add(KeyValuePair<TKey, TValue> item)
        {
            _innerDictionary.Add(item);
        }

        public void Clear()
        {
            _innerDictionary.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return _innerDictionary.Contains(item);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            _innerDictionary.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return _innerDictionary.Remove(item);
        }

        public int Count => _innerDictionary.Count;
        public bool IsReadOnly => _innerDictionary.IsReadOnly;
        public bool ContainsKey(TKey key)
        {
            return _innerDictionary.ContainsKey(key);
        }

        public virtual void Add(TKey key, TValue value)
        {
            _innerDictionary.Add(key, value);
        }

        public bool Remove(TKey key)
        {
            return _innerDictionary.Remove(key);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return _innerDictionary.TryGetValue(key, out value);
        }

        public virtual TValue this[TKey key]
        {
            get => _innerDictionary[key] = defaultFactory();
            set => _innerDictionary[key] = value;
        }

        public ICollection<TKey> Keys => _innerDictionary.Keys;
        public ICollection<TValue> Values => _innerDictionary.Values;
    }
}
/*
 * CNXT-API
 *
 * The CNXT-API is developed by Rodenstock GmbH to integrate data from measurement devices such as DNEye<sup>®</sup> Scanner, Rodenstock Fundus Scanner, and ImpressionIST<sup>®</sup> into 3rd party applications as well as into several applications of Rodenstock such as WinFit, Rodenstock Consulting etc. If you have any feedback then please feel free to contact us via email. Copyright © Rodenstock GmbH 2022
 *
 * The version of the OpenAPI document: 1.5.0
 * Contact: cnxt@rodenstock.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CNXT.Connector.Client.Client
{
    public class ReadOnlyDictionary<T, K> : IDictionary<T, K>
    {
        private IDictionary<T, K> _dictionaryImplementation;
        public IEnumerator<KeyValuePair<T, K>> GetEnumerator()
        {
            return _dictionaryImplementation.GetEnumerator();
        }

        public ReadOnlyDictionary()
        {
            _dictionaryImplementation = new Dictionary<T, K>();
        }

        public ReadOnlyDictionary(IDictionary<T, K> dictionaryImplementation)
        {
            if (dictionaryImplementation == null) throw new ArgumentNullException("dictionaryImplementation");
            _dictionaryImplementation = dictionaryImplementation;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _dictionaryImplementation).GetEnumerator();
        }

        public void Add(KeyValuePair<T, K> item)
        {
            throw new ReadonlyOperationException("This instance is readonly.");
        }

        public void Clear()
        {
            throw new ReadonlyOperationException("This instance is readonly.");
        }

        public bool Contains(KeyValuePair<T, K> item)
        {
            return _dictionaryImplementation.Contains(item);
        }

        public void CopyTo(KeyValuePair<T, K>[] array, int arrayIndex)
        {
            _dictionaryImplementation.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<T, K> item)
        {
            throw new ReadonlyOperationException("This instance is readonly.");
        }

        public int Count
        {
            get { return _dictionaryImplementation.Count; }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        public void Add(T key, K value)
        {
            throw new ReadonlyOperationException("This instance is readonly.");
        }

        public bool ContainsKey(T key)
        {
            return _dictionaryImplementation.ContainsKey(key);
        }

        public bool Remove(T key)
        {
            throw new ReadonlyOperationException("This instance is readonly.");
        }

        public bool TryGetValue(T key, out K value)
        {
            return _dictionaryImplementation.TryGetValue(key, out value);
        }

        public K this[T key]
        {
            get { return _dictionaryImplementation[key]; }
            set
            {
                throw new ReadonlyOperationException("This instance is readonly.");

            }
        }

        public ICollection<T> Keys
        {
            get { return _dictionaryImplementation.Keys; }
        }

        public ICollection<K> Values
        {
            get { return _dictionaryImplementation.Values; }
        }
    }

    [Serializable]
    public class ReadonlyOperationException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public ReadonlyOperationException()
        {
        }

        public ReadonlyOperationException(string message) : base(message)
        {
        }

        public ReadonlyOperationException(string message, Exception inner) : base(message, inner)
        {
        }

        protected ReadonlyOperationException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}

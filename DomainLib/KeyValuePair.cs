using System;

namespace DomainLib
    {
        public class KeyValuePair<TKey, TValue> :
            ICustomKey<TKey>
            , IEquatable<KeyValuePair<TKey, TValue>>
        {
            public bool Equals(KeyValuePair<TKey, TValue> other)
            {
                return false;
            }

            public TKey ID => default;
            // public int ID => default;

            public override bool Equals(object obj)
            {
                return false;
            }

            public override int GetHashCode()
            {
                return 0;
            }
        }
}
using System;
using DomainLib;

namespace CatelFodyNullException
{
    /// <summary>
    /// Same as <see cref="KeyValuePair{TKey,TValue}"/>
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class AssemblyKeyValuePair<TKey, TValue> :
        ICustomKey<TKey>
        , IEquatable<AssemblyKeyValuePair<TKey, TValue>>
    {
        public bool Equals(AssemblyKeyValuePair<TKey, TValue> other)
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
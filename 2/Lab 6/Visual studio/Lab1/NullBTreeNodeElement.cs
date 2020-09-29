using System;

namespace BPlusTree
{
    //підвищення елементу
    public class NullBTreeNodeElement<T> : BTreeNodeElement<T> where T : class, IComparable
    {
        public NullBTreeNodeElement() : base(null)
        {
        }
    }
}
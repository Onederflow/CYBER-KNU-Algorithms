using System;

namespace BPlusTree
{
    //підвищення класу
    public interface IPromotionListener<T> where T : class, IComparable
    {
        void RootIs(BTreeNode<T> node);
    }
}
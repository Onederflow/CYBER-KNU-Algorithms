using System;
using System.Collections.Generic;

namespace BPlusTree
{
    //початковий клас дерева. Контролює інші підкласи
    public class BTree<T> : IPromotionListener<T> where T : class, IComparable
    {
        //корінь
        public BTreeNode<T> root;

        //інійіалізація
        public BTree(int order)
        {
            root = new BTreeNode<T>(order, this);
        }
        //фікс. Не видаляти!
        #region IPromotionListener<T> Members

        //новий корінь
        public void RootIs(BTreeNode<T> node)
        {
            root = node;
        }
        //тд
        #endregion
        //вставка елемента
        public void Insert(T value)
        {
            var node = root.Find(value);
            node.Insert(value);
        }
        //елемент в строку(для коректрого виводу в консоль)
        public override string ToString()
        {
            return root.ToString();
        }
        //пошук елемента
        public BTreeNodeElement<T> Search(T searchKey)
        {
            return root.Search(searchKey);
        }
    }
}
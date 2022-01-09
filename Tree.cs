using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Tree<T>
        where T:IComparable <T>
    {
        public Node<T> Root
        {
            get;
            set;
        }
        public int Count
        {
            get;
            set;
        }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }

            Root.Add(data);
            Count++;
        }

        public void Add(T data, string name, string nameTest, string dateTest)
        {
            if (Root == null)
            {
                Root = new Node<T>(data, name, nameTest, dateTest);
                Count = 1;
                return;
            }

            Root.Add(data, name, nameTest, dateTest);
            Count++;
        }

        public List<T> InOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return InOrder(Root);
        }
        public List<string> InOrderFull()
        {
            if (Root == null)
            {
                return new List<string>();
            }

            return InOrderFull(Root);
        }

        public List<T> PreOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return PreOrder(Root);
        }

        public List<T> PostOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return PostOrder(Root);
        }

        private List<T> PreOrder(Node<T> node)
        {
            var list = new List<T>();
            
            if (node != null)
            {
                list.Add(node.Data);

                if (node.Left != null)
                {
                    list.AddRange(PreOrder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(PreOrder(node.Right));
                }
            }

            return list;
        }

        private List<T> PostOrder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {

                if (node.Left != null)
                {
                    list.AddRange(PostOrder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(PostOrder(node.Right));
                }

                list.Add(node.Data);
            }

            return list;
        }

        private List<T> InOrder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {

                if (node.Left != null)
                {
                    list.AddRange(InOrder(node.Left));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(InOrder(node.Right));
                }

            }

            return list;
        }
        private List<string> InOrderFull(Node<T> node)
        {
            var list = new List<string>();

            if (node != null)
            {

                if (node.Left != null)
                {
                    list.AddRange(InOrderFull(node.Left));
                }

                if (node.infoTestStudent != null)
                {
                    list.Add(node.Data.ToString() + "   " + node.infoTestStudent.Name +
                        " " + node.infoTestStudent.NameTest +
                        " " + node.infoTestStudent.DateTest);
                }
                else
                {
                    list.Add(node.Data.ToString());
                }

                if (node.Right != null)
                {
                    list.AddRange(InOrderFull(node.Right));
                }

            }

            return list;
        }
    }
}

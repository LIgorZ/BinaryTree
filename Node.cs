using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BinaryTree
{
    public class InfoTestStudent
    {
        public string Name
        {
            get;
            set;
        }
        public string NameTest
        {
            get;
            set;
        }
        public string DateTest
        {
            get;
            set;
        }
    }
    public class Node<T> 
        where T : IComparable<T>
    {
        public T Data
        {
            get;
            set;
        }
        public InfoTestStudent infoTestStudent;
        public Node<T> Left
        {
            get;
            set;
        }
        public Node<T> Right
        {
            get;
            set;
        }
        public Node(T data)
        {
            Data = data;
        }

        public Node (T data, string name, string nameTest, string dateTest)
        {
            infoTestStudent = new InfoTestStudent();
            Data = data;
            infoTestStudent.Name = name;
            infoTestStudent.NameTest = nameTest;
            infoTestStudent.DateTest = dateTest;
        }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }
        public void Add(T data, string name, string nameTest, string dateTest)
        {
            var node = new Node<T>(data, name, nameTest, dateTest);

            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(data, name, nameTest, dateTest);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data, name, nameTest, dateTest);
                }
            }
        }
        public int CompareTo([AllowNull] T other)
        {
            return Data.CompareTo(other);
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

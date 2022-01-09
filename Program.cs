using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NET.C#.11 Коллекции и обобщенные типы. Задание 1");

            var tree = new Tree<int>();
            tree.Add(5, "Иван Грозный", "Государство и право", "XVI век");
            tree.Add(7, "Владимир Ленин", "Туризм", "XX век");
            tree.Add(1, "Цезарь", "Математика", "I век до нэ");
            tree.Add(2, "Роман", "Химия", "15/11/2021");
            tree.Add(6, "Максим", "Физика", "11/10/2020");
            tree.Add(8, "Федор", "История", "2/04/2018");
            tree.Add(3, "Ли Сы", "Вирусология", "18/11/2019");

            Console.WriteLine("Вывод преордер");
            foreach (var item in tree.PreOrder())
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            Console.WriteLine("Вывод постордер");
            foreach (var item in tree.PostOrder())
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            Console.WriteLine("Вывод инордер");
            foreach (var item in tree.InOrder())
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Оценка   ФИО    Название теста   Дата сдачи теста");

            foreach (var item in tree.InOrderFull())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("NET.C#.11 Коллекции и обобщенные типы. Задание 2");
            Console.WriteLine("Реализация представлена в ClassIerarhy.cs");

            Console.ReadLine();


        }
    }
}

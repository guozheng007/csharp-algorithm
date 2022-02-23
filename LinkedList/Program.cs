using System;
using LinkedList.Case1;
using LinkedList.Case2;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Case1-单项链表建立
            /*
            int num;
            int score;
            string name;
            Console.WriteLine("请输入5位学生的数据： ");
            Case1.LinkedList list = new();

            for (int i = 0; i <= 5; i++)
            {
                Console.Write("请输入学号： ");
                num = int.Parse(Console.ReadLine());
                Console.Write("请输入姓名： ");
                name = Console.ReadLine();
                Console.Write("请输入成绩： ");
                score = int.Parse(Console.ReadLine());
                list.Insert(num, name, score);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("学 生 成 绩 ");
            Console.WriteLine("学号 姓名 成绩 =============");

            list.Print();
            Console.ReadKey();
            */
            #endregion

            #region Case2-单项链表删除
            /*
            Random rand = new Random();
            StudentLinkedList list = new();
            int i, j;
            int[,] data = new int[12, 10];
            string[] name = new string[] { "Allen", "Scott", "Marry", "Jon", "Mark", "Ricky", "Lisa", "Jasica", "Hanson", "Amy", "Bob", "Jack" };

            Console.WriteLine("学号 成绩  学号 成绩  学号 成绩  学号  成绩\n ");

            for (i = 0; i < 12; i++)
            {
                data[i, 0] = i + 1;
                data[i, 1] = (Math.Abs(rand.Next(50))) + 50;
                list.Insert(data[i, 0], name[i], data[i, 1]);
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write($"[{data[j * 3 + i, 0]}]  [{data[j * 3 + i, 1]}]  ");
                }
                Console.WriteLine();
            }

            while (true)
            {
                Console.Write("请输入要删除成绩的学生学号，结束输入-1； ");
                int findword = int.Parse(Console.ReadLine());

                if (findword == -1)
                {
                    break;
                }
                else
                {
                    Node current = new(list.first.data, list.first.names, list.first.np)
                    {
                        next = list.first.next
                    };
                    while (current.data != findword)
                    {
                        current = current.next;
                    }

                    list.Delete(current);
                }

                Console.WriteLine("删除后成绩的链表，请注意！要删除的成绩其学生的学号必须在此链表中\n");

                list.Print();
            }

            Console.ReadKey(); 
            */
            #endregion

            #region Case3-单项链表新增
            /*
            Case3.LinkedList list1 = new();
            Case3.LinkedList list2 = new();
            Case3.Node node1 = new(5);
            Case3.Node node2 = new(6);

            list1.Insert(node1);
            list2.Insert(node2);

            Case3.Node node3 = new(7);
            Case3.Node node4 = new(8);

            list2.Insert(node3);
            list2.Insert(node4);

            list1.Concatenate(list1, list2);
            list1.Print();
            Console.ReadKey();
            */
            #endregion

            #region Case4-单链表更新
            /*
            Case4.LinkedList list1 = new();
            Case4.Node node1 = new(100,"菠萝",1000);
            Case4.Node node2 = new(90, "小明", 1001);
            Case4.Node node3 = new(80, "小刚", 1002);
            Case4.Node node4 = new(70, "小花", 1003);

            list1.Insert(node1);
            list1.Insert(node2);
            list1.Insert(node3);
            list1.Insert(node4);

            list1.Print();

            Case4.Node updateNode = new(66, "菠萝", 1000);
            list1.Update(updateNode);

            list1.Print();

            Console.ReadKey();
            */
            #endregion

            #region LeetCode

            #endregion
        }
    }
}

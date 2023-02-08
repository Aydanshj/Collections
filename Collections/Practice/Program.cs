using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

namespace HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(5);
            arrayList.Add(30);
            arrayList.Add(52);
            arrayList.Add("miray");
            arrayList.Add('a');
  
            arrayList.RemoveAt(2);

            ArrayList newArrList = new ArrayList();
            newArrList.AddRange(arrayList);

            newArrList.Add(100);
            newArrList.Add('B');

            newArrList.Reverse();

            Console.WriteLine(arrayList.Count);

            foreach (var item in newArrList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Queue");
            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue('a');
            queue.Enqueue("Miray");

            Console.WriteLine($"next: {queue.Peek()}");
            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Stack");

            Stack stack = new Stack();

            stack.Push(9);
            stack.Push(12);
            stack.Push(25);
            stack.Push("20");
            stack.Push("40");
            stack.Push('A');

            Console.WriteLine($"next: {stack.Peek()}");
            Console.WriteLine($"out of : {stack.Pop()}");
            Console.WriteLine($"out of: {stack.Pop()}");


            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            SortedList sortedList = new SortedList();

            sortedList.Add("M", "Miray");
            sortedList.Add("A10", 'c');
            sortedList.Add("A30", 20);

            Console.WriteLine(sortedList["100"]);

            List<Student> list = new List<Student>();

            var std = new Student { GroupNo = "P123", Name = "Jony" };

            list.Add(new Student() { GroupNo = "P121", Name = "Jenny" });
            list.Add(std);
            list.Add(std);

            list.RemoveAt(1);
            list.Remove(std);


            foreach (Student item in list)
            {
                Console.WriteLine(item);
            }


            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("A12", "Miray1");
            students.Add("A10", "Miray2");
            students.Add("A20", "Miray3");
            students.Add("A11", "Miray4");


            foreach (var item in students)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            students.Remove("A11");

            SortedList<string, string> sortedListGen = new SortedList<string, string>();

            sortedListGen.Add("A1", "Mercedec");
            sortedListGen.Add("B2", "BMW");
            sortedListGen.Add("B1", "Audi");
            sortedListGen.Add("A2", "Toyota");

            foreach (var item in sortedListGen)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            Dictionary<string, double> groups = new Dictionary<string, double>();
            groups.Add("P211", 90);
            groups.Add("P121", 85);
            groups.Add("P222", 45);
            groups.Add("P231", 41);

            double sum = 0;
            foreach (var item in groups)
            {
                sum += item.Value;
            }

            var result = sum / groups.Count;

            List<Group> groupList = new List<Group>();

            groupList.Add(new Group { No = "P211", AvgPoint = 65 });
            groupList.Add(new Group { No = "P117", AvgPoint = 95 });
            groupList.Add(new Group { No = "P171", AvgPoint = 15 });
            groupList.Add(new Group { No = "C312", AvgPoint = 55 });


            sum = 0;
            int count = 0;
            foreach (Group gr in groupList)
            {
                if (gr.AvgPoint >= 70)
                {
                    sum += gr.AvgPoint;
                    count++;
                }
            }

            result = sum / groupList.Count;

            Console.WriteLine(result);


            List<int> nums = new List<int>();


            Console.WriteLine(nums.Count);
            Console.WriteLine(nums.Capacity);



        }
    }
}

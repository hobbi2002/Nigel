using System;

namespace _2021_10_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[2];
            for (int i = 0; i < students.Length; i++)
            {
                string firstname = Console.ReadLine();
                string name = Console.ReadLine();
                string lastname = Console.ReadLine();
                string group = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                Random rnd = new Random();
                int[] m1 = new int[rnd.Next(3, 6)];
                int[] m2 = new int[rnd.Next(3, 6)];
                int[] m3 = new int[rnd.Next(3, 6)];
                for (int j = 0; j < m1.Length; j++)
                {
                    m1[j] = rnd.Next(2, 6);
                }
                for (int j = 0; j < m2.Length; j++)
                {
                    m2[j] = rnd.Next(2, 6);
                }
                for (int j = 0; j < m3.Length; j++)
                {
                    m3[j] = rnd.Next(2, 6);
                }
                students[i] = new Student(firstname, name, lastname, group, age, m1, m2, m3);
            }
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].ToString());
            }

        }
    }
}

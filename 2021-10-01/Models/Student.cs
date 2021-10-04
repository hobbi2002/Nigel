using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_10_01
{
    class Student
    {
        private int age;
        private int[][] mas = new int[3][];
        public string FirstName {get; set;}
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        public int Age {
            get { return age; }
            set
            {
                if (value >= 0) age = value;
                else age = 0;
            }
        }

        public Student(string firstName, string name, string lastName, string group, int age, int[] m1, int[] m2, int[] m3)
        {
            FirstName = firstName;
            Name = name;
            LastName = lastName;
            Group = group;
            Age = age;
            mas[0] = m1;
            mas[1] = m2;
            mas[2] = m3;
        }

        public int getMark(int i, int j)
        {
            return mas[i][j];
        }

        public void setMark(int i, int j, int mark)
        {
            mas[i][j] = mark;
        }

        public double getAvg(int i)
        {
            double S = 0;
            for (int j = 0; j < mas[i].Length; j++)
            {
                S += mas[i][j];
            }
            return S / mas[i].Length;
        }

        public override string ToString()
        {
            string s = string.Empty;
            s = FirstName + " " + Name + " " + LastName + " гр." + Group + " Возраст " + Age+"\n";
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    s += mas[i][j] + " ";
                }
                s += getAvg(i)+"\n";
            }
            return s;
        }
    }
}

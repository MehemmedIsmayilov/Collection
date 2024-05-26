using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class Student
    {
        public Dictionary<string, List<int>> Grades { get; set; }

        public Student()
        {

            Grades = new Dictionary<string, List<int>>();
        }


        public void AddBal(string subject, int grade)
        {
            if (Grades.ContainsKey(subject))
            {
                Grades[subject].Add(grade);
            }
            else
            {
                Grades[subject] = new List<int> { grade };
            }
        }


        public void BalSil(string subject, int grade)
        {
            if (Grades.ContainsKey(subject))
            {
                Grades[subject].Remove(grade);
                if (Grades[subject].Count == 0)
                {
                    Grades.Remove(subject);
                }
            }
            else
            {
                Console.WriteLine($"Telebenin {subject} ders bali tapilmadi");
            }
        }


        public double OrtalamaBal(string subject)
        {
            if (Grades.ContainsKey(subject))
            {
                return Grades[subject].Average();
            }
            else
            {
                Console.WriteLine($"Telebenin {subject} ders bali tapilmadi");
                return 0;
            }
        }


        public List<int> ButunBallar(string subject)
        {
            if (Grades.ContainsKey(subject))
            {
                return Grades[subject];
            }
            else
            {
                Console.WriteLine($"Telebenin {subject} ders bali tapilmadi");
                return new List<int>();
            }
        }
    }
}

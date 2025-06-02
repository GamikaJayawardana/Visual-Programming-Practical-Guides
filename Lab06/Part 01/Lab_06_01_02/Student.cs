using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_01_02
{
    internal class Student
    {
        private string name;
        private int[] marks;

        public Student(string name, int[] marks)
        {
            this.name = name;
            this.marks = marks;
        }

        public double CalculateAverage()
        {
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            return (double)total / marks.Length;
        }

        public string GetGrade()
        {
            double avg = CalculateAverage();
            if (avg >= 75) return "Distinction";
            else if (avg >= 60) return "credit";
            else if (avg >= 50) return "Pass";
            else return "Fail";
        }

        public string GetGrade(double avg)
        {
            if (avg >= 75) return "Distinction (External)";
            else if (avg >= 60) return "credit (External)";
            else if (avg >= 50) return "Pass (External)";
            else return "Fail (External)";
        }

        public int FindMaxRecursive(int[] arr, int n)
        {
            if (n == 1) return arr[0];
            return Math.Max(arr[n - 1], FindMaxRecursive(arr, n - 1));
        }

        public string GetSummery()
        {
            double avg = CalculateAverage();
            int maxMark = FindMaxRecursive(marks, marks.Length);
            string grade = GetGrade(avg);
            return $"Name: {name}\r\nAverage: {avg:F2}\r\nMax Mark: {maxMark}\r\nGrade: {grade}";
        }
    }
}

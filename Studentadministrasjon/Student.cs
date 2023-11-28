using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjon
{
    internal class Student
    {
        public string _name;
        private int _age;
        private string _program;
        private int _id;
        private List<Fag>SubjectsTaken = new List<Fag>();
        private List<Karakter>Grades = new List<Karakter>();

        public Student(string Name, int Age, string Program, int Id)
        {
            _name=Name;
            _age=Age;
            _program=Program;
            _id=Id;
        }

        public void addSubject(Fag fag)
        {
            SubjectsTaken.Add(fag);
        }

        public void addGrade(Karakter grade)
        {
            Grades.Add(grade);
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn: {_name}");
            Console.WriteLine($"Alder: {_age}");
            Console.WriteLine($"Linje: {_program}");
            Console.WriteLine($"StudentID: {_id}");
            Console.WriteLine("Fag tatt av studenten:");
            foreach (var subject in SubjectsTaken)
            {
                Console.WriteLine($"                        {subject._subject}");
            }
            Console.WriteLine("Karakterer: ");
            foreach (var grade in Grades)
            {
                
                Console.WriteLine($"                        {grade._fag._subject}:" + $"{grade._grade}");
            }
            Console.WriteLine("************************************");
            avrageGrade();
            Console.WriteLine("************************************");
            PointsTotal();
            Console.WriteLine("************************************");
            Console.WriteLine();

        }

        public void avrageGrade()
        {
            int avrage = 0;
            int sum = 0;
            int numberofgrades = 0;
            

            foreach (var thing in Grades)
            {
                sum += thing._grade;
                numberofgrades++;
            }

            avrage = sum / numberofgrades;
            Console.WriteLine($"Snittkarakter: {avrage}");
        }

        public void PointsTotal()
        {
            int sum = 0;
            int pointstotal = 0;

            for (int i = 0; i < SubjectsTaken.Count; i++)
            {
                var points = sum + SubjectsTaken[i]._points;
                pointstotal += points;
            }
            Console.WriteLine($"Totalt antall studiepoeng: {pointstotal}");
        }
    }
}

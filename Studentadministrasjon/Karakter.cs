using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjon
{
    internal class Karakter
    {
        public int _grade;
        private Student _student;
        public Fag _fag;

        public Karakter(int grade, Student student, Fag fag)
        {
            _grade = grade;
            _student = student;
            _fag = fag;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn: {_student._name}");
            Console.WriteLine($"Emne: {_fag._subject}");
            Console.WriteLine($"Karakter: {_grade}");
            Console.WriteLine("************************************");
        }
    }
}

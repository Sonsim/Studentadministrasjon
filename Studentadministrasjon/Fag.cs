using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjon
{
    internal class Fag
    {
        internal string _subject;
        private string _subjectcode;
        public int _points;

        public Fag(string Subject, string Code, int Points)
        {
            _subject = Subject;
            _subjectcode = Code;
            _points = Points;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Fag: {_subject}");
            Console.WriteLine($"Emnekode: {_subjectcode}");
            Console.WriteLine($"Studiepoeng: {_points}");
            Console.WriteLine("************************************");
        }
    }
}

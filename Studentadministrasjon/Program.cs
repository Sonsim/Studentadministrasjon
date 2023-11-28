namespace Studentadministrasjon
{
    internal class Program
    {
        static void Main()
        {
            var Sondre = new Student("Sondre", 30, "Start-IT", 1917);
            var Ola = new Student("Ola", 25, "Get-IT", 1948);

            var javascript = new Fag("Javascript", "JS101", 30);
            var chsarp = new Fag("C#", "C#101", 60);
            var html = new Fag("HTML", "HT101", 40);
            
            Sondre.addSubject(html);
            Sondre.addSubject(javascript);
            Sondre.addSubject(chsarp);
            Ola.addSubject(javascript);
            Ola.addSubject(chsarp);
            Ola.addSubject(html);

            var top1 = new Karakter( 6, Sondre, javascript);
            var top2 = new Karakter(6, Ola, javascript);
            var middle = new Karakter(4, Ola, chsarp);
            var middle2 = new Karakter(4, Sondre, chsarp);
            var bad = new Karakter(2, Sondre, html);
            var bad2 = new Karakter(2, Ola, html);

            Sondre.addGrade(top1);
            Sondre.addGrade(middle2);
            Sondre.addGrade(bad);

            Ola.addGrade(bad2);
            Ola.addGrade(middle);
            Ola.addGrade(top2);

            Sondre.SkrivUtInfo();
            
            Ola.SkrivUtInfo();
            
        }
    }
}
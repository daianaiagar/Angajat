using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angajat
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<Angajat> angajati;
            Lista<string> lines = new Lista<string>(0);




            using (StreamReader reader = new StreamReader(@"../../input.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    lines.Add(line);
            }
            //Console.WriteLine(Lista<string>.Join("\n",lines));
            angajati = new Lista<Angajat>(0);
            for (int i = 0; i < lines.Count; i++)
                angajati.Add(new Angajat(lines[i]));

            //  Console.WriteLine(Lista<Angajat>.Join("\n",angajati));
            StreamWriter writer = new StreamWriter("@../../outputnume.txt");
            angajati.Sort(Angajat.CompareName);
            Console.WriteLine(Lista<Angajat>.Join("\n", angajati));
            writer.Write(Lista<Angajat>.Join(Environment.NewLine, angajati));

            writer.Close();


            writer = new StreamWriter("@../../outputvechime.txt");
            angajati.Sort(Angajat.CompareVechime);

            writer.Write(Lista<Angajat>.Join(Environment.NewLine, angajati));
            writer.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal a1 = new Animal(10, "Grivei", 7.5f);
            //Animal a2 = new Animal(5, "Azorel", 5.6f);
            //Urs u1 = new Urs(true, 12, "Baloo", 145.0f);

            ////Console.WriteLine(a1);
            ////Console.WriteLine(a2);
            ////Console.WriteLine(u1);

            //Zoo z1=new Zoo();
            //z1.Lista.Add(a1.Clone());
            //z1.Lista.Add(a2.Clone());
            //z1.Lista.Add(u1.Clone());

            //z1.Lista.Sort();

            //foreach (var a in z1.Lista) {  Console.WriteLine(a.ToString()); }

            //Zoo z2=z1.Clone();

            //u1.Nume = "URS MODIFICAT";

            //Console.WriteLine();

            //foreach (var a in z2.Lista) { Console.WriteLine(a.ToString()); }

            //Console.WriteLine();

            //Pinguin p1=new Pinguin("Mascul", 10,"Nemo",20.0f);
            //Console.WriteLine(p1.ToString());

            List<string> listaVac=new List<string>();
            listaVac.Add("Vaccin 1");
            listaVac.Add("Vaccin 2");
            listaVac.Add("Vaccin 3");

            Caine c1 = new Caine(listaVac, 6, "Rav", 12.3f);
            Console.WriteLine(c1.ToString());

            Console.Read();
        }
    }
}

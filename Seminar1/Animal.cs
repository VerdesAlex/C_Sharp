using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal class Animal : ICloneable, IComparable
    {
        private int varsta;
        private string nume;
        private float greutate;

        public int Varsta
        {
            get { return varsta; }
            set { if (value > 0) varsta = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { if (value.Length > 3) nume = value; }
        }

        public float Greutate
        {
            get { return greutate; }
            set { if (value > 0) greutate = value; }
        }

        public Animal(int v, string n, float g)
        {
            varsta = v;
            nume = n;
            greutate = g;
        }

        public override string ToString()
        {
            return "Animalul " + nume + " are varsta: " + varsta + " si greutatea: " + greutate + ".";
        }

        Object ICloneable.Clone()
        {
            return this.MemberwiseClone(); //clonare superficiala
        }
        public Animal Clone()
        {
            return (Animal)((ICloneable)this).Clone();  //deep copy
        }

        public int CompareTo(object obj)
        {
            Animal nou=(Animal)obj;
            if (this.greutate > nou.greutate) return 1;
            else if (this.greutate < nou.greutate) return -1;
            else return string.Compare(this.nume, nou.nume);
        }
    }
}

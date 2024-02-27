using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal class Caine:Animal
    {
        private List<string> listaVaccinuri=new List<string>();

        public List<string> ListaVaccinuri
        {
            get { return listaVaccinuri; }
            set { listaVaccinuri = value; }
        }

        public Caine(List<String> lv, int v, string n, float g) : base(v, n, g)
        {
            listaVaccinuri = lv;
        }

        public override string ToString()
        {
            string x= base.ToString();
            x += " Vaccinuri facute: ";
            foreach (string s in listaVaccinuri)
                x += s+" ";
            return x+".";
        }

    }
}

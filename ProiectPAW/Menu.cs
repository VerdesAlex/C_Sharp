using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Menu
    {
        private string nume;
        private List<string> ingrediente;
        private int nrIngrediente;
        private float cantitate;
        private float pret;

        public Menu() { }
        public Menu(string nume, List<string> _ingrediente, int nrIng, float cantitate, float pret)
        {
            this.nume = nume;
            this.nrIngrediente = nrIng;
            for (int i = 0; i < nrIng; i++)
            {
                this.ingrediente[i] = _ingrediente[i];
            }
            this.cantitate = cantitate;
            this.pret = pret;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public int NrIngrediente { get { return nrIngrediente; } set { nrIngrediente = value; } }
        public float Cantitate { get { return cantitate; } set { cantitate = value; } }
        public float Pret { get { return pret; } set { pret = value; } }
        public List<string> Ingrediente { get { return ingrediente; } set { ingrediente = value; } }

    }
}

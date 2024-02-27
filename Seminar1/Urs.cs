using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal class Urs:Animal
    {
        private bool hiberneaza;
        public bool Hiberneaza
        {
            get { return hiberneaza; }
            set { if (value != hiberneaza) hiberneaza = value; }
        }
        public Urs(bool h, int v, string n, float g) : base(v, n, g)
        {
            hiberneaza=h;
        }
        public override string ToString()
        {
            return base.ToString() + (hiberneaza ? " Hiberneaza." : " NU hiberneaza.");
        }
    }
}

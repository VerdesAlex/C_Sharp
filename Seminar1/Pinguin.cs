using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal class Pinguin:Animal
    {
        private string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public Pinguin(string s, int v, string n, float g) : base(v, n, g)
        {
            sex = s;
        }

        public override string ToString()
        {
            return base.ToString()+" Sexul este: "+sex+".";
        }
    }
}

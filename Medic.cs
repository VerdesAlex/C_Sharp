
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S4
{
    public class Medic
    {
        private string cnp;
        private string nume;
        private int anAbsolvire;
        private string specializare;
        private DateTime dataNasterii;
        public Medic(string CNP, string _nume, int _AnAbs, string _spec, DateTime _dn)
        {
            cnp = CNP;
            nume=_nume;
            anAbsolvire = _AnAbs;
            specializare = _spec;
            dataNasterii = _dn;
        }

        public string Cnp {  get { return cnp; }  set { cnp = value; } }

        public  string Nume { get { return nume; } set { nume = value; } }
    
        public int AnAbsolvire { get { return anAbsolvire; } set{ anAbsolvire = value; } }

        public DateTime DataNasterii { get {  return dataNasterii; } set {  dataNasterii = value; } }

        public string Specializare { get { return specializare; } set {  specializare = value; } }
    }
}

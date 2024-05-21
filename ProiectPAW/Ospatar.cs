using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Ospatar
    {
        private string nume;
        private string prenume;
        private DateTime dataNastere;
        private DateTime dataAngajare;
        private int id;
        private string phone;
        private float salariu;

        public Ospatar() { }

        public Ospatar(string _nume, string _prenume, DateTime _dataNastere, DateTime _dataAngajare, int _id, string _phone, float _salariu)
        {
            this.nume = _nume;
            this.prenume = _prenume;
            this.dataNastere = _dataNastere;
            this.dataAngajare = _dataAngajare;
            this.id = _id;
            this.phone = _phone;
            this.salariu = _salariu;
        }

        public string Nume { get { return nume; } set { nume = value; } }
        public string Prenume { get { return prenume; } set {  prenume = value; } }
        public DateTime DataNastere { get {  return dataNastere; } set {  dataNastere = value; } }
        public DateTime DataAngajare { get {  return dataAngajare; } set { dataAngajare = value; } }
        public int Id { get { return id; } set { id = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public float Salariu { get {  return salariu; } set {  salariu = value; } }
    }
}

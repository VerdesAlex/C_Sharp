using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Rezervare
    {
        private string Id_Rezervare;
        private string Nume_Client;
        private string Masa;
        private DateTime DateTimeRezervare;
        private int NrPersoane;
        private string TelefonClient;

        public Rezervare() { }

        public Rezervare(string idRezervare, string numeClient, string masa, DateTime dateTimeRezervare, int nrPersoane, string nrTelefon)
        {
            Id_Rezervare = idRezervare;
            Nume_Client = numeClient;
            Masa = masa;
            DateTimeRezervare = dateTimeRezervare;
            NrPersoane = nrPersoane;
            TelefonClient = nrTelefon;
        }

        public string IdRezervare { get { return Id_Rezervare; } set { Id_Rezervare = value; } }
        public string NumeClient { get { return Nume_Client; } set { Nume_Client = value; } }
        public string masa { get { return Masa; } set { Masa = value; } }
        public DateTime dateTimeRezervare { get { return DateTimeRezervare; } set { DateTimeRezervare = value; } }
        public int nrPersoane { get {  return NrPersoane; } set { NrPersoane = value; } }
        public string telefonClient { get { return TelefonClient; } set { TelefonClient = value; } }
    }

}

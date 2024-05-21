using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{   
    public enum Status
    {
        Libera,
        Ocupata,
        Rezervata
    }

    public enum NrLoc
    {
       Doi =  2,
       Patru = 4,
       Sase = 6,
       Opt = 8

    }

    public class Masa
    {
        private int id;
        private NrLoc nrLocuri;
        private Status status;

        public Masa() { }
        public Masa(int _id, NrLoc _nrLocuri, Status _status)
        {
            this.id = _id;
            this.nrLocuri = _nrLocuri;
            this.status = _status;
        }

        public int Id { get { return id; } set { id = value; } }
        public NrLoc NrLocuri { get { return nrLocuri; } set { nrLocuri = value; } }
        public Status Status { get { return status; } set { status = value; } }

    }
}

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
        Rezervata
    }

    public enum NrLoc
    {
       Doua,
       Patru,
       Sase,
       Opt
    }

    

    public class Masa
    {
        private int id;
        private NrLoc? nrLocuri;
        private Status status;

        public Masa() { }
        public Masa(int _id, string _nrLocuri, Status _status)
        {
            if (!Enum.IsDefined(typeof(NrLoc), _nrLocuri))
            {
                throw new ArgumentOutOfRangeException(nameof(_nrLocuri), _nrLocuri, "Invalid number of seats. Must be a value from the NrLoc enum.");
            }

            this.id = _id;
            this.nrLocuri = ConvertStringToNrLoc(_nrLocuri);
            this.status = _status;
        }

        public int Id { get { return id; } set { id = value; } }
        public NrLoc? NrLocuri { get { return nrLocuri; } set
            {
                if (!Enum.IsDefined(typeof(NrLoc), value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Invalid number of seats. Must be a value from the NrLoc enum.");
                }

                nrLocuri = (NrLoc)value;
            }
        }
        public Status Status { get { return status; } set { status = value; } }

        public NrLoc? ConvertStringToNrLoc(string strValue)  // ? face typul de date nullable, necesar pt return null
        {
            switch (strValue)
            {
                case "Doua":
                    return NrLoc.Doua;
                    break;
                case "Patru":
                    return NrLoc.Patru;
                    break;
                case "Sase":
                    return NrLoc.Sase;
                    break;
                case "Opt":
                    return NrLoc.Opt;
                    break;
                default:
                    return null;
                    break;
            }
        }

        public override string ToString()
        {
            switch (nrLocuri)
            {
                case NrLoc.Doua:
                    return "Doua";
                    break;
                case NrLoc.Patru:
                    return "Patru";
                    break;
                case NrLoc.Sase:
                    return "Sanse";
                    break;
                case NrLoc.Opt:
                    return "Opt";
                    break;
                default:
                    return null;
                    break;
            }
        }
    }
}

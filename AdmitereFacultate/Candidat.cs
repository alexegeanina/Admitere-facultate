using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmitereFacultate
{
   public  class Candidat:ICloneable
    {
        private string cnp;
        private string cetatenie;
        private string nume;
        private string initialaTatalui;
        private string prenume;
        private string sex;
        private string adresa;
        private string nrTelefon;
        private string email;

        public Candidat(string cnp,string cetatenie,string nume,string initialaTatalui, string prenume,string sex, string adresa, string nrTelefon, string email)
        {
            this.cnp = cnp;
            this.cetatenie = cetatenie;
            this.nume = nume;
            this.initialaTatalui = initialaTatalui;
            this.prenume = prenume;
            this.sex = sex;
            this.adresa = adresa;
            this.nrTelefon = nrTelefon;
            this.email = email;

        }

        public string Cnp
        {
            get { return cnp; }
            set
            {
                if (value.Length==13)
                {
                    cnp = value;
                }
            }
        }
        public string Cetatenie
        {
            get { return cetatenie; }
            set
            {
                if (value != null)
                {
                    cetatenie = value;
                }
            }
        }
        public string Nume
        {
            get { return nume; }
            set
            {
                if (value != null)
                {
                    nume = value;
                }
            }
        }

        public string IntializaTatalui
        {
            get { return initialaTatalui; }
            set
            {
                if (value != null && value.Length==1)
                {
                    initialaTatalui = value;
                }
            }
        }

        public string Prenume
        {
            get { return prenume; }
            set
            {
                if (value != null)
                {
                    prenume = value;
                }
            }
        }

        public string Sex
        {
            get { return sex; }
            set
            {
                if (value != null)
                {
                    sex = value;
                }
            }
        }

        public string Adresa
        {
            get { return adresa; }
            set
            {
                if (value != null)
                {
                    adresa= value;
                }
            }
        }

        public string NrTelefon
        {
            get { return nrTelefon; }
            set
            {
                if (value.ToString().Length == 10)
                {
                    nrTelefon = value;
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if(value!=null)
                {
                    email = value;
                }
            }
        }

        public object Clone()
        {
           
            Candidat clona = (Candidat)this.MemberwiseClone();
            clona.cnp = this.cnp;
            clona.cetatenie = this.cetatenie;
            clona.nume = this.nume;
            clona.initialaTatalui = this.initialaTatalui;
            clona.prenume = this.prenume;
            clona.sex = this.sex;
            clona.adresa = this.adresa;
            clona.nrTelefon = this.nrTelefon;
            clona.email = this.email;
            return clona;
        }

        public override string ToString()
        {
            return "Candidatul: "+nume+" "+initialaTatalui+". "+prenume+", are cnp-ul: "+cnp+" adresa "+adresa+" "+" numarul de relefon "+nrTelefon+" si adresa de email "+email;
        }

    }
}

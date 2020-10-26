using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmitereFacultate
{
    class Medie
    {
        private string cnp;
        private double medieLiceu;
        private double medieBac;

        public Medie(string cnp,double medieLiceu,double medieBac)
        {
            this.cnp = cnp;
            this.medieBac = medieBac;
            this.medieLiceu = medieLiceu;
        }
        public string Cnp
        {
            get { return cnp; }
            set
            {
                if (value.ToString().Length == 13)
                {
                    cnp = value;
                }
            }
        }
        public double MedieLiceu
        {
            get { return medieLiceu; }
            set
            {
                if(value>0 && value < 11)
                {
                    medieLiceu = value;
                }
            }
        }
        public double MedieBac
        {
            get { return medieBac; }
            set
            {
                if (value > 0 && value < 11)
                {
                    medieBac = value;
                }
            }
        }

        public override string ToString()
        {
           double medieAdmitere = medieBac * 0.6f + medieLiceu* 0.4f;
            return "Candidatul are media celor 4 ani de liceu: " + medieLiceu + ", media de la bacalaureat este: " + medieBac + ", iar media de admitere este: " + medieAdmitere;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmitereFacultate
{
   public  class Facultate
    {
        private string cnp;
        private string tipInvatamant;
        private string denumireFacultate;
        private string specializare;

        public Facultate(string cnp, string tipInvatamant,string denumireFacultate, string specializare)
        {
            this.cnp = cnp;
            this.tipInvatamant = tipInvatamant;
            this.denumireFacultate = denumireFacultate;
            this.specializare = specializare;
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
        public string TipInvatamant
        {
            get { return tipInvatamant; }
            set
            {
                if (value != null)
                {
                    tipInvatamant = value;
                }
            }
        }
        public string DenumireFacultate
        {
            get { return denumireFacultate; }
            set
            {
                if (value != null)
                {
                    denumireFacultate = value;
                }
            }
        }
        public string Specializare
        {
            get { return specializare; }
            set
            {
                if (value != null)
                {
                    specializare = value;
                }
            }
        }
        

        public override string ToString()
        {
            string rezultat = " Tipul invatamantului este: " + tipInvatamant;
            rezultat += " Facultatea aleasa este: "+denumireFacultate+" la specializarea: "+specializare;
           
                return rezultat;
        }
    }
}

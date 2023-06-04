using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts
{
    internal class Kontakt
    {
        #region Polja
        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        private string glavniBroj;

        public string GlavniBroj
        {
            get { return glavniBroj; }
            set { glavniBroj = value; }
        }

        private List <string> ostaliBrojevi = new List<string>();
        #endregion
        public Kontakt(string ime, string prezime, string glavniBroj)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.GlavniBroj = glavniBroj;
        }

        public bool DodajBroj(string dodatniBroj)
        {
            if (ostaliBrojevi.Contains(dodatniBroj) || dodatniBroj == glavniBroj)
                return false;
            else
            {
                ostaliBrojevi.Add(dodatniBroj);
                return true;
            }
        }
        public bool IzbrisiBroj(string dodatniBroj)
        {
            if (ostaliBrojevi.Contains(dodatniBroj))
            {
                ostaliBrojevi.Remove(dodatniBroj);
                return true;
            }
            return false;
        }
        public string Ispis()
        {
            string txt = " ";
            txt = "[";
            foreach (var item in ostaliBrojevi)
            {
               txt += $"{item.ToString()}, ";
            }
            txt += "]";
            return txt;
        }
        public override string ToString()
        {
            return $"* Ime : {Ime}\n* Prezime : {Prezime}\n* Glavni Broj : {GlavniBroj}\n* Ostali brojevi : {Ispis()}" ;
        }
    }
}

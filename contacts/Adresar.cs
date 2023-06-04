namespace contacts
{
    internal class Adresar
    {
        Dictionary<string, Kontakt> Kontakti = new Dictionary<string, Kontakt>();

        public bool Dodaj(Kontakt k)
        {
            if (Kontakti.ContainsKey(k.GlavniBroj))
                return false;
            else
            {
                Kontakti.Add(k.GlavniBroj, k);
                return true;
            }
        }
       public bool Dodaj(string ime, string prezime, string glavniBroj)
        {
            if (Kontakti.ContainsKey(glavniBroj))
                return false;
           else
           {
                Kontakt temp = new Kontakt(ime, prezime, glavniBroj);
                Kontakti.Add(temp.GlavniBroj, temp);
                return true;
           }
        }
        public bool Blokiraj(string broj)
        {
            if (Kontakti.ContainsKey(broj))
            {
                Kontakti.Remove(broj);
                return true;
            }
            return false;
        }
        public void Share(string file, string glavniBroj)
        {
            StreamWriter sw = new StreamWriter(file);
            try
            {
                sw.WriteLine(Kontakti[glavniBroj]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Nesto je poslo po zlu");
            }
            finally
            {
                sw.Close();
            }
        }
        public bool Receive(string file)
        {
            StreamReader sr = new StreamReader(file);
            string info;
            try
            {
                info = sr.ReadLine();
                while (info != null && !Kontakti.Keys.Contains(info))
                {
                    Console.WriteLine(info);
                    info = sr.ReadLine();
                }
                Console.ReadLine();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Nesto je poslo po zlu");
                return false;
            }
            finally
            {
                sr.Close();
            }
        }
        public bool Backup(string file)
        {
            string txt = "";
            foreach (KeyValuePair<string, Kontakt> item in Kontakti)
            {
                txt += $"{Kontakti[item.Value.Ime]}, {Kontakti[item.Value.Prezime]}, {Kontakti[item.Value.GlavniBroj]}, {Kontakti[item.Value.Ispis()]} \n";
            }
            StreamWriter sw = new StreamWriter(file);
            try
            {
                sw.WriteLine(txt);
            }
            catch (Exception e)
            {
                Console.WriteLine("Nesto je poslo po zlu");
                return false;
            }
            finally
            {
                sw.Close();
            }
            return true;

        }
    }
}

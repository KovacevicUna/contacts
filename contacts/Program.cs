// See https://aka.ms/new-console-template for more information
using contacts;

Kontakt lana = new Kontakt("Lana", "Basic", "007");

lana.DodajBroj("1234");
lana.DodajBroj("1234");
lana.DodajBroj("2345");
lana.DodajBroj("5678");
lana.DodajBroj("909");
lana.DodajBroj("9987");
lana.IzbrisiBroj("9987");
lana.IzbrisiBroj("9989");

Console.WriteLine(lana);

Console.WriteLine("\nTEST TEST TEST TEST TEST TEST TEST TEST TEST TEST ");

Kontakt natasa = new Kontakt("Natasa", "Drinic", "34567");
Kontakt gavrilo = new Kontakt("Gavrilo", "Bosnjak", "21234");
Kontakt veselin = new Kontakt("Veeselin", "Dokmanovic", "635363");
Console.WriteLine(natasa);

Adresar a = new Adresar();
a.Dodaj(lana);
a.Dodaj(natasa.Ime, natasa.Prezime, natasa.GlavniBroj);
a.Blokiraj("007"); 


using System;
using System.Collections.Generic;

namespace ConsoleApp_1
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}

        /*
         -Creare 100 oggetti che rappresentino
            prodotti diversi con le seguenti caratteristiche:
            - Nome 
            - Costo
            
        */

        //static void Main(string[] args)
        //{
        //    List<Product> products = new List<Product>();
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Product product = new Product();
        //        product.Name = "Name" + i;
        //        product.Manufacturer = "manufacturer" + i;
        //        product.Cost = i;
        //        product.Number = i * 10;

        //        products.Add(product);
        //    }

        /* Creare una classe gioco con properties:
            - public string Nome;
            - public int Anno;
          - Creare 10 oggetti di tipo Gioco e 
            valorizzarne le properties;
          - tramite un ciclo stampare su schermo
            le properties dei 10 oggetti;
        */

        static void Main(string[] args)
        {
            List<Games> collection = new list<Games>();
            for (int i = 1; i <= 10; i++)
            {
                Games games = new Games();
                games.Name = "Name" + i;
                games.Year = i;

                collection.Add(games);
            }

            //for (int i = 0; i < collection.Count; i++)
            //{
            //    Console.WriteLine(collection[i].Name + " " + collection[i].Year);
            //}

            foreach (Games games in collection)
                Console.WriteLine(games.Name + " " + games.Year);

            /*

            - Chiedere all'utente i suoi dati anagrafici
            (es. nome, cognome, età ....)
            - Creare una classe che abbia le properties
            chieste all'utente 
            - istanziare un oggetto con i dati chiesti
              all'utente
            -stampare le properties su schermo dell'oggetto
            */

            //static void Main(string[] args)
            //{
            //    List<Anagrafica> persone = new List<Anagrafica>();
            //    Anagrafica utente = new Anagrafica();
            //    Get_user(Anagrafica utente),
            //    persone.Add(utente);

            //    foreach (Anagrafica utente in persone)
            //    {

            //        Console.WriteLine(utente.Name);
            //        Console.WriteLine(utente.Surname);
            //        Console.WriteLine(utente.Birthday);
            //        Console.WriteLine(utente.Region);
            //        Console.WriteLine(utente.City);
            //        Console.WriteLine(utente.Address);
            //        Console.WriteLine(utente.Number);
            //        Console.WriteLine(utente.Date);
            //    }

            //}

            //static object Get_user(Anagrafica utente)
            //{
            //    Console.WriteLine("inserirsci il nome: ");
            //    utente.Name = Console.ReadLine();
            //    Console.WriteLine("inserisci il cognome: ");
            //    utente.Surname = Console.ReadLine();
            //    Console.WriteLine("inserisci la data di nascita: ");
            //    utente.Birthday = console.ReadLine());
            //    Console.WriteLine("inserisci la regione di residenza: ");
            //    utente.Region = console.readline();
            //    Console.WriteLine("inserisci la città: ");
            //    utente.City = Console.ReadLine();
            //    Console.WriteLine("inserisci l'indirizzo: ");
            //    utente.Address = Console.ReadLine();
            //    Console.WriteLine("inserisci il numero civico: ");
            //    utente.Number = int.Parse(Console.ReadLine());
            //    Console.WriteLine("insisci la data di oggi: ");
            //    utente.Date = DateTime.Parse(Console.ReadLine());
            //    return utente;
            //}





        }
    }
}

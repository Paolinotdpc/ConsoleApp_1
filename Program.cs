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

        //static void Main(string[] args)
        //{
        //    List<Games> collection = new list<Games>();
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Games games = new Games();
        //        games.Name = "Name" + i;
        //        games.Year = i;

        //        collection.Add(games);
        //    }

        //    //for (int i = 0; i < collection.Count; i++)
        //    //{
        //    //    Console.WriteLine(collection[i].Name + " " + collection[i].Year);
        //    //}

        //    foreach (Games games in collection)
        //        Console.WriteLine(games.Name +" "+ games.Year);

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
        //    utente.Name = 



        //}
                           
        /*Torino 14/03/2023

        /*
        - Creare una classe prodotto con le seguenti proprietà
            - Nome
            - Costo

        - chiedere all'utente nome e costo di un prodotto e istanziarne un oggetto
        - fare in modo che si possano settare nomi solo di lunghezza maggiore di 5 caratteri.
        - stasmpare su schermo i valori delle properties dell'oggetto istanziato

       */

        //static void Main(string[] args)
        //{


        //}

        /* 
         -creare una classe Animale con caratteristiche:
            -razza
            -eta
            -colore
        -generare un numero casuale tra 1 e 5
        -creare  n oggetti di tipo animale equivalenti al numero estratto 
        -attribuire valori qualsiasi a ciascun animale, ma fare in modo che il colore possa essere 
         solo Bianco o Nero.
        */

       static void Main(string[] args)
        {
            List<Animals> animale = new List<Animals>();
            
            Random num = new Random();
            
            int numCasuale = num.Next(1,5);

            for (int i = 0; i < numCasuale; i++)
            {
                Animals animale = new Animals();
                      animale.razza = "Animale" + i;
                      animale.eta = i;
                animale.color = "colore" + i;

                animale.Add(animale);

            };

        }
        
    }
}

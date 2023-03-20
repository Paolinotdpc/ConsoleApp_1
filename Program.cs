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

        //static void Main(string[] args)
        // {
        //     List<Animals> animale = new List<Animals>();

        //     Random num = new Random();

        //     int numCasuale = num.Next(1,5);

        //     for (int i = 0; i < numCasuale; i++)
        //     {
        //         Animals animale = new Animals();
        //               animale.razza = "Animale" + i;
        //               animale.eta = i;
        //         animale.color = "colore" + i;

        //         animale.Add(animale);

        //}

        /*esercizio Lezione del 20/03/2023
        
        
        - Simulare una lotteria:
            - chiedere all'utente tre numeri
            - estrarre 5 numneri casuali
            - stampare su schermo se l'utente ha indovinato
              dei numeri e quali
        */

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("inserisci tre numeri a scelta: ");
        //    int num1 = int.Parse(Console.ReadLine());
        //    int num2 = int.Parse(Console.ReadLine());
        //    int num3 = int.Parse(Console.ReadLine());

        //    List<int> numEstratti = new List<int>();

        //    for (int i = 0; i < 5; i++)
        //    {

        //        Random random = new Random();
        //        numEstratti.Add(random.Next(1, 10));

        //    }

        //    for(int i = 0;i < numEstratti.Count;i++)
        //    {
        //        if (num1 == numEstratti[i])
        //        {
        //            Console.WriteLine("L'utente ha indovinato il numero: " + num1);
        //        }
        //        if (num2 == numEstratti[i])
        //        {
        //            Console.WriteLine("L'utente ha indovinato il numero: " + num2);
        //        }
        //        if (num3 == numEstratti[i])
        //        {
        //            Console.WriteLine("L'utente ha indovinato il numero: " + num3);
        //        }


        //    }

        //}

        /*
         - Simulare una lotteria di biglietti:
            - creare una classe giocatore
            - creare una classe biglietto con: 
                - luogo di acquisto
                - Seriale
            - permettere all'utente di comprare n biglietti 
            - creare una lista di biglietti estraibili
            - estrarre un biglietto della lista e stampare su schermo 
              i dati del biglietto estratto
            - comunicare all'utente se ha vinto
            */
        static void Main(string[] args)
        {
            
            string  i = "a";
            while (i != "a")
            {

                Console.WriteLine("Vuoi acquistare un biglietto? digita a per confermare q per terminare l'acquisto");
                if (i=="a")
                {
                    Biglietti b = new Biglietti();
                    b.Seriale = Guid.NewGuid();

                }
                
                else 
                            i = Console.ReadLine();
            }
        }
       
    	

	}








    }
}

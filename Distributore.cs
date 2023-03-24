using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp_1
{
    internal class Distributore
    {
        public List<Prodotto> Prodotti { get; set; } = new List<Prodotto>();    

        public void StampaProdotti()
        {
            foreach (Prodotto prodotti in Prodotti)
            {
                Console.WriteLine(prodotti.ToString());
            }
        }
    }
}   

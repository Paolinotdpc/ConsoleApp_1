using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_1
{
    internal class EssereVivente
    {

        public string specie { get; set; }

        public string nome { get; set; }

        public virtual void Nutriti()
        {


        }

        public virtual void StampaDati()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("specie: " + this.specie);

        }


    }
}
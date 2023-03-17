using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_1
{
    internal class Prodotti
    {
        private string nome;

        public string Nome
        {
            get { return nome; }

            set { nome = value; }
        }

        private int costo;

        public int Costo
        {
            get { return costo; }

            set { costo = value; }
        }
    }
}

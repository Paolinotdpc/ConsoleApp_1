using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp_1
{
    internal class Madre
    {
       // - una property public

        public string pubblico { get; set; }

       //- una property protected

        protected string protetto { get; set; }

       //- una property private

        private string privata { get; set; }

       //- un metodo public

        public void MetodoPubblico()
        { }

       //- un metodo protected

       protected void MetodoProtetto()
        { }

       //- un metodo private

        private void MetodoPrivato()
        { }


    }
}

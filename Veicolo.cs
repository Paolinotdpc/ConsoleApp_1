﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp_1
{
    internal class Veicolo
    {
        public string Model { get; set; }
        public string Plate { get; set; }
        public int MaxSpeed { get; set; }



        public void Start()
        {

            Console.WriteLine(this.Model + " "
                + this.Plate
                + " parte e raggiunge una velocità di "
                + this.MaxSpeed);
        }

        public void Stop()
        {
            Console.WriteLine(this.Model + " "
                + this.Plate
                + " si ferma");


        }

    }

}



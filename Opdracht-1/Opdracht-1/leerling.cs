﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    class leerling
    {
        public string voornaam;
        public string achternaam;
        public string klas;
        public int Teller = 1;

        public leerling()
        {
            voornaam = "leeg";
            achternaam = "leeg";
            klas = "leeg";
        }

        public leerling(string Voornaam, string Achternaam, string Klas)
        {
            voornaam = Voornaam;
            achternaam = Achternaam;
            klas = Klas;
        }

        //REMEMBER!!
        //Optie 2: (check main)

        //public override string ToString()
        //{
        //    return "Leerling " + this.Teller + ":" + "\n" + "naam: " + this.voornaam + " " + this.achternaam + "\n" + "klas: " + this.klas + "\n";
        //}
    }
}

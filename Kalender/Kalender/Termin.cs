using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalender
{
    internal class Termin
    {
        //Objektvariablen
        protected string terName;
        protected string terBeschreibung;
        protected bool terGanztaegig;
        protected int jahr;
        protected int monat;
        protected int tag;
        protected int vonInMin;
        protected int bisInMin;
        //Klassenvariablen
        private static int terAnzahl = 0;
        private static int terID = 0;

        public Termin() { }

        //Konstruktor
        public Termin(string terName, string terBeschreibung, int jahr, int monat, int tag, bool terGanztaegig, int vonInMin, int bisInMin)
        {
            this.terName = terName;
            this.terBeschreibung = terBeschreibung;
            this.jahr = jahr;
            this.monat = monat;
            this.tag = tag;
            this.vonInMin = vonInMin;
            this.bisInMin = bisInMin;
            this.terGanztaegig = terGanztaegig;
            terAnzahl++;
            terID++;
        }

        //Properties
        public string TerNname
        {
            get => terName;
            set => terName = value;
        }

        public string TerBeschreibung
        {
            get => terBeschreibung;
            set => terBeschreibung = value;
        }

        public int Jahr
        {
            get => jahr;
            set => jahr = value;
        }

        public int Monat
        {
            get => monat;
            set => monat = value;
        }
        public int Tag
        {
            get => tag;
            set => tag = value;
        }

        public int VonInMin
        {
            get => vonInMin;
            set => vonInMin = value;
        }

        public int BisInMin
        {
            get => bisInMin;
            set => bisInMin = value;
        }

        public bool TerGanztaegig
        {
            get => terGanztaegig;
            set => terGanztaegig = value;
        }

        //Klassenmethode
        public static int TerAnzahl => terAnzahl;
        public static int TerID => terID;

        public override string ToString()
        {
            return terID + terName + " " + terBeschreibung +  "\t" + terGanztaegig;
        }
    }

}


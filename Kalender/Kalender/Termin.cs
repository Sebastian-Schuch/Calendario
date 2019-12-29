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
        protected DateTime terTermindatum;
        protected bool terGanztaegig;

        //Klassenvariablen
        private static int terAnzahl = 0;
        private static int terID = 0;

        public Termin() { }

        //Konstruktor
        public Termin(string terName, string terBeschreibung, DateTime terTermindatum, bool terGanztaegig)
        {
            this.terName = terName;
            this.terBeschreibung = terBeschreibung;
            this.terTermindatum = terTermindatum;
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

        public DateTime TerTermindatum
        {
            get => terTermindatum;
            set => terTermindatum = value;
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
            return terID + terName + " " + terBeschreibung + "\t" + terTermindatum.ToShortDateString() + "\t" + terGanztaegig;
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatton.Befehle;
using CommandPatton.Steuerungselemente;

namespace CommandPatton
{
    class Raum
    {
        private int raumtemperatur = 0;
        private int ausleuchtung = 0;
        private List<Steuerelemente> steuerungselementeFuerAktuellenRaum = new List<Steuerelemente>();
        private List<Befehl> befehleFuerSteuerelemente= new List<Befehl>();

        public Raum()
        {
 
        }

        public void BefuelleBefehlslisteFuerSteuerelemente(List<Befehl> befehleSteuerelemente)
        {
            this.befehleFuerSteuerelemente = befehleSteuerelemente;
            GibDieBefehleAnDieSteuerelementeWeiter();
        }

        private void GibDieBefehleAnDieSteuerelementeWeiter()
        {
            foreach (Steuerelemente element in steuerungselementeFuerAktuellenRaum)
	        {
                element.SetKommandos(befehleFuerSteuerelemente);
	        }

            befehleFuerSteuerelemente = new List<Befehl>();

        }

        public void fuegeSteuerelementHinzu(Steuerelemente steuerelementZumHinzufuegen)
        {
            steuerungselementeFuerAktuellenRaum.Add(steuerelementZumHinzufuegen);
        }

        public override String ToString()
        {
            String result = "Raumtemp: " + this.raumtemperatur + "\n";
            foreach (Steuerelemente Element in steuerungselementeFuerAktuellenRaum)
            {
               result += Element.ToString() + "\n";
            }

            return result;
        }
    }
}

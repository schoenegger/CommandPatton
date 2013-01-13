using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatton.Befehle;

namespace CommandPatton.Steuerungselemente
{
    class Heizung : StandartSteuerelement
    {
        private bool istDieHeizungEin;

        protected override void aktiviereAbarbeitungProgrammliste()
        {

            foreach (Befehl BefehlVonListe in befehlsListe)
            {
                //Überprufen ob der Befehl auf ein Objekt vom Typ Lichtkommando gecastet werden kann
                if ((typeof(Heizungskommando)).IsAssignableFrom(BefehlVonListe.GetType()))
                {
                    BefehlVonListe.BefehleDurchführen(this);
                }
            } 
        }
        public void HeizungAus()
        {
            this.istDieHeizungEin = false;
        }

        public void HeizungEin()
        {
            this.istDieHeizungEin = true;
        }

        public override string ToString()
        {
            string result = "";

            if (istDieHeizungEin)
            {
                result = "Heizung Ein";
            }
            else
            {
                result = "Heizung Aus";
            }
            return result;
        }
    }
}

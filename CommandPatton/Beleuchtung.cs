using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatton
{
    class Beleuchtung : StandartSteuerelement
    {
        private bool istDasLichtEin;
        
          protected override void aktiviereAbarbeitungProgrammliste()
        {

               
            foreach (Befehl BefehlVonListe in befehlsListe)
            {
                //Überprufen ob der Befehl auf ein Objekt vom Typ Lichtkommando gecastet werden kann
                if ((typeof(Lichtkommando)).IsAssignableFrom(BefehlVonListe.GetType()))
                {              
                    BefehlVonListe.BefehleDurchführen(this);
                }
            }
        }

        public void LichtAus()
        {
            this.istDasLichtEin = false;
        }

        public void LichtEin()
        {
            this.istDasLichtEin = true;
        }

        public override string ToString()
        {
            string result = "";

            if (istDasLichtEin)
            {
                result = "Licht Ein";
            }
            else 
            {
                result = "Licht Aus";
            }
            return result;
        }
    }
}

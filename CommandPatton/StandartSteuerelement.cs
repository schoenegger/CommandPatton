using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatton
{
   public abstract class StandartSteuerelement : Steuerelemente
    {
       protected List<Befehl> befehlsListe = new List<Befehl>();

        public void SetKommandos(List<Befehl> BefehleVomRaum)
        {
            this.befehlsListe = BefehleVomRaum;
            aktiviereAbarbeitungProgrammliste();
        }
      abstract  protected void aktiviereAbarbeitungProgrammliste();
    }
}

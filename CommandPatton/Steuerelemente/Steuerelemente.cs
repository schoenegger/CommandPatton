using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatton.Befehle;

namespace CommandPatton.Steuerungselemente
{
     public interface Steuerelemente    //Schnittstelle für die Steuerelemente
    {
      
       void SetKommandos(List<Befehl> BefehleVomRaum);

    }
}

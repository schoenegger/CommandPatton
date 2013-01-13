using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatton
{
     public interface Steuerelemente    //Schnittstelle für die Steuerelemente
    {
      
       void SetKommandos(List<Befehl> BefehleVomRaum);

    }
}

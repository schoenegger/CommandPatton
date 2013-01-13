using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatton.Steuerungselemente;

namespace CommandPatton.Befehle
{
   public interface Befehl
    {
        void BefehleDurchführen(Steuerelemente dasZuSteuerndeElement);
        void BefehleRückgängigmachen();

        //public void Einschalten();
        //public void AutomatikAktivieren();
        //public void Ausschalten();
    }
}

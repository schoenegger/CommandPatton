using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatton;

namespace Befehl
{

    abstract class Heizungskommando : Befehl
    {

        abstract public void BefehleDurchführen(Steuerelemente dasZuSteuerndeSteuerelement);

        abstract public void BefehleRückgängigmachen();
    }
}
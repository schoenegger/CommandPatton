﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatton
{
    abstract class Lichtkommando : Befehl
    {

       abstract public void BefehleDurchführen(Steuerelemente dasZuSteuerndeSteuerelement);

       abstract public void BefehleRückgängigmachen();
    }
}

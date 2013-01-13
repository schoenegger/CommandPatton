using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatton;

namespace Befehl
{
    class LichtAus : Lichtkommando
    {
        public override void BefehleDurchführen(Steuerelemente dasZuSteuerndeSteuerelement)
        {
            //Überprufen ob das Steuerelement auf ein Objekt vom Typ Beleuchtung gecastet werden kann
            if ((typeof(Beleuchtung)).IsAssignableFrom(dasZuSteuerndeSteuerelement.GetType()))
            {
                ((Beleuchtung)dasZuSteuerndeSteuerelement).LichtAus();//In Objekt Beleuchtung Cast-en
            }
        }

        public override void BefehleRückgängigmachen()
        {
            throw new NotImplementedException();
        }
    }
}

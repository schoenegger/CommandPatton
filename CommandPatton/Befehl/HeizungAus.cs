using CommandPatton.Befehle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatton.Steuerungselemente;

namespace CommandPatton.Befehle
{
    class HeizungAus: Heizungskommando
    {
    
         public override void BefehleDurchführen(Steuerelemente dasZuSteuerndeSteuerelement)
            {
                //Überprufen ob das Steuerelement auf ein Objekt vom Typ Beleuchtung gecastet werden kann
                if ((typeof(Heizung)).IsAssignableFrom(dasZuSteuerndeSteuerelement.GetType()))
                {
                    ((Heizung)dasZuSteuerndeSteuerelement).HeizungAus();//In Objekt Beleuchtung Cast-en
                }
            }

            public override void BefehleRückgängigmachen()
            {
                throw new NotImplementedException();
            }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatton.Befehle;
using CommandPatton.Steuerungselemente;

namespace CommandPatton
{
    class Steuerzentrale
    {
       // List<Raum>  = HoleListeVonRaumenAusDerDatenbank();

        Raum Raum1 = new Raum();
        Raum Raum2 = new Raum();

        

        public Steuerzentrale()
        {
            Raum1.fuegeSteuerelementHinzu(new Beleuchtung());
            Raum1.fuegeSteuerelementHinzu(new Beleuchtung());
            Raum1.fuegeSteuerelementHinzu(new Heizung());
            Raum1.fuegeSteuerelementHinzu(new Heizung());
            Raum1.fuegeSteuerelementHinzu(new Heizung());

           MainWindow.AusgabeTextblock.Text = Raum1.ToString();

            List<Befehl> Befehlsliste = new List<Befehl>();

            Befehlsliste.Add(new LichtEin());
            Befehlsliste.Add(new LichtEin());
            Befehlsliste.Add(new HeizungEin());

            Raum1.BefuelleBefehlslisteFuerSteuerelemente(Befehlsliste);

            MainWindow.AusgabeTextblock.Text += Raum1.ToString();

            Befehlsliste.Add(new LichtAus());
            Raum1.BefuelleBefehlslisteFuerSteuerelemente(Befehlsliste);


            MainWindow.AusgabeTextblock.Text += Raum1.ToString();

            Befehlsliste.Add(new HeizungAus());
            Befehlsliste.Add(new LichtEin());
            Raum1.BefuelleBefehlslisteFuerSteuerelemente(Befehlsliste);

            MainWindow.AusgabeTextblock.Text += Raum1.ToString();
        }

        public void GibDemRaumeineBefehlsliste(List<Befehl> Befehlsliste, Raum zuBestueckenderRaum)
        {
            Raum1.BefuelleBefehlslisteFuerSteuerelemente(Befehlsliste);
            //zuBestueckenderRaum.BefuelleBefehlslisteFuerSteuerelemente(Befehlsliste);

        }


    }
}

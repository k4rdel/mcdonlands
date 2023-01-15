using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mcd
{
    internal class Potrawa
    {
        public string potrawa;
        public string opis;
        public string cena;

        public Potrawa(string potrawa, string opis, string cena)
        {
            this.potrawa = potrawa;
            this.opis = opis;
            this.cena = cena;
        }

        public void Wyswietl()
        {
            MessageBox.Show(opis + cena, potrawa);
        }
    }
}

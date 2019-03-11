using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class cPokeriKasi
    {
        public string nimi;
        public List<cKortti> kasi;


        public cPokeriKasi(string NIMI)
        {
            nimi = NIMI;
            kasi = new List<cKortti>(5);
        }

        public void otakortti (cKortti uusiKortti)
        {
            kasi.Add(uusiKortti);
        }


        public void show()
        {
            foreach(cKortti korttix in kasi)
            {
                korttix.show();
            }
        }

    }
}

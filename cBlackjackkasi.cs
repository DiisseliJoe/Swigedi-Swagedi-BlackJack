using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class cBlackjackkasi
    {

        public string nimi;
        public List<cKortti> kasi;
        public int kasiarvo;


        public cBlackjackkasi(string NIMI)
        {
            nimi = NIMI;
            kasi = new List<cKortti>();
            
        }
        public void laskearvo()
        {
            kasiarvo = 0;

            for (int i = 0; i < kasi.Count; i++)
            {
                
                kasiarvo = kasiarvo + kasi[i].arvok;
            }
        }

        public void otakortti(cKortti uusiKortti)
        {
            kasi.Add(uusiKortti);
        }


        public void show()
        {
            foreach (cKortti korttix in kasi)
            {
                korttix.show();
            }
        }

        public void arvoshow()
        {
            Console.WriteLine("Käden arvo on "+kasiarvo);

        }

        public void tarkasta()
        {
          
            if (kasiarvo >= 22)
            {
                for (int a = 0; a < kasi.Count; a++)
                {
                    if (kasi[a].arvok == 11)
                    {
                        kasi[a].arvok = 1;
                    }
                }
            }

        }
        public void show1()
        {
            for (int i = 1; i < kasi.Count; i++)
            {

                kasi[i].show();
            }
        }
        public void havisit()
        {
            Console.WriteLine("Hävisit pelin");
            return;

        }

    }

}

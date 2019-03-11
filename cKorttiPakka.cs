using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class cKorttiPakka
    {
        public List<cKortti> pakka;

        public cKorttiPakka()
        {
            
           pakka = new List<cKortti>(52);
            for (int a = 1; a <= 4; a++)
            {
                for (int i = 1; i <= 13; i++)
                {
                    pakka.Add(new cKortti(i, a));
                }
            }
          
        }

        public void MuutaBlackJackpakaksi()
        {
            for (int i = 0; i < pakka.Count; i++)
            {
                if (pakka[i].arvok >= 10)
                {
                    pakka[i].arvok = 10;
                }

                if (pakka[i].arvok == 1)
                {
                    pakka[i].arvok = 11;
                }
            }
        }

        public void jaa(cBlackjackkasi pelaaja1, cBlackjackkasi pelaaja2)
        {
           

            for (int i = 1; i <= 2; i++)
            {
                pelaaja1.otakortti(AnnaKortti());
                pelaaja2.otakortti(AnnaKortti());

            }

        }


        public void sekoita()
        {
            Random rnd = new Random();

            for (int i = 0; i < pakka.Count; i++)
            {
                
                int a = rnd.Next(pakka.Count -1);

                //Console.WriteLine(i + " " + a);

                cKortti temp = new cKortti(1, 1);
                temp = pakka[i];
                pakka[i] = pakka[a];
                pakka[a] = temp;
             
                    
            }



        }
        
        public cKortti AnnaKortti()
        {
            //ota talteen kortti
            cKortti annettava = pakka[0];
            // poista kortti
            pakka.RemoveAt(0);
            // palauta kortti
            return annettava;
        }
        public void reset()
        {
            //tyhjennä pakka
            //sama kuin konstruktorissa
        }
        public void show()
        {
            foreach (cKortti korttix in pakka)
            {
                korttix.show();
            }

        }
    }
}

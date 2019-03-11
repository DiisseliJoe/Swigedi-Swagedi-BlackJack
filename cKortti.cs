using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class cKortti
    {
        
        public int arvo;
        public int maa;
        public int arvok;
        

        public cKortti(int ARVO, int MAA_1_4_he_ru_ri_pa)
        {
            arvo = ARVO;
            maa = MAA_1_4_he_ru_ri_pa;
            arvok = ARVO;
        }

        public void show()
        {
            

            if (maa<1 || maa > 4)
            {
                Console.WriteLine("Korttivirhe");
            }
            if (maa==1)
            {
                Console.Write("Hertta ");
            }
            if (maa == 2)
            {
                Console.Write("Ruutu ");
            }
            if (maa == 3)
            {
                Console.Write("Risti ");
            }
            if (maa == 4)
            {
                Console.Write("Pata ");
            }


            if (arvo<1 || arvo > 13)
            {
                Console.WriteLine("Arvo virhe");
            }

            int switche = arvo;
            switch (switche)
            {
                case 0:
                    Console.WriteLine("väärä arvo");
                    break;
                case 1:
                    Console.WriteLine("Ässä");
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine(arvo);
                    break;
                case 11:
                    Console.WriteLine("Jätkä");
                    break;
                case 12:
                    Console.WriteLine("Kuningatar");
                    break;
                case 13:
                    Console.WriteLine("Kuningas");
                    break;
            }
            Console.WriteLine("");



        }
    }
}

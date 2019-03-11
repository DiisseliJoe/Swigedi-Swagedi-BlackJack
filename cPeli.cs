using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class cPeli
    {
        public string nimi;
        public int a;
        public cKorttiPakka BlackjackPakka = new cKorttiPakka();
        
        public cBlackjackkasi jakaja = new cBlackjackkasi("Jakaja");

        

            public void play()
        {

            BlackjackPakka.MuutaBlackJackpakaksi();
            BlackjackPakka.sekoita();

            Console.WriteLine("Pelaajan nimi:" );
            nimi = Console.ReadLine();
            cBlackjackkasi pekka = new cBlackjackkasi(nimi);
            BlackjackPakka.jaa(pekka, jakaja);


            Console.WriteLine("Pelaajan käsi");
            pekka.show();
            pekka.laskearvo();
            pekka.arvoshow();
            Console.WriteLine();
            Console.WriteLine("Jakajan käsi");
            jakaja.show1();
            jakaja.laskearvo();
            Console.WriteLine("...................................");


            do
            {

                Console.WriteLine("Haluatko nostaa kortin. 1 kyllä, 2 Ei.");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    pekka.otakortti(BlackjackPakka.AnnaKortti());
                    Console.WriteLine("Pelaaja nostaa kortin");
                    pekka.show();
                    pekka.tarkasta();
                    pekka.laskearvo();
                    pekka.arvoshow();
                    if (pekka.kasiarvo >= 22)
	                {
                    pekka.havisit();
                    return;
	                }
                }
                else
                {
                }
                

            } while (a == 1);
            Console.WriteLine();
            pekka.tarkasta();
            pekka.laskearvo();
            System.Threading.Thread.Sleep(2000);

            if (pekka.kasiarvo <= 20)
            {
                Console.WriteLine("Pelaajan korttien arvo: " + pekka.kasiarvo);
            }
            else if (pekka.kasiarvo == 21)
            {
                Console.WriteLine("VOITIT");
                return;
            }
            else
            {
                pekka.havisit();
                return;
            }
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Jakajan vuoro");
            jakaja.show();
            System.Threading.Thread.Sleep(2000);
            do
            {
                jakaja.tarkasta();
                jakaja.arvoshow();
                
                if (jakaja.kasiarvo <= 16)
                {
                    jakaja.otakortti(BlackjackPakka.AnnaKortti());
                    Console.WriteLine("Jakaja nostaa kortin");
                }
                else if (jakaja.kasiarvo >= 17 && jakaja.kasiarvo <= 21)
                {

                }
                jakaja.tarkasta();
                jakaja.laskearvo();
            } while (jakaja.kasiarvo <= 15);


            Console.WriteLine(".......");
            System.Threading.Thread.Sleep(2000);
            jakaja.show();
            jakaja.tarkasta();
            jakaja.arvoshow();
            if (jakaja.kasiarvo >= 22)
            {
                Console.WriteLine("Voitit");
                return;
            }

            Console.WriteLine("---------------------------------");
            if (pekka.kasiarvo == jakaja.kasiarvo)
            {
                pekka.havisit();
                return;
            }
            else if (pekka.kasiarvo > jakaja.kasiarvo && pekka.kasiarvo < 22)
            {
                Console.WriteLine("VOITIT");
                return;
            }
            else
            {
                pekka.havisit();
                return;
            }

        }
    }
}


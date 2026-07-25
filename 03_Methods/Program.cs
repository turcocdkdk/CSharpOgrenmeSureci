using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string karakteradi, dusmanadi;
            int karaktercan, dusmancan, karakterhp, dusmanhp, saldiriSayisi = 0;
            bool loopContiuning = true, siraDusmanda = false;

            string[]  yerler = { "Boğaz", "Göğüs", "Omuz", "Karın", "Kol" };
            string[]  dovusHamleleri = { "Aparkat", "Yumruk", "Tekme", "Dirsek" };
            string[] dalgaGecmeCumleleri = { "HAAHHahahaahahahaa! tüm yapabildiğin bu mu?", "Ha?! Tüm gücün bu muydu?? bende seni ciddi sanmıştım!", "Az kaldı, sana acımaya başlayacağım!" };

            Console.WriteLine("##### RPG SİMİLASYONU #####");
            boslukBırak();

            Console.WriteLine("Başlamadan önce karakterini yarat!");
            boslukBırak();
            Console.Write("Karakterin ismi: ");
            karakteradi = Console.ReadLine();
            boslukBırak() ;

            Console.Write("Karakterin canı: ");
            karaktercan = int.Parse(Console.ReadLine());
            boslukBırak();
            Console.Write("Karakterin Vuruş Gücü: ");
            karakterhp = int.Parse(Console.ReadLine());
            boslukBırak();
            Console.Write("Düşmanının ismi: ");
            dusmanadi = Console.ReadLine();
            boslukBırak();

            Console.Write("Düşmanın canı: ");
            dusmancan = int.Parse(Console.ReadLine());
            int dusmancanMax = dusmancan;
            boslukBırak();
            Console.Write("Düşmanının Vuruş Gücü: ");
            dusmanhp = int.Parse(Console.ReadLine());


            while (loopContiuning)
            {
                Console.WriteLine();
                Console.WriteLine();
                if(siraDusmanda == false)
                {
                    secimMenusu();
                    Console.Write("Seçimini yap: ");
                    string secim = Console.ReadLine();

                    switch (secim)
                    {
                        case "1":
                            saldir();
                            break;
                        case "2":
                            Console.WriteLine($"Düşmanın: {dusmanadi} canı: {dusmancan}");
                            if (saldiriSayisi > 10)
                            {
                                Console.WriteLine($"{dusmanadi} attığın hamleler yüzünden artık çok yorgun, ama hayla savaşmaya kararlı!");
                            }
                            else
                            {
                                Console.WriteLine($"{dusmanadi} hala çok güçlü ve dinç!");
                            }
                            break;
                        case "3":
                            int deger = new Random().Next(1, 25);
                            iyiles(deger);
                            siraDusmanda = true;
                            break;
                    }
                }
                else
                {
                    boslukBırak();
                    boslukBırak();
                    Console.WriteLine($"Sıra {dusmanadi} da!");

                    dusmanAI();
                }



            }

            void boslukBırak()
            {
                Console.WriteLine();
            }
            void secimMenusu()
            {
                Console.WriteLine("1- Savaş");
                Console.WriteLine("2- Düşman Bilgisi");
                Console.WriteLine("3- Can iksiri");
                Console.WriteLine("4- Çıkış");
            }
            void iyiles(int value)
            {
                karakterhp += value;
            }

            void saldir()
            {
                boslukBırak();
                saldiriSayisi++;
                Console.WriteLine($"{karakteradi}, {dusmanadi} ya saldırdı!");
                string yer = yerler[new Random().Next(0, yerler.Length)];
                string hamle = dovusHamleleri[new Random().Next(0, dovusHamleleri.Length)];
                int damage = new Random().Next(1, karakterhp);

                dusmancan -= damage;
                if (dusmancan <= 0)
                {
                    Console.WriteLine($"{dusmanadi} artık savaşamayacak kadar yorgun ve bitkin! Çok geçmeden yere düşüp bayılıyor!");
                    Console.WriteLine($"{karakteradi} savaşı kazandı!");
                    loopContiuning = false;
                }
                else if (damage > 50)
                {
                    Console.WriteLine($"{karakteradi}, {dusmanadi} nın {yer} bölgesine sert bir {hamle} attı!");
                    Console.WriteLine($"{dusmanadi} Hamlenden dolayı geri sendeledi! Toplamda {damage} hasar verdin!");
                }
                else if (damage >10 && damage < 50)
                {
                    Console.WriteLine($"{karakteradi}, {dusmanadi} nın {yer} bölgesine bir {hamle} attı!");
                    Console.WriteLine($"{dusmanadi} İnledi, ama sonra gardını tekrar toparladı! Toplamda {damage} hasar verdin!");
                }
                else
                {
                    string dalgaGecmeCumlesi = dalgaGecmeCumleleri[new Random().Next(0, dalgaGecmeCumleleri.Length)];
                    Console.WriteLine($"{karakteradi}, {dusmanadi} nın {yer} bölgesine bir  {hamle} atmayı denedi!");
                    Console.WriteLine($"{dusmanadi} hamleni kolaylaca blokladı! Toplamda {damage} hasar verdin!");
                    Console.WriteLine($"{dusmanadi}: {dalgaGecmeCumlesi}");
                }
                siraDusmanda = true;

            }
            void dusmanAI()
            {
                int damage = new Random().Next(1, dusmanhp);
                string movement  = dovusHamleleri[new Random().Next(0, dovusHamleleri.Length)];
                string place = yerler[new Random().Next(0, yerler.Length)];
                int healHP = new Random().Next(1, 25);

                double canYuzdesi = (double)dusmancan / dusmancanMax;
                double enemyChanceToUseHealingPotion = (1.0 - canYuzdesi) * 100;
                double randomChance = new Random().Next(0,100);

                if(enemyChanceToUseHealingPotion > randomChance && dusmancan <  dusmancanMax)
                {
                   dusmancan += healHP;
                    Console.WriteLine($"{dusmanadi} can iksiri kullanarak {healHP} puan iyileşti!'");
                    siraDusmanda = false;
                }
                else
                {
                    karaktercan -= damage;
                    Console.WriteLine($"{dusmanadi}, {karakteradi} ya saldırdı!");
                    Console.WriteLine($"{dusmanadi}, {karakteradi} nın {place} bölgesine {movement} attı! Toplamda {damage} hasar yedin!");
                    siraDusmanda = false;
                    if( karaktercan  < 0 )
                    {
                        Console.WriteLine($"{karakteradi} artık savaşamayacak kadar yorgun ve bitkin! Çok geçmeden yere düşüp bayılıyor!");
                        Console.WriteLine($"{dusmanadi} savaşı kazandı!");
                        loopContiuning = false;
                    }
                }
            }
        }
    }
}

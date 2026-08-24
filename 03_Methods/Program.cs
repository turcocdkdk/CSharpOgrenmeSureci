using System;
using System.Collections.Generic;
using System.Data;
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

            string[] yerler = { "Boğaz", "Göğüs", "Omuz", "Karın", "Kol" };
            string[] dovusHamleleri = { "Aparkat", "Yumruk", "Tekme", "Dirsek" };
            string[] dalgaGecmeCumleleri = { $"HAAHHahahaahahahaa! tüm yapabildiğin bu mu?{karakteradi}?", $"Ha?! Tüm gücün bu muydu {karakteradi}?? bende seni ciddi sanmıştım!", "Az kaldı, sana acımaya başlayacağım!" , "Şimdiden kaybettin!" };
            string[] inleme = { "Ahgggg!", "Dahhhh!", "Ahhahh!", "Ighh!!", "Haghh!" };
            string[] baslangıcdiyalogu = { $"Gel bakalım!", "Bittin Sen!", "Öldüreceğim seni!!",$"Gel buraya {karakteradi}!!", $"Buradan sağ çıkamayacaksın {karakteradi}!" };

            Random rnd = new Random();

            diyalogyazdir(baslangıcdiyalogu, dusmanadi);
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
                            Console.WriteLine($"Sen: {karakteradi} canı: {karaktercan}");
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
                            int deger = rnd.Next(1, 25);
                            iyiles(deger);
                            Console.WriteLine($"{deger} puan can kazandın! yeni canın; {karaktercan}");
                            siraDusmanda = true;
                            break;
                        case "4":
                            loopContiuning = false;
                            Console.WriteLine("Oyundan çıkılıyor...");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("------------------------------------------------------------");
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
                karaktercan += value;
            }

            void saldir()
            {
                boslukBırak();
                saldiriSayisi++;
                Console.WriteLine($"{karakteradi}, {dusmanadi} ya saldırdı!");
                string yer = yerler[rnd.Next(0, yerler.Length)];
                string hamle = dovusHamleleri[rnd.Next(0, dovusHamleleri.Length)];
                string inlemeSesi = inleme[rnd.Next(0, inleme.Length)];
                int damage = rnd.Next(1, karakterhp);

                double damagePercentage = ((double)damage/ karakterhp) * 100;

                dusmancan -= damage;

                if (dusmancan <= 0)
                {
                    Console.WriteLine($"{dusmanadi} artık savaşamayacak kadar yorgun ve bitkin! Çok geçmeden yere düşüp bayılıyor!");
                    Console.WriteLine($"{karakteradi} savaşı kazandı!");
                    loopContiuning = false;
                }
                else if (damagePercentage >= 50)
                {
                    Console.WriteLine($"{karakteradi}, {dusmanadi} nın {yer} bölgesine sert bir {hamle} attı!");
                    Console.WriteLine($"{dusmanadi} Hamlenden dolayı geri sendeledi! Toplamda {damage} hasar verdin!");
                    diyalogyazdir(inleme, dusmanadi);
                }
                else if (damagePercentage >=10 && damagePercentage < 50)
                {
                    Console.WriteLine($"{karakteradi}, {dusmanadi} nın {yer} bölgesine bir {hamle} attı!");
                    Console.WriteLine($"{dusmanadi} İnledi, ama sonra gardını tekrar toparladı! Toplamda {damage} hasar verdin!");
                    diyalogyazdir(inleme, dusmanadi);
                }
                else
                {
                    string dalgaGecmeCumlesi = dalgaGecmeCumleleri[rnd.Next(0, dalgaGecmeCumleleri.Length)];
                    Console.WriteLine($"{karakteradi}, {dusmanadi} nın {yer} bölgesine bir  {hamle} atmayı denedi!");
                    Console.WriteLine($"{dusmanadi} hamleni kolaylaca blokladı! Toplamda {damage} hasar verdin!");
                    diyalogyazdir(dalgaGecmeCumleleri, dusmanadi);
                }
                siraDusmanda = true;

            }
            void dusmanAI()
            {
                int damage = rnd.Next(1, dusmanhp);
                string movement  = dovusHamleleri[rnd.Next(0, dovusHamleleri.Length)];
                string place = yerler[rnd.Next(0, yerler.Length)];
                int healHP = rnd.Next(1, 25);

                double canYuzdesi = (double)dusmancan / dusmancanMax;
                double enemyChanceToUseHealingPotion = (1.0 - canYuzdesi) * 100;
                double randomChance =  rnd.Next(0,100);

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
                    if( karaktercan  <= 0 )
                    {
                        Console.WriteLine($"{karakteradi} artık savaşamayacak kadar yorgun ve bitkin! Çok geçmeden yere düşüp bayılıyor!");
                        Console.WriteLine($"{dusmanadi} savaşı kazandı!");
                        loopContiuning = false;
                    }
                }
            }
            void diyalogyazdir(string[] soz, string konusmaciadi)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine($"{konusmaciadi}: {soz[rnd.Next(0, soz.Length)]}");
                Console.WriteLine("------------------------------------------------------------");
            }
        }
    }
}

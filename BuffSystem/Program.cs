using BuffSystem;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BuffSystem
{
    class Heart
    {
        public int Speed;
        public int rightSideWeight;
        public int LeftSideWeight;
        public int RythmRegularless;
        public int BloodPressure;

        public void kendinianalizederektanit()
        {
            string tanıtımcumlesi;

            if (Speed == 0)
            {
                tanıtımcumlesi = "Kalp hızı normal, değiştirici etken yok.";
            }
            else if (Speed > 0)
            {
                tanıtımcumlesi = "Kalp hızı artmış, kalp daha hızlı atıyor.";
            }
            else
            {
                tanıtımcumlesi = "Kalp hızı azalmış, kalp daha yavaş atıyor.";
            }

            if (rightSideWeight == 0)
            {
                tanıtımcumlesi += " Kalbin sağ taraf ağırlığı normal, değiştirici etken yok.";
            }
            else if (rightSideWeight > 0)
            {
                tanıtımcumlesi += " Kalbin sağ taraf ağırlığı artmış, kalp daha fazla yük taşıyor.";
            }
            else
            {
                tanıtımcumlesi += " Kalbin sağ taraf ağırlığı azalmış, kalp daha az yük taşıyor.";
            }

            if (LeftSideWeight == 0)
            {
                tanıtımcumlesi += " Kalbin sol taraf ağırlığı normal, değiştirici etken yok.";

            }
            else if (LeftSideWeight > 0)
            {
                tanıtımcumlesi += " Kalbin sol taraf ağırlığı artmış, kalp daha fazla yük taşıyor.";
            }
            else
            {
                tanıtımcumlesi += " Kalbin sol taraf ağırlığı azalmış, kalp daha az yük taşıyor.";
            }

            if (RythmRegularless == 0)
            {
                tanıtımcumlesi += " Kalp ritmi düzenli, değiştirici etken yok.";
            }
            else if (RythmRegularless > 0)
            {
                tanıtımcumlesi += " Kalp ritmi düzenli, kalp daha düzenli atıyor.";
            }
            else
            {
                tanıtımcumlesi += " Kalp ritmi düzensiz, kalp daha düzensiz atıyor.";
            }
            if (BloodPressure == 0)
            {
                tanıtımcumlesi += " Kan basıncı normal, değiştirici etken yok.";
            }
            else if (BloodPressure > 0)
            {
                tanıtımcumlesi += " Kan basıncı artmış, kalp daha fazla yük taşıyor.";
            }
            else
            {
                tanıtımcumlesi += " Kan basıncı azalmış, kalp daha az yük taşıyor.";
            }
            Console.WriteLine($"{tanıtımcumlesi}");
        }
    }
    class Buff
    {
        public string BuffName;
        public int Buff_speed;
        public int Buff_rightSideWeight;
        public int Buff_leftSideWeight;
        public int Buff_rythmRegularless;
        public int Buff_bloodPressure;

        public Buff(string name, int speed, int rightside, int leftside, int rythm, int bloodpressure)
        {
            BuffName = name;
            Buff_speed = speed;
            Buff_rightSideWeight = rightside;
            Buff_leftSideWeight = leftside;
            Buff_rythmRegularless = rythm;
            Buff_bloodPressure = bloodpressure;
        }

            public void kendinitanit()
            {
                Console.WriteLine($"Buff Adı: {BuffName}");
                Console.WriteLine($"Buff Kalp Hızı Etkisi: {Buff_speed}");
                Console.WriteLine($"Buff Kalp Sağ Taraf Ağırlığı Etkisi: {Buff_rightSideWeight}");
                Console.WriteLine($"Buff Kalp Sol Taraf Ağırlığı Etkisi : {Buff_leftSideWeight}");
                Console.WriteLine($"Buff Ritim Düzenliliği Etkisi: {Buff_rythmRegularless}");
                Console.WriteLine($"Buff Kan Basıncı Etkisi: {Buff_bloodPressure}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool loopcountinuing = true;
            List<Buff> Buffs = new List<Buff>();
            Heart kalp = new Heart();

        Buff ASD = new Buff("ASD", 5,10,0,-2,1);

          Buffs.Add(ASD);

        while (loopcountinuing)
            {

                Console.WriteLine($"------------------------------------------------------------------------");

                Console.WriteLine("Yapılacak İşlem Seçin: ");
                Console.WriteLine("1-Tüm Bufflara bak");
                Console.WriteLine("2-Buff Oluştur ");
                Console.WriteLine("3- Tüm oluşturduğun buffların toplamının kalbe etkisini gör ");
                Console.WriteLine("4- Çıkış ");
                Console.WriteLine($"------------------------------------------------------------------------");

                int cevap = Getintvalue("Seçiminizi yapın: ");

                switch (cevap)
                {
                    case 1:
                    foreach (var buff in Buffs)
                    {
                        buff.kendinitanit();
                        Console.WriteLine($"------------------------------------------------------------------------");
                    }
                    break;
                case 2:
                    Buff yeniBuff = Buffolustur();
                    Buffs.Add(yeniBuff);
                    Console.WriteLine("Buff Oluşturuldu");
                    Console.WriteLine($"------------------------------------------------------------------------");
                    break;
                case 3:
                    int toplamHiz = 0;
                    int toplamSag= 0 ;
                    int toplamSol = 0 ;
                    int toplamRitim = 0;
                    int toplamKan = 0;
                    
                    foreach(var deger in Buffs)
                    {
                        toplamHiz += deger.Buff_speed;
                        toplamSag += deger.Buff_rightSideWeight;
                        toplamSol += deger.Buff_leftSideWeight;
                        toplamRitim += deger.Buff_rythmRegularless;
                        toplamKan += deger.Buff_bloodPressure;
                    }
                    kalp.Speed = toplamHiz;
                    kalp.rightSideWeight = toplamSag;
                    kalp.LeftSideWeight = toplamSol;
                    kalp.RythmRegularless = toplamRitim;
                    kalp.BloodPressure = toplamKan;

                    kalp.kendinianalizederektanit();
                    break;

                case 4:
                    loopcountinuing = false;
                    break;
            }

            }


            

        }

        public static int Getintvalue(string soru)
        {
            Console.WriteLine(soru);
            int deger = int.Parse(Console.ReadLine());
            return deger;
        }
        public static Buff Buffolustur()
        {
           
            Console.WriteLine("Buffun Adını Girin: ");
            string buffadi = Console.ReadLine();
           Console.WriteLine("Buffun Kalp Hızı Etkisni girin;");
           int hiz = Getintvalue("Buffun Kalp Hızı Etkisni girin; ");
           int sag = Getintvalue("Buffun Kalp Sağ Taraf Ağırlığı Etkisini girin; ");
           int sol = Getintvalue("Buffun Kalp Sol Taraf Ağırlığı Etkisini girin; ");
           int ritim = Getintvalue("Buffun Ritim Düzenliliği Etkisini girin; ");
           int kan= Getintvalue("Buffun Kan Basıncı Etkisini girin; ");
          return new Buff(buffadi, hiz, sag, sol, ritim, kan);
    }
       
    }


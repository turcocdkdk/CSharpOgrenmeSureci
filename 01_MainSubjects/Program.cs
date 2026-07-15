using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdirmaKomutlari
            //Console.WriteLine("Merhaba Dünya!");
            //Console.Write("Selam");

            //Console.WriteLine("----  Yiyecek/İçecek Çeşitleri ----");
            //Console.WriteLine();
            //Console.WriteLine("1-Yiyecekler");
            //Console.WriteLine("2-İçecekler");
            //Console.WriteLine("3-Tatlılar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine();
            //Console.WriteLine("----  Yiyecek/İçecek Çeşitleri ----");
            #endregion

            #region Değişkenler
            //Değişkenler

            //String
            //Değişken_türü Değişken_adı;

            //string name ;
            //name = "Umut";
            //Console.Write(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            Console.Write("Adınızı Girin: ");
            customerName = Console.ReadLine();
            Console.Write("Soyadınızı Girin: ");
            customerSurname = Console.ReadLine();
            Console.Write("Telefon Numaranızı Girin: ");
            customerPhone = Console.ReadLine();
            Console.Write("Emalinizi Girin: ");
            customerEmail = Console.ReadLine();
            Console.Write("İlçenizi Girin: ");
            district = Console.ReadLine();
            Console.Write("Şehirinizi Girin: ");
            city = Console.ReadLine();

            Console.WriteLine("İşleniyor...");
            Console.WriteLine("Biti!");
            
            Console.WriteLine();

            Console.WriteLine("**** Umut Lokanta- Rezerbasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("İletişim Bilgileri: " + customerPhone + "/" + customerEmail);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Adres Bilgileri: " + district + "/" + city);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("**** Umut Lokanta- Rezerbasyon Kartı ****");

            Console.WriteLine();

            Console.WriteLine("----  Yiyecek/İçecek Çeşitleri ----");
            Console.WriteLine();
            Console.WriteLine("1-Yiyecekler");
            Console.WriteLine("2-İçecekler");
            Console.WriteLine("3-Tatlılar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine();
            Console.WriteLine("----  Yiyecek/İçecek Çeşitleri ----");

            Console.WriteLine();

            Console.Write("Bir kategori seçin: ");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("----  Yiyecek Çeşitleri ----");
                Console.WriteLine();
                Console.WriteLine("1-Adana kebap");
                Console.WriteLine("2-Lahmacun");
                Console.WriteLine("3-Tavuk dürüm");
                Console.WriteLine("4-Köfte");
                Console.WriteLine("5-Kuru Fasülye/ Pilav");
                Console.WriteLine();
                Console.WriteLine("----  Yiyecek Çeşitleri ----");
            }

            else if (secim == 2)
            {
                Console.WriteLine("----  İçecek Çeşitleri ----");
                Console.WriteLine();
                Console.WriteLine("1-Kola");
                Console.WriteLine("2-Fanta");
                Console.WriteLine("3-Sprite");
                Console.WriteLine("4-Ayran");
                Console.WriteLine("5-Soda");
                Console.WriteLine();
                Console.WriteLine("----  İçecek Çeşitleri ----");
            }

            else if (secim == 3)
            {
                Console.WriteLine("----  Tatlı Çeşitleri ----");
                Console.WriteLine();
                Console.WriteLine("1-Künefe");
                Console.WriteLine("2-Dondurma");
                Console.WriteLine("3-Suffle");
                Console.WriteLine("4-Baklava");
                Console.WriteLine();
                Console.WriteLine("----  Tatlı Çeşitleri ----");
            }
            else if (secim == 4)
            {
                Console.WriteLine("----  Salata Çeşitleri ----");
                Console.WriteLine();
                Console.WriteLine("1-Salata");
                Console.WriteLine("2-Soğanlı Salata");
                Console.WriteLine();
                Console.WriteLine("----  Salata Çeşitleri ----");
            }
            else
            {
                Console.WriteLine("Hata! yanlık değer girdiniz, lütfen programı yeniden başlatın.");
            }
            int cost = 500;
            Console.WriteLine("Menümüzü İncelediğiniz için Teşekkür ederiz! Bizden %30 indirim kazandınız!!");
            Console.WriteLine("Hesabınız " + cost + "TL den " + cost*0.30 + "TL ye düştü!");
            double cost2 = cost * 0.30;
            #endregion

            Console.Read();
        }
    }
}




//Yazdırma kıomutları
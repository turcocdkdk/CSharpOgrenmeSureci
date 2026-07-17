using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RestaurantProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loopContiuning = true;
            List<int> orders = new List<int>();
            List<string> orderedFoodNames = new List<string>();
            string[] foods = { "Adana kebap", "Lahmacun", "Pizza", "Hamburger", "Mantı" };
            string[] drinks = { "Kola", "Fanta", "İce tea", "Sprite", "Soda" };
            string[] desserts = { "Künefe", "Dondurma" };
            int[] foodprices = { 320, 250, 200, 210, 100 };
            int[] drinkprices = { 50, 50, 30, 50, 40 };
            int[] dessertprices = { 50, 50 };

            Console.WriteLine("---- UMUT LOKANTA PRO 2.0 ----");

            while (loopContiuning)
            {
                Console.WriteLine("**** Kategoriler ****");
                Console.WriteLine("1- Yemekler");
                Console.WriteLine("2- İçecekler");
                Console.WriteLine("3- Tatlılar");
                Console.WriteLine("4- Çıkış");
                Console.WriteLine("5-Hesabı Topla");
                Console.WriteLine("**** Kategoriler ****");

                Console.WriteLine();

                Console.Write("Kategori Seçin: ");
                string desicion = Console.ReadLine();

                switch (desicion)
                {
                    case  "1":
                        for (int i = 0; i < foods.Length; i++)
                        {
                            Console.WriteLine($"{i}-{foods[i]}");
                        }
                        Console.Write("Sipariş vermek istediğiniz yiyeceğin numarasını yazın;");
                        int fooddec  = int.Parse(Console.ReadLine());
                        if(fooddec >= 0 && fooddec < foods.Length)
                        {
                            orders.Add(foodprices[fooddec]);
                            orderedFoodNames.Add(foods[fooddec]);
                            Console.WriteLine($"{foods[fooddec]}-{foodprices[fooddec]}TL- Siparişiniz başarı ile eklendi!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hata, lütfen tekrar deneyin.");
                            break;
                        }

                    case "2":
                        for(int i = 0; i<drinks.Length;i++)
                        {
                            Console.WriteLine($"{i}-{drinks[i]}");
                        }
                        Console.Write("Sipariş vermek istediğiniz içeceğin numarasını yazın;");
                        int drinkdec = int.Parse(Console.ReadLine());
                        if(drinkdec>=0 && drinkdec < drinks.Length)
                        {
                            orders.Add(drinkprices[drinkdec]);
                            orderedFoodNames.Add(drinks[drinkdec]);
                            Console.WriteLine($"{drinks[drinkdec]}-{drinkprices[drinkdec]}TL- Siparişiniz başarı ile eklendi!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hata, lütfen tekrar deneyin.");
                            break;
                        }
                    case "3":
                        for(int i = 0; i<desserts.Length; i++)
                        {
                            Console.WriteLine($"{i}-{desserts[i]}");
                        }
                        Console.Write("Sipariş vermek istediğiniz tatlının numarasını yazın;");
                        int dessertdec = int.Parse(Console.ReadLine());
                        if(dessertdec >= 0 && dessertdec < desserts.Length)
                        {
                            orders.Add(dessertprices[dessertdec]);
                            orderedFoodNames.Add(desserts[dessertdec]);
                            Console.WriteLine($"{desserts[dessertdec]}-{dessertprices[dessertdec]}Siparişiniz başarı ile eklendi!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hata, lütfen tekrar deneyin");
                            break;
                        }
                        
                    case "4":
                        Console.WriteLine("Yeniden bekleriz!");
                        loopContiuning = false;
                        break;
                    case "5":
                        int hesap = 0;
                        for(int i = 0; i < orderedFoodNames.Count; i++)
                        {
                            Console.WriteLine($"{orderedFoodNames[i]}-{orders[i]}TL");
                        })
                        foreach (int totalcheck in orders)
                        {
                          hesap += totalcheck;
                        }
                        Console.WriteLine($"Hesabınız {hesap} TL!");
                        break;
                    default:
                        Console.WriteLine("Hata, lütfen tekrar deneyin.");
                        break;
                }

            }
        } 
    }
}

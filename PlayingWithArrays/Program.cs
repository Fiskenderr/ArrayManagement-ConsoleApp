using System;

namespace Arrays
{
    class Program
    {
        static List<double> list = new List<double>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Dizi Yönetim Programi");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1-) Sayi Ekle");
                Console.WriteLine("2-) Sayi Cikar");
                Console.WriteLine("3-) Sayilari Listele");
                Console.WriteLine("4-) Sayilari Sirala (kucukten buyuge)");
                Console.WriteLine("5-) Sayilari Sirala (buyukten kucuge)");
                Console.WriteLine("6-) Sayi Ara");
                Console.WriteLine("7-) Cikis");

                Console.Write("Seciminiz: ");

                if(!int.TryParse(Console.ReadLine(), out int secim) || secim < 1 || secim > 7)
                {
                    Console.WriteLine("Yanlis Secim Yaptiniz!");
                    Console.ReadKey();
                    continue;
                }

                switch (secim)
                {
                    case 1:
                        sayiEkle();
                        break;
                    case 2:
                        sayiCikar();
                        break;
                    case 3:
                        sayiListele();
                        break;
                    case 4:
                        sayiKucukten();
                        break;
                    case 5:
                        sayiBuyukten();
                        break;
                    case 6:
                        sayiAra();
                        break;
                    case 7:
                        return;
                }
            }
        }

        static void sayiEkle()
        {
            Console.Write("Eklemek istediginiz sayi: ");
            if(!double.TryParse(Console.ReadLine(),out double sayi))
            {
                Console.WriteLine("Gecersiz sayi girisi! Devam etmek icin bir tusa basiniz...");
            }
            else
            {
                list.Add(sayi);
                Console.WriteLine("Sayi ekleme basarili! Devam etmek icin bir tusa basiniz...");
            }
            Console.ReadKey();
        }
        static void sayiCikar()
        {
            Console.Write("Cikarmak istediginiz sayi: ");
            if(!double.TryParse(Console.ReadLine(), out double sayi) || !list.Contains(sayi))
            {
                Console.WriteLine("Sayi listede bulunmamakta! Devam etmek icin bir tusa basiniz...");
            }
            else
            {
                list.Remove(sayi);
                Console.WriteLine("Sayi silme basarili! Devam etmek icin bir tusa basiniz...");
            }
            Console.ReadKey();
        }

        static void sayiListele()
        {
            Console.WriteLine("Sayilarin listelenmis halleri: ");
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i].ToString());
                Console.Write("\t");
            }
            Console.WriteLine("Sayi listeleme basarili! Devam etmek icin bir tusa basiniz...");
            Console.ReadKey();
        }

        static void sayiKucukten()
        {
            list.Sort();
            Console.WriteLine("Siralama basarili! Devam etmek icin bir tusa basiniz...");
            Console.ReadKey();
        }

        static void sayiBuyukten()
        {
            list.Sort();
            list.Reverse();
            Console.WriteLine("Siralama basarili! Devam etmek icin bir tusa basiniz...");
            Console.ReadKey();
        }
        static void sayiAra()
        {
            Console.WriteLine("Aradiginiz sayi: ");
            if(!double.TryParse(Console.ReadLine(), out double sayi))
            {
                Console.WriteLine("Gecersiz sayi girisi!");
            }
            else
            {
                if(list.Contains(sayi))
                    Console.WriteLine("Aradiginiz sayi listede mevcut! Devam etmek icin bir tusa basiniz...");
                else
                {
                    Console.WriteLine("Aradiginiz sayi listede mevcut degil! Devam etmek icin bir tusa basiniz...");
                }
            }
            Console.ReadKey ();
        }
    }
}

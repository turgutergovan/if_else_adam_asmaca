using System;

namespace decision
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int number;
             Console.WriteLine("Sayı giriniz..");

             number = Convert.ToInt32(Console.ReadLine());

             for (int i = 0; i < number; i++)
             {
                 if (i % 2 == 0)
                 {
                     Console.WriteLine(i+ ". deger -" + "çift sayıdır " + i);
                 }

                 else
                 {
                     Console.WriteLine(i+ ". deger -" + "tek sayıdır " + i);
                 }
             }

             Console.WriteLine("**************************************************");*/






            /* int number;
             Console.WriteLine("Sayı giriniz..");

             number = Convert.ToInt32(Console.ReadLine());

             for (int i = 0; i < number; i++)
             {


                     Console.WriteLine(i % 2 == 0 ? i + "çift sayıdır": i + "tek sayıdır" ) ;


             }
            Console.WriteLine("**************************************************");*/







            /* int number;
             Console.WriteLine("Sayı giriniz..");

             number = Convert.ToInt32(Console.ReadLine());



                 if(number>=0)
                     Console.WriteLine("Sayı pozitiftir");
                 else
                 {
                     Console.WriteLine("Sayı negatiftir.");
                 }
             Console.WriteLine("**************************************************"); */









            /* int number;
             Console.WriteLine("Not giriniz..");

             number = Convert.ToInt32(Console.ReadLine());



             if (number > 0 && number<=40)
             {
                 Console.WriteLine("FF");
             }

             if (number > 40 && number <= 60)
             {
                 Console.WriteLine("CC");
             }
             if (number > 60 && number <= 80)
             {
                 Console.WriteLine("BB");
             }
             if (number > 80 && number <= 100)
             {
                 Console.WriteLine("AA");
             }

             else
             {
                 Console.WriteLine("hata");
             }
             Console.WriteLine("**************************************************"); */





            /*SAYI TAHMİN OYUNU 

            int Randomsayi, tahmin;
            bool kazandıMı = false;
            Random rnd = new Random();

            Randomsayi = rnd.Next(5);
            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("sayı gir knk");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (Randomsayi == tahmin)
                {
                    
                    kazandıMı = true;
                    break;
                }

                

            }

            Console.WriteLine(kazandıMı? "Vay anasını bildin he." : "Kaybettin be kral: (" );
            Console.WriteLine("**************************************************"); */









            /*  Random random = new Random();
              string kelime = "araba";
              char[] aranacakKelime = new char[kelime.Length];
              for (int i = 0; i < kelime.Length; i++)
              {
                  aranacakKelime[i] = '*';

              }
              Console.WriteLine("Bir karakter yazın.");
              for (int i = 0; i < aranacakKelime.Length; i++)
              {
                  char karakterKelime = Console.ReadLine()[0];
                  if (kelime.Contains(karakterKelime))
                  {
                      aranacakKelime[kelime.IndexOf(karakterKelime)] = karakterKelime;
                      Console.WriteLine(aranacakKelime);
                  }

                  else
                  {
                      Console.WriteLine(aranacakKelime);
                  }

              }
              Console.Read();*/

            /*string[] kelimeler = { "araba", "elma", "yazı", "eldiven" };
            string secilenKelime;
            int hak = 5;
            Random rnd = new Random();
            secilenKelime = kelimeler[rnd.Next(0, kelimeler.Length - 1)];
            char[] yertutucu = new char[secilenKelime.Length];

            for (int i = 0; i < yertutucu.Length; i++)
            {
                yertutucu[i] = '-';
                Console.Write('-');
            }
            Console.WriteLine();

            while (true)
            {

                Console.WriteLine("Kalan Hak:{0}", hak);
                Console.Write("Bir harf girin   :");
                char harf = Convert.ToChar(Console.ReadLine());

                bool bayrak = false;
                int kalanKelime = 0;
                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (secilenKelime[i] == harf)
                    {
                        yertutucu[i] = harf;
                        bayrak = true;
                    }
                    if (yertutucu[i] == '-')
                    {
                        kalanKelime++;
                    }
                    Console.Write(yertutucu[i]);
                }
                Console.WriteLine();

                if (kalanKelime == 0)
                {
                    Console.WriteLine("Tebrikler...");
                    break;
                }

                if (bayrak == false)
                {
                    hak--;
                }

                if (hak == 0)
                {
                    Console.WriteLine("Üzgünüm kaybettiniz.");
                    break;
                }

                Console.WriteLine("******************");
            }

            Console.Write("Seçtiğim kelime << {0} >>", secilenKelime);
            Console.ReadLine();*/


        }
        

    }
}

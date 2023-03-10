using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stack_yazma
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] elemanlar = new int[5]; // 5 elemanl? bir dizi olu?turduk
            int top, girdi, sonEleman; // baz? kontrol yapaca??m?z, girdi alaca??m?z de?i?kenler tan?mlad?k
            top = -1; // kontrol yap?ca??m?z de?i?kene de?er atad?k


            void Push(int de?er) // Burda kullan?c? taraf?ndan girilen de?erleri diziye atad?k ve e?er dizi doluysada bildirim g?nderdik
            {
                if (top == 4) // Girilen de?erler diziyi doldurduysa
                {
                    Console.WriteLine("!!! Stack dolu !!!"); // Burda uyar? verecek
                    return;
                }
                else
                {
                    top++; // E?er dolu de?ilse bir artt?racak
                    elemanlar[top] = de?er; // ve diziye atayacak
                }
            }


            void Pop() // Burda dizideki son girilen eleman? ??kart?yoruz
            {
                if (top == -1) // Dizi bo?sa uyar? gelecek
                {
                    Console.WriteLine("!!! Stack zaten bo? !!!");
                }
                else
                {
                    top--; // Bo? de?ilsede bir azaltacak
                }
            }


            void showLast() // Dizinin son eleman?n? ekrana yazd?r?yoruz
            {
                Console.WriteLine(sonEleman = elemanlar.Last());
            }


            void Yazdir() // Dizinin i?indeki elemanlar? ekrana yazd?r?yoruz
            {
                for (int i = 0; i < top + 1; i++)
                {
                    Console.WriteLine(elemanlar[i]);
                }
            }


            while (true) // S?rekli i?lem yapabilmemiz i?in sonsuz d?ng?ye ald?m
            {
                Console.WriteLine("\n1-Push");
                Console.WriteLine("2-Pop");           // Burada ekranda bize yapabilece?imiz i?lemleri g?steriyor
                Console.WriteLine("3-showLast");
                Console.WriteLine("4-Yazdir");

                Console.Write("\n??leminizi se?iniz: "); // Burda yapaca??m?z i?lemin ba??ndaki numaray? giriyoruz
                girdi = Convert.ToInt32(Console.ReadLine());


                switch (girdi) // switch-case alarak tan?mlad???m?z metotlar? ?a??r?yoruz 
                {
                    case 1:
                        Console.Write("Say? giriniz: ");
                        int sayi = Convert.ToInt32(Console.ReadLine());
                        Push(sayi);
                        break;

                    case 2:
                        Pop();
                        break;

                    case 3:
                        showLast();
                        break;

                    case 4:
                        Yazdir();
                        break;

                    default: // E?er kullan?c? farkl? bir girdi girerse uyar?lacak
                        Console.WriteLine("!!! L?tfen ge?erli bir i?lem numaras? giriniz !!!");
                        break;
                }

                Console.ReadKey(); // Ekran? a??k tutuyor 

            }
        }
    }
}

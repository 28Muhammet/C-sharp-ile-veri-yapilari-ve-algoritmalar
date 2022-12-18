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
            int[] elemanlar = new int[5]; // 5 elemanlý bir dizi oluþturduk
            int top, girdi, sonEleman; // bazý kontrol yapacaðýmýz, girdi alacaðýmýz deðiþkenler tanýmladýk
            top = -1; // kontrol yapýcaðýmýz deðiþkene deðer atadýk


            void Push(int deðer) // Burda kullanýcý tarafýndan girilen deðerleri diziye atadýk ve eðer dizi doluysada bildirim gönderdik
            {
                if (top == 4) // Girilen deðerler diziyi doldurduysa
                {
                    Console.WriteLine("!!! Stack dolu !!!"); // Burda uyarý verecek
                    return;
                }
                else
                {
                    top++; // Eðer dolu deðilse bir arttýracak
                    elemanlar[top] = deðer; // ve diziye atayacak
                }
            }


            void Pop() // Burda dizideki son girilen elemaný çýkartýyoruz
            {
                if (top == -1) // Dizi boþsa uyarý gelecek
                {
                    Console.WriteLine("!!! Stack zaten boþ !!!");
                }
                else
                {
                    top--; // Boþ deðilsede bir azaltacak
                }
            }


            void showLast() // Dizinin son elemanýný ekrana yazdýrýyoruz
            {
                Console.WriteLine(sonEleman = elemanlar.Last());
            }


            void Yazdir() // Dizinin içindeki elemanlarý ekrana yazdýrýyoruz
            {
                for (int i = 0; i < top + 1; i++)
                {
                    Console.WriteLine(elemanlar[i]);
                }
            }


            while (true) // Sürekli iþlem yapabilmemiz için sonsuz döngüye aldým
            {
                Console.WriteLine("\n1-Push");
                Console.WriteLine("2-Pop");           // Burada ekranda bize yapabileceðimiz iþlemleri gösteriyor
                Console.WriteLine("3-showLast");
                Console.WriteLine("4-Yazdir");

                Console.Write("\nÝþleminizi seçiniz: "); // Burda yapacaðýmýz iþlemin baþýndaki numarayý giriyoruz
                girdi = Convert.ToInt32(Console.ReadLine());


                switch (girdi) // switch-case alarak tanýmladýðýmýz metotlarý çaðýrýyoruz 
                {
                    case 1:
                        Console.Write("Sayý giriniz: ");
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

                    default: // Eðer kullanýcý farklý bir girdi girerse uyarýlacak
                        Console.WriteLine("!!! Lütfen geçerli bir iþlem numarasý giriniz !!!");
                        break;
                }

                Console.ReadKey(); // Ekraný açýk tutuyor 

            }
        }
    }
}

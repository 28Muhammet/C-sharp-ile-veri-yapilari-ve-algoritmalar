using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[5];
            int front, rear;
            front = 0;
            rear = 0;

            void enQueue(int value)
            {
                if (rear < list.Length - 1)
                {
                    rear++;
                    list[rear] = value;
                }
                else
                {
                    Console.WriteLine("!!! Queue dolu !!!");
                    return;
                }
            }

            void deQueue()
            {
                if (front <= rear)
                {
                    front++;
                    int removedElement = list[front - 1];
                    list[front - 1] = 0;
                    return;
                }
                else
                {
                    Console.WriteLine("!!! Queue boþ !!!");
                    return;
                }
            }

            void Yazdir()
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }

            while (true)
            {
                Console.WriteLine("\n1-enQueue");
                Console.WriteLine("2-deQueue");

                Console.Write("\nYapacaðýnýz iþlemi seçiniz: ");
                int girdi = Convert.ToInt32(Console.ReadLine());

                switch (girdi)
                {
                    case 1:
                        Console.Write("Deðer giriniz: ");
                        int deðer = Convert.ToInt32(Console.ReadLine());
                        enQueue(deðer);
                        Yazdir();
                        break;

                    case 2:
                        deQueue();
                        Yazdir();
                        break;

                    default:
                        Console.WriteLine("!!! Lütfen geçerli bir iþlem numarasý giriniz !!!");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
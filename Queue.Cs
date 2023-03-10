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
                    Console.WriteLine("!!! Queue bo? !!!");
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

                Console.Write("\nYapaca??n?z i?lemi se?iniz: ");
                int girdi = Convert.ToInt32(Console.ReadLine());

                switch (girdi)
                {
                    case 1:
                        Console.Write("De?er giriniz: ");
                        int de?er = Convert.ToInt32(Console.ReadLine());
                        enQueue(de?er);
                        Yazdir();
                        break;

                    case 2:
                        deQueue();
                        Yazdir();
                        break;

                    default:
                        Console.WriteLine("!!! L?tfen ge?erli bir i?lem numaras? giriniz !!!");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
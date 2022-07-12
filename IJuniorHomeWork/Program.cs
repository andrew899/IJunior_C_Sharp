using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> clientsSumsToPay = new Queue<int>();
            int shopAccount = 0;

            clientsSumsToPay.Enqueue(100);
            clientsSumsToPay.Enqueue(200);
            clientsSumsToPay.Enqueue(150);
            clientsSumsToPay.Enqueue(130);

            while (clientsSumsToPay.Count != 0)
            {
                Console.WriteLine($"Shop account: {shopAccount}.");
                int clientSum = clientsSumsToPay.Dequeue();
                Console.WriteLine($"Client pays: {clientSum}.");
                shopAccount += clientSum;
                Console.WriteLine($"Enter any key to proceed to next client. Client left: {clientsSumsToPay.Count}.");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine($"Queue end. Shop account {shopAccount}.");
        }
    }
}

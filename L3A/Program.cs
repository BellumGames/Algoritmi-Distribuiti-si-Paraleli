using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ec2
{
    class Program
    {
        public static void Main(string[] args)
        {
            new CustomerProductor();
        }
    }

    public class CustomerProductor 
    {
        int stock = 0;
        Thread customer;
        Thread productor;
        ManualResetEvent StockFull = new ManualResetEvent(false);
        ManualResetEvent StockEmpty = new ManualResetEvent(false);

        public CustomerProductor() 
        {
            customer = new Thread(new ThreadStart(ComputeC));
            productor = new Thread(new ThreadStart(ComputeP));
            StockEmpty.Set();
            customer.Start();
            productor.Start();
        }

        public void ComputeC() 
        {
            while (true) 
            {
                StockFull.WaitOne();
                while (stock > 0)
                {
                    stock--;
                    Console.WriteLine(stock);
                    Thread.Sleep(500);
                }
                StockEmpty.Set();
                StockFull.Reset();
            }
        }

        public void ComputeP() 
        {
            while (true) 
            {
                StockEmpty.WaitOne();
                while (stock < 10)
                {
                    stock++;
                    Console.WriteLine(stock);
                    Thread.Sleep(500);
                }
                StockFull.Set();
                StockEmpty.Reset();
            }
        }
    }
}
using System;
using System.Diagnostics.CodeAnalysis;
using MPI;

namespace L7_PingPong
{
    class PingPong
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            //nr task pt fiecare proces
            int d = 0;
            using (new MPI.Environment(ref args))
            {
                Intracommunicator comm = Communicator.world;
                d = comm.Size / array.Length;
                if (comm.Rank == 0)
                {
                    Console.WriteLine("Rank 0 is alive and running on " + MPI.Environment.ProcessorName);
                    for (int i = 0; i < d; d++)
                    {
                        sum += array[i];
                    }
                    for (int dest = 1; dest < comm.Size; ++dest) 
                    {
                        sum += comm.Receive<int>(dest, 0);
                    }
                    Console.WriteLine($"Suma este = {sum}");
                }
                else
                {
                    //lim inf pt suma
                    int limInf = comm.Rank * d;
                    //lim sup pt suma
                    int limSup = limInf * d;
                    if (comm.Rank == comm.Size - 1) 
                    {
                        limSup = array.Length;
                    }
                    for (int i = limInf; i < limSup; i++)
                    {
                        sum += array[i];
                    }
                    comm.Send<int>(sum, 0, 0);
                }
            }
        }
    }
}

using System;

namespace _1_Abstract_Factry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new ArtDecoFactory());
            client.Run();
            Console.WriteLine();

            var client1 = new Client(new VictorianFactory());
            client1.Run1();

            Console.WriteLine();
            var client2 = new Client(new ModernFactory());
            client2.Run2();
        }
    }
}

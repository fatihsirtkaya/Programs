using Ninject;
using System;

namespace HepsiBurada
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IBusiness>().To<Business>();

            var service = kernel.Get<IBusiness>();


            Console.WriteLine("Please Enter Rovers Position");
            var position = Console.ReadLine();

            Console.WriteLine("Please Enter Orders");
            var orders = Console.ReadLine();

            Console.WriteLine(service.CalculateFinalPosition(position + Environment.NewLine + orders));
        
        }
    }
}

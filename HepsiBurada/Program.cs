using HepsiBurada.Validation;
using Ninject;
using System;

namespace HepsiBurada
{
    class Program
    {
        static void Main(string[] args)
        {
            #region RegisterIOCContainer
            IKernel kernel = new StandardKernel();
            kernel.Bind<ICalculate>().To<Calculate>();
            var service = kernel.Get<ICalculate>();
            #endregion

            while (true)
            {
                Console.WriteLine("Please Enter Rovers Position ");
                var position = Console.ReadLine();


                while (!position.PositionValidate())
                {
                    Console.WriteLine("Please Enter Valid Rovers Position ");
                    position = Console.ReadLine();
                }

                Console.WriteLine("Please Enter Orders ");
                var orders = Console.ReadLine();

                while (!orders.OrderValidate())
                {
                    Console.WriteLine("Please Enter Valid Rovers Position");
                    orders = Console.ReadLine();
                }

                Console.WriteLine(service.CalculateFinalPosition(position, orders));
            }

        }

    }
}

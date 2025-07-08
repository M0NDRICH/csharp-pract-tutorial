// See https://aka.ms/new-console-template for more information

using SimpleNON_OOPVsOOPSolidPrinciple.BenefitsOfOOP.WithOOP;
using SimpleNON_OOPVsOOPSolidPrinciple.BenefitsOfOOP.WithoutOOP;
using SimpleNON_OOPVsOOPSolidPrinciple.SOLID;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleNON_OOPVsOOPSolidPrinciple;

namespace SimpleNONOOPVsOOPSolidPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- OPP and SOLID Principle --
            #region -- Without OOP and With OOP --
            /*
            Console.WriteLine("*** WITHOUT OOP ***");
            new SimpleOperationWithoutOOP().Process();

            Console.WriteLine("*** USING OOP ***");
            new SimpleOperationWithOOP().Process();
            */
            #endregion

            #region -- OpenClose Principle --
            /*
            Console.WriteLine("*** [NON]-OpenClosed ***");
            new SimpleCalculator()
                .Calculate(new Operation[]
                {
                    new Add() { A = 5, B = 5 },
                    new Subtract() { A = 5, B = 5},
                    new Multiply() { A = 5, B = 5}
                });

            Console.WriteLine("*** USING - OpenClosed ***");
            new SimpleCalculatorV2()
                .Calculate(new IOperation[] {
                    new AddV2() { A = 5, B = 5 },
                    new SubtractV2() { A = 5, B = 5}
                });
            */
            #endregion
            #endregion

            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<IRepository, DatabaseRepository>();
                    //services.AddScoped<IRepository, DatabaseRepository>();
                    //services.AddTransient<IRepository, DatabaseRepository>();
                    services.AddHostedService<Worker>();
                });
    }
}
using Microsoft.Extensions.Hosting;
using SimpleNON_OOPVsOOPSolidPrinciple.BenefitsOfOOP.WithOOP;
using SimpleNON_OOPVsOOPSolidPrinciple.BenefitsOfOOP.WithoutOOP;
using SimpleNON_OOPVsOOPSolidPrinciple.SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNON_OOPVsOOPSolidPrinciple
{
    internal class Worker : BackgroundService
    {
        private readonly IRepository _repository;
        public Worker(IRepository repository)
        {
            _repository = repository;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine("*** WITHOUT OPP ");
            new SimpleOperationWithoutOOP().Process();

            Console.WriteLine("*** USING OPP ");
            new SimpleOperationWithOOP().Process();

            Console.WriteLine("*** [NON]-OpenClosed ***");
            new SimpleCalculator()
                .Calculate(new Operation[]
                {
                    new Add() { A = 5, B = 5 },
                    new Subtract() { A = 5, B = 5 },
                    new Multiply() { A = 5, B = 5 }
                });

            Console.WriteLine("*** USING - OpenClosed ***");
            new SimpleCalculatorV2()
                .Calculate(new IOperation[] {
                    new AddV2() { A = 5, B = 5 },
                    new SubtractV2() { A = 5, B = 5 },
                });

            var manager = new Manager();
            var staff = new Staff();
            manager.DoWork();
            manager.CheckSubordinates();

            staff.DoWork();
            //staff.CheckSubordinates(); //will throw an error "NotImplemented exception"

            var staffV2 = new StaffV2();
            staffV2.DoWork();

            ITrabahador trabahador = new TagaLaba() { Name = "Frace" };
            trabahador.Maglaba();

            trabahador.MaghugasPlato();
            trabahador.MagPlantsa();

            ITagaLaba tagaLaba = new TagaLabav2() { Name = "Frace v2 - Tagalaba version" };
            tagaLaba.Maglaba();
            Console.WriteLine($"{tagaLaba.Name}");
            //tagaLaba.MaghugasPlato(); not available
            ITrabahador2 empleyado = new TagaLabav2() { Name = "Frace v2 - Trabahador version" };
            Console.WriteLine($"{empleyado.Name}");

            var repo = new Repository();
            repo.Add();
            repo.Delete();

            //without injection

            IRepository dbRepository = new DatabaseRepository();
            dbRepository.Add();

            //with injection
            _repository.Add();
        }
    }
}

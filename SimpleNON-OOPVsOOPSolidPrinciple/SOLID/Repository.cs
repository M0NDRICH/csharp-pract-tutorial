using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNON_OOPVsOOPSolidPrinciple.SOLID
{
    public class Repository
    {
        public void Add()
        {
            //with 1000+ line of code here
            Console.WriteLine("Add using DB");
        }
        public void Delete()
        {
            //with 1000+ line of codes here
            Console.WriteLine("Delete using DB");
        }
        /*
        Example code:
        var repo = new Repository();
        repo.Add();
        repo.Delete();
        */
    }

    #region -- Dependency Inversion --
    public interface IRepository
    {
        void Add();
        void Delete();
    }
    public class DatabaseRepository : IRepository
    {
        public void Add()
        {
            Console.WriteLine("Add using DB");
        }
        public void Delete()
        {
            Console.WriteLine("Delete using DB");
        }
        /*
         * Example code for WebAPI
         * IRepository dbRepository = new DatabaseRepository();
         * dbRepository.Add();
        */

    }

    #region -- Changed Implementaion using API --

    public class APPIIntegrationRepository : IRepository
    {
        public void Add()
        {
            Console.WriteLine("Add using WebAPI");
        }
        public void Delete()
        {
            Console.WriteLine("Delete using WebAPI");
        }

        
    }

    #endregion

    #region -- Changed Implementation using File --

    #endregion

    #endregion

}

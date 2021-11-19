using System;
using Frank_DB_Task.DataModels;


namespace Frank_DB_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            using MyDatabaseContext myContext = new MyDatabaseContext();
            myContext.Persons.Add(new Person()
            { FirstName = "Alex",
              LastName = "Walker"
            }
    
            );
            myContext.Addresses.Add(new Address()
            {
                Town = "New York",
                Street = "Downtown",
                HouseNumber = "7d"
            }
            );
            myContext.SaveChanges();
        }
    }
}

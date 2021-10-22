using Microsoft.EntityFrameworkCore;
using System;

namespace DatabaseFirstExample
{
    class Program
    {
       
        public class TourbusContext : DbContext
        {
            public TourbusContext()
            {
            }
        }
        public static void Main(string[] args)
        {
            //using (var dbCtx = new TourbusContext())
            //{
            //    dbCtx.Passengers.Add(new Passenger
            //    {
            //        PName = " Customer A",
            //        DOB = new DateTime(),
            //        TravelDate = new DateTime()
            //    });
            //    dbCtx.SaveChanges();
            //    foreach (var passenger in dbCtx.Passengers)
            //    {
            //        Console.WriteLine(passenger.PName);
            //    }
            //}
        }

    }
}

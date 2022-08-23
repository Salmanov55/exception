using exceptions.Models;
using System;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Room htl = new Room();
            htl.Name = "titan";
            htl.PersonCapacity = 4;
            htl.Price = 300;
            Hotel hot = new Hotel();
            hot.Name = "Abseron Hotel";
            Console.WriteLine();
            try
            {

            }
            catch (NotFoundException)
            {

                throw;
            }
            catch (NotAvailableException)
            {

                throw;
            }
            finally
            {
                Console.WriteLine("Finaly");
            }
        }
    }
}

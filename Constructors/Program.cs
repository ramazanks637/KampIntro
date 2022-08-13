using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1,FirstName="Engin",LastName="Demiroğ",City="Ankara" };



            Customer customer2 = new Customer ( 2, "Derin", "Demiroğ", "Ankara" );




        }
    }
    class Customer
    {
        public Customer() // default constructor parametresi olmayan constructor
        {

        }
        
        public Customer(int Id,string firstName,string lastName,string city)
        {
            //Console.WriteLine("Yapıcı blok çalıştı");

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}

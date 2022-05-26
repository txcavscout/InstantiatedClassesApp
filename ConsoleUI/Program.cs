using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>();
            List<AddressModel> address = new List<AddressModel>();
            string firstName;

            do
            {
                Console.Write("Enter your first name: (type exit to stop): ");
                firstName = Console.ReadLine();

                if (firstName != "exit")
                {
                    Console.Write("Enter your last name: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Enter your email address: ");
                    string emailAdress = Console.ReadLine();

                    Console.Write("Enter your street address: ");
                    string streetAddress = Console.ReadLine();

                    Console.Write("Enter your city: ");
                    string city = Console.ReadLine();

                    Console.Write("Enter your state: ");
                    string state = Console.ReadLine();

                    Console.Write("Enter your zip: ");
                    string zip = Console.ReadLine();


                    PersonModel person = new PersonModel();
                    AddressModel addy = new AddressModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    person.EmailAddress = emailAdress;
                    addy.StreetAddress = streetAddress;
                    addy.City = city;
                    addy.State = state;
                    addy.Zip = zip;
                    people.Add(person);
                    address.Add(addy);
                    person.CurrentAddress = $"{streetAddress} {city} {state} {zip}";
                }

            } while (firstName.ToLower() != "exit");

            Console.Clear();
            Console.WriteLine();

            foreach (PersonModel peep in people)
            {
                Console.WriteLine($"{peep.FirstName} {peep.LastName} {peep.EmailAddress}");
                Console.WriteLine($"{peep.CurrentAddress}");
                Console.WriteLine();
                
            }


            Console.ReadLine();
        }
    }
}

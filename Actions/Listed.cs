using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phonebook.Data;

namespace phonebook.Actions
{
    public class Listed
    {
       public void ListingPhoneBook()
       {
            List<Person> _phonebook = new List<Person>();
        
            foreach (Person person in PBData.PhoneList)
            {
                Console.WriteLine("İsim: " + person.FirstName);
                Console.WriteLine("İsim: " + person.LastName);
                Console.WriteLine("İsim: " + person.PhoneNumber);
                Console.WriteLine("-" );
            }
       }
    }
}
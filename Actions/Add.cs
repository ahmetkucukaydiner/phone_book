using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phonebook.Data;

namespace phonebook.Actions
{
    public class Add
    {
        public void Added()
        {
            Console.WriteLine("Lütfen isim giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz: ");
            string number = Console.ReadLine();

            Person person = new Person();
            person.FirstName = name;
            person.LastName = surname;
            person.PhoneNumber = number;

            PBData.PhoneList.Add(person);
            Console.WriteLine("{0} {1} {2}",name,surname,number);

            Listed listedPersons = new Listed();
            listedPersons.ListingPhoneBook();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phonebook.Data;

namespace phonebook
{
    public class PBData
    {
        private static List<Person> _phoneList;

        static PBData()
        {
            _phoneList = new List<Person>()
            {
                new Person{FirstName= "Ahmet", LastName="Küçükaydıner", PhoneNumber= "3243243232" },
                new Person{FirstName= "Deniz", LastName="Küçükaydıner", PhoneNumber= "4242424242" },
                new Person{FirstName= "Meltem", LastName="Küçükaydıner", PhoneNumber= "5252525252" },
                new Person{FirstName= "Gülşah", LastName="Küçükaydıner", PhoneNumber= "6262626262" },
                new Person{FirstName= "Ayfer", LastName="Küçükaydıner", PhoneNumber= "7727272727" },
            };
        } 
        public static List<Person> PhoneList
        {
            get {return _phoneList; }
        }
    }

    
}
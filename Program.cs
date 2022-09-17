using System;
using phonebook.Actions;

namespace phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncellemek");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            string choice = Console.ReadLine();
    
            switch (choice)
            {
                case "1":
                    Add addPerson = new Add();
                    addPerson.Added();
                    break;
                case "2":
                    Delete deletePerson = new Delete();
                    deletePerson.Deleted();
                    break;
                case "3":
                    Update updatePerson = new Update();
                    updatePerson.Updated();
                    break;
                case "4":
                    Listed listedPersons = new Listed();
                    listedPersons.ListingPhoneBook();
                    break;
                case "5":
                    Search searchPerson = new Search();
                    searchPerson.Searched();
                    break;            

                                    

            }
        }
    }
}

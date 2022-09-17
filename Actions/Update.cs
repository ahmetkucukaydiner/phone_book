using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phonebook.Data;

namespace phonebook.Actions
{
    public class Update
    {
        public void Updated()
        {
            Person person = new Person();
            Listed listedPersons = new Listed();

            updateAction:
            while (true)
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string nameOrSurname = Console.ReadLine();

                if (PBData.PhoneList.Any(x => x.FirstName == nameOrSurname || x.LastName == nameOrSurname))
                {
                    person = PBData.PhoneList.Find(x=> x.FirstName == nameOrSurname || x.LastName == nameOrSurname);

                    Console.WriteLine("Yeni numarayı giriniz: ");

                    person.PhoneNumber = Console.ReadLine();

                    Console.WriteLine("Güncelleme başarılı.");

                    listedPersons.ListingPhoneBook();
                    break;
                }

                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. \n* Güncellemeyi sonlandırmak için : (1) \n* Yeniden denemek için :      (2)");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        break;
                    }
                    else if (choice == 2)
                    {
                        goto updateAction;
                    }

                }
            }
        }
    }
}
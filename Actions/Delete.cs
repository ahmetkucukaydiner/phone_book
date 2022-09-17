using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phonebook.Data;

namespace phonebook.Actions
{
    public class Delete
    {
        public void Deleted()
        {
            deletenumber:

            while (true)
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string nameSurname = Console.ReadLine();

                if (PBData.PhoneList.Any(x => x.FirstName == nameSurname || x.LastName == nameSurname))
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (Y/N)", nameSurname);
                    string y = Console.ReadLine().ToLower();

                    if (y == "y")
                    {
                        PBData.PhoneList.RemoveAt(PBData.PhoneList.FindIndex(x => x.FirstName == nameSurname || x.LastName == nameSurname));
                        Console.WriteLine("Silme işlemi başarılı.");
                        Listed listedPersons = new Listed();
                        listedPersons.ListingPhoneBook();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Silme işlemi iptal edildi.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. \n* Silmeyi sonlandırmak için : (1) \n* Yeniden demek için : (2)");
                    int n = int.Parse(Console.ReadLine());
                    if (n == 1)
                    {
                        break;
                    }
                    else if(n == 2)
                        goto deletenumber;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phonebook.Data;

namespace phonebook.Actions
{
    public class Search
    {
        public void Searched()
        {
            while (true)
            {
                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz. \n* ************************** \n*   \n* İsim veya soyisime göre aramak için: (1) \n* Telefon numarasına göre arama yapmak için : (2) ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Lütfen aramak istediğiniz isim veya soyismi giriniz: ");
                    string nameOrSurname = Console.ReadLine();

                    foreach (var item in PBData.PhoneList)
                    {
                        if (item.FirstName == nameOrSurname || item.LastName == nameOrSurname)
                        {
                            Console.WriteLine($"İsim : {item.FirstName}");
                            Console.WriteLine($"Soyisim : {item.LastName}");
                            Console.WriteLine($"Telefon numarası : {item.PhoneNumber}");
                            Console.WriteLine("-");
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                            break;
                        }
                    }                    
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Lütfen aramak istediğiniz telefon numarasını giriniz: ");
                    string number = Console.ReadLine(); 

                    foreach (var i in PBData.PhoneList)
                    {
                        if (i.PhoneNumber == number)
                        {
                            Console.WriteLine($"İsim : {i.FirstName}");
                            Console.WriteLine($"Soyisim : {i.LastName}");
                            Console.WriteLine($"Telefon numarası : {i.PhoneNumber}");
                            Console.WriteLine("-"); 
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                            break;
                        }
                    }
                     
                }
                break;
            }
        }
    }

}
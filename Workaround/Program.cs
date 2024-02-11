// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using System;
namespace Workaround
{
    class Program { 
    static void Main(string[] args)
    {
            SelamVer(isim:"ece");
            SelamVer(isim:"ornek");
            SelamVer(isim:"ornek2");
            SelamVer();
          

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "ilker";
            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara","İstanbul","İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "OZGE";
            person1.LastName = "UYGUN";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 123;

            

            foreach(string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add(item: "Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Hello, World!"+ isim);
        }

}
}


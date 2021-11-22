using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;

            Console.WriteLine("atm ye hoşgeldiniz abe");
            Console.WriteLine("yapmak istediğiniz işlemi seçiniz");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("toplam bakiyeniz= " + bakiye);
                Console.ReadLine();
            }

            else if (secim == "2")
            {


                Console.WriteLine("çekmek istediğiniz değeri giriniz");
                int cekilecek_bakiye = Convert.ToInt32(Console.ReadLine());

                if (cekilecek_bakiye < bakiye)
                {
                    Console.WriteLine("kalan tutuarınız= " + (bakiye - cekilecek_bakiye));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("yeterli bakiyen yok tekrar dene gardaşım");
                    Console.ReadLine();
                }





            }
            else if (secim == "3")
            {
                Console.WriteLine("yatırmak istediğiniz tutarı giriniz");

                int yatir = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("yeni tuturanız=" + (bakiye + yatir));
                Console.ReadLine();
            }

            else if (secim == "q")
            {
                Console.WriteLine("atm'den çıkış yapılıyor");
                Console.WriteLine("Allaha emenatsin");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("yanlış tuşlama yaptınız adam gibi tuşlayın");
                Console.ReadLine();
            }
        }
    }
}

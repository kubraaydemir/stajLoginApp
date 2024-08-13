using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace stajLoginApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* KULLANICI GİRİŞ SAYFASI ÖRNEĞİ
             KULLANICI ADI VE ŞİRFRE DOĞRU GİRİLİRSE HOŞGELDİNİZ SAYFASI YANLIŞ GİRİLİRSE HATA MESAJI TOPLAM 3 HAK VERELİM SONRA KİTLENSİN */
            int kalanGirisYapmaHakki = 3;
            while (true)
            {
                Console.WriteLine("Kullanıcı adınızı giriniz:");
                string kullaniciAdi = Console.ReadLine();
                Console.WriteLine("Şifrenizi giriniz:");
                string sifre= Console.ReadLine();

                if (kullaniciAdi == "stajyerGiris" && sifre == "2024stajyer")
                {
                    Console.WriteLine("Hoşgeldiniz.");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifre yanlış girildi");
                    if (kalanGirisYapmaHakki > 0)
                    {
                        kalanGirisYapmaHakki--;
                    }
                    if (kalanGirisYapmaHakki == 0)
                    {
                        Console.WriteLine("Giriş yapma hakkınız dolmuştur. Lütfen yetkiliyle görüşünüz.");
                        break;
                    }
                }
                
                
           } 
            Console.ReadLine();
               
        }
    }
}
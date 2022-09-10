using System;

namespace HataYönetimi
{
     class Program

    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Sayı giriniz;");
                int sayi = Console.ReadLine();
                Console.WriteLine("Girmiş olduğunuz sayı: "+ sayi);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Girmiş olduğunuz bir sayı değildir.");
                
            }
            finally
            {
                Console.WriteLine("İşlem sonlandırıldı.");
            }
            
            
        }
    }

}
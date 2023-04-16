using System;

namespace HataYöntemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi:" + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }

            //try
            //{
            //    int a = int.Parse(null);
            //}
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı");
            }
            catch (ArgumentNullException ex)
			{
				Console.WriteLine("Boş değer girdiniz"); Console.WriteLine(ex);
			}

        }
    }
}

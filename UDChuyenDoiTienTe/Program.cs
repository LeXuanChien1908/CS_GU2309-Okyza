using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDChuyenDoiTienTe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> exchangeRates = new Dictionary<string, double>
        {
            {"VND_to_USD", 0.000043},
            {"USD_to_VND", 23100}
        };

            Console.WriteLine("Chương trình chuyển đổi tiền tệ");
            Console.WriteLine("1. Chuyển từ VND sang USD");
            Console.WriteLine("2. Chuyển từ USD sang VND");
            Console.Write("Chọn tùy chọn (1 hoặc 2): ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                ConvertCurrency("VND_to_USD", exchangeRates);
            }
            else if (choice == 2)
            {
                ConvertCurrency("USD_to_VND", exchangeRates);
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
            }
        }

        static void ConvertCurrency(string conversionKey, Dictionary<string, double> exchangeRates)
        {
            Console.Write("Nhập số tiền: ");
            double amount = double.Parse(Console.ReadLine());

            if (exchangeRates.TryGetValue(conversionKey, out double rate))
            {
                double convertedAmount = amount * rate;
                Console.WriteLine($"Số tiền sau khi chuyển đổi: {convertedAmount}");
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
            }
    }
}

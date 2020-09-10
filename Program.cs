using System;
using System.Text;
namespace doitiente
{
    class Program
    {
        static void Main(string[] args)
        {
            int USD;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Đổi tiền sang VNĐ");
            Console.WriteLine("Nhập số tiền USD muốn chuyển:");
            USD = Convert.ToInt32(Console.ReadLine());
            a(USD);
        }
            static int a(int usd)
        {
            int tien = 23000 * usd;
            Console.WriteLine("USD = {0} VND", tien);
            return tien;
        }
        }
    }
}

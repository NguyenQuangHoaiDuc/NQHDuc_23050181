using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số (1->5) để gọi món: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Bò Bít Tết");
                    break;
                case 2:
                    Console.WriteLine("Thịt Bò Wagyu");
                    break;
                case 3:
                    Console.WriteLine("Cua Hoàng Đế Hấp Bia");
                    break;
                case 4:
                    Console.WriteLine("Tôm Hùm Hấp Bia");
                    break;
                case 5:
                    Console.WriteLine("Cơm chiên hải sản");
                    break;
                default:
                    Console.WriteLine("Dữ liệu nhập chưa đúng!");
                    break;
            }
            Console.WriteLine("Hello, World!");
        }
    }
}

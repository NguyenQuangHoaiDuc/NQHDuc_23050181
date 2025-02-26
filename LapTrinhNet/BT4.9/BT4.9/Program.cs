using System.Text;

namespace BT4._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập một tháng bất kì từ 1đến 12 để xem tháng đó thuộc mùa nào : ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Mùa Xuân");
                    break;
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("Mùa Hè");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Mùa Thu");
                    break;
                case 11:
                case 12:
                case 1:
                    Console.WriteLine("Mùa Đông");
                    break;
                default:
                    Console.WriteLine("Tháng nhập chưa đúng!");
                    break;
            }
            Console.WriteLine("Hello, World!");
        }
    }
}

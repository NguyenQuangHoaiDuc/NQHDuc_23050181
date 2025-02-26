using System.Text;

namespace BT4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string hotensinhvien1, hotensinhvien2;
            double diemtoansinhvien1, diemtoansinhvien2, diemlysinhvien1, diemlysinhvien2;

            Console.WriteLine("Nhập thông tin sinh viên thứ nhất: ");
            Console.Write("Họ và tên sinh viên thứ nhất: ");
            hotensinhvien1 = Console.ReadLine();
            Console.Write("Điểm môn Toán của sinh viên thứ nhất là: ");
            diemtoansinhvien1 = double.Parse(Console.ReadLine());
            Console.Write("Điểm môn Lý của sinh viên thứ nhất là: ");
            diemlysinhvien1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhập thông tin sinh viên thứ hai: ");
            Console.Write("Họ và tên sinh viên thứ hai: ");
            hotensinhvien2 = Console.ReadLine();
            Console.Write("Điểm môn Toán của sinh viên thứ hai là: ");
            diemtoansinhvien2 = double.Parse(Console.ReadLine());
            Console.Write("Điểm môn Lý của sinh viên thứ hai là: ");
            diemlysinhvien2 = double.Parse(Console.ReadLine());

            if (diemtoansinhvien1 > diemtoansinhvien2)
            {
                Console.WriteLine($"Sinh viên được chọn là: {hotensinhvien1}");
            }
            else if (diemtoansinhvien1 < diemtoansinhvien2)
            {
                Console.WriteLine($"Sinh viên được chọn là {hotensinhvien2}");
            }
            else
            {
                if (diemlysinhvien1 > diemlysinhvien2)
                {
                    Console.WriteLine($"Sinh viên được chọn là: {hotensinhvien1}");
                }
                else if (diemlysinhvien1 < diemlysinhvien2)
                {
                    Console.WriteLine($"Sinh viên được chọn là: {hotensinhvien2}");
                }
                else
                {
                    Console.WriteLine($"Sinh viên được chọn là: {hotensinhvien1}");
                }
            }
            Console.ReadKey();
            Console.WriteLine("Hello, World!");
        }
    }
}

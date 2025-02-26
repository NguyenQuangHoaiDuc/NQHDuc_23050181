namespace BT4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập hệ số a, b, c
            double a, b, c;
            while (true)
            {
                Console.Write("Nhập hệ số a (a ≠ 0): ");
                if (double.TryParse(Console.ReadLine(), out a) && a != 0)
                {
                    break;
                }
                Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
            }

            Console.Write("Nhập hệ số b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
            }

            Console.Write("Nhập hệ số c: ");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
            }

            // Tính delta
            double delta = b * b - 4 * a * c;
            Console.WriteLine($"\nDelta = {delta}");

            // Xử lý nghiệm
            if (delta > 0)
            {
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phương trình có nghiệm kép:");
                double x = -b / (2 * a);
                Console.WriteLine($"x1 = x2 = {x}");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }

            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc.");
            Console.ReadKey();
            Console.WriteLine("Hello, World!");
        }
    }
}

using System.Text;

namespace BT4._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhập họ tên hộ sử dụng điện: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nhập chỉ số điện tháng trước của hộ sử dụng điện (KWh): ");
            double chiSoCu = double.Parse(Console.ReadLine());

            Console.Write("Nhập chỉ số điện tháng này của hộ sử dụng điện (KWh): ");
            double chiSoMoi = double.Parse(Console.ReadLine());

            double dienTieuThu = chiSoMoi - chiSoCu;

            double tienDien = 0;
            if (dienTieuThu <= 60)
            {
                tienDien = dienTieuThu * 1000;
            }
            else if (dienTieuThu <= 160)
            {
                tienDien = 60 * 1000 + (dienTieuThu - 60) * 1500;
            }
            else
            {
                tienDien = 60 * 1000 + 100 * 1500 + (dienTieuThu - 160) * 2000;
            }

            Console.WriteLine("\nHọ tên hộ sử dụng điện: " + hoTen);
            Console.WriteLine("Chỉ số điện tháng trước của hộ sử dụng điện: " + chiSoCu + " KWh");
            Console.WriteLine("Chỉ số điện tháng này của hộ sử dụng điện: " + chiSoMoi + " KWh");
            Console.WriteLine("Lượng điện tiêu thụ của hộ sử dụng điện: " + dienTieuThu + " KWh");
            Console.WriteLine("Số tiền điện phải trả của hộ sử dụng điện: " + string.Format("{0:N0}", tienDien) + " đồng");
            Console.WriteLine("Hello, World!");
        }
    }
}

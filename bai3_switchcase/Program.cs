namespace bai3_switchcase
{
    /*
     *Switch-case:Là 1 loại câu lệnh điều kiện nhưng điều kiện sẽ theo
     *các giá trị cụ thể
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.Unicode;
            Console.InputEncoding=System.Text.Encoding.Unicode;
            //Console.WriteLine("Nhập số tuổi người yêu :");
            //int age = Convert.ToInt32(Console.ReadLine());
            //switch (age)
            //{
            //    case 15:
            //        Console.WriteLine("Opps! police are watching you");
            //        break;// Lệnh dùng để dừng 1 cấu trúc
            //    case 20:
            //        Console.WriteLine("Happy, everybody cheer with you");
            //        break;
            //    case 60:
            //        Console.WriteLine("congratulation! You're rich!!!");
            //        break;
            //    default:
            //        Console.WriteLine("No body will");
            //        break;
            //}
            ////Toán tử 3 ngôi
            ////Điều kiện? Lệnh nếu Đk đúng: Lệnh nếu điều kiện sai;
            //Console.WriteLine(age < 16 ? ("Illegal") : ("You're legal!"));

            //Nhập 3 số, hãy tìm ra số lớn thứ 2 trong 3 số đó
            //Thử tìm 2 số lớn nhất && bé nhất
            // a+b+c-max-min
            Console.WriteLine("Nhập số thứ a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số thứ b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số thứ c:");
            int c = Convert.ToInt32(Console.ReadLine());
            int max, min;
            //Tìm max
            if (a >= b && a >= c) max = a;
            else if (b >= c) max = b;
            else max = c;
            Console.WriteLine($"Số lớn thứ 1 là {max}");
            //Tìm min
            if (a <= b && a <= c) min = a;
            else if (b <= c) min = b;
            else min = c;
            //Tìm số lớn thứ 2 
            Console.WriteLine($"Số lớn thứ 2 là {a + b + c - max - min}");

            //Cách 2 thuần so sánh
            if(a >= b && a<=c || a >=c && a<= b)
            {
                Console.WriteLine($"{a} là số lớn thứ 2");
            }else if (b >=c && b<=a || b>=a && b<=c)
            {
                Console.WriteLine($"{b} là số lớn thứ 2");
            }else
            Console.WriteLine($"{c} là số lớn thứ 2");

            //3 Ngôi 
            Console.WriteLine("Số lớn thứ 2 nà: " +
                (a >= b && a <= c || a >= c && a <= b ? a : b >= c && b <= a || b >= a && b <= c ? b : c));

            // Số thứ 2 trừ đi số thứ nhất <=0 và trừ đi số nhỏ nhất >= 0
            // Số lớn nhất trừ đi 2 số còn lại >=0
            // Số nhỏ nhất trừ đi 2 số còn lại <= 0
            Console.WriteLine("Số lớn thứ 2 là" +
                ((a - b) * (a - c) <= 0 ? a : (b - a) * (b - c) <= 0 ? b : c));

            if ((a - b) * (a - c) <= 0) Console.WriteLine($"{a}lớn thứ 2 ");
            else if ((b - c) * (b - a) <= 0) Console.WriteLine($"{b}lớn thứ 2");
            else Console.WriteLine($"{c} lớn thứ 2");
        }
    }
}

namespace Bai_2_Phan_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Chọn số tương ứng \n1 - Bao\n2 - Búa\n3 - Kéo");
            int a = int.Parse(Console.ReadLine());
            int c;
            Random b = new Random();
            c = b.Next(1, 3);
            Console.WriteLine(c);
            if (c == 1 && a == 1 || c == 2 && a == 2 || c == 3 && a == 3)
            {
                Console.WriteLine("Bạn chọn :{0}\nMáy chọn: {1}\nKết quả: Hòa", a, c);
            }
            else if (c == 1 && a == 2 || c == 2 && a == 3 || c == 3 && a == 1)
            {
                Console.WriteLine("Bạn chọn :{0}\nMáy chọn: {1}\nKết quả: Máy thắng", a, c);
            }
            else if (c==1 && a==3 || c==2 && a==1 || c==3 && a==2)
                { Console.WriteLine("Bạn chọn :{0}\nMáy chọn: {1}\nKết quả: Bạn thắng", a, c); }
            else { Console.WriteLine("Bạn đã nhập sai!!! Vui lòng thử lại"); }
        }
    }
}
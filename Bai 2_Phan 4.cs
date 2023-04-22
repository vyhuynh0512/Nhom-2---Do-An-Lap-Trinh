using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập vào số dòng của Ma Trận: ");
        int m = int.Parse(Console.ReadLine());
        // Nhập số dòng mà bạn muốn

        Console.Write("NNhập vào số cột của Ma Trận: ");
        int n = int.Parse(Console.ReadLine());
        // Nhập vào số cột mà bạn muốn

        int[,] matrix = new int[m, n];
        // Khởi tạo ma trận với kích thước m x n

        Console.WriteLine("\nNhập vào các phần tử của ma trận:");
        // Nhập vào số tương ứng cho dòng m, cột n
        // ở đây ta khai báo 2 dòng lặp nhằm mục đích khai bái giá trị cho từng phần tử nằm ở ô tương ứng
        // Ví dụ: Ta có Ma Trận 2 * 2 thì sẽ có a [0,0] " hàng 1 và cột 1...


        // Khởi tạo giá trị của các phần tử trong ma trận
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("a[{0},{1}] = ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // In ra giá trị của ma trận
        Console.WriteLine("\n<<< MATRIX mà bạn vừa nhập là >>>");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        bool KiemTra = true;
        // dùng bool để kiểm tra xem ma trận có phải đối xứng hay không

        // Điều kiện để matrix là matrix đối xứng là
        // Ma trận đối xứng : là ma trận vuông, trong đó hai phần tử đối xứng qua đường chéo chính thì
        // bằng nhau, nghĩa là a [i, j] = a [i, j] với mọi i, j = 1, 2, …, n.

        for (int i = 0; i < m; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (matrix[i, j] != matrix[j, i])
                {
                    KiemTra = false;
                    break;
                }
            }
            if (!KiemTra)

            {
                break;
                // Nếu ngược lại thì dừng chương trình luôn
            }
        }

        if (KiemTra)
        // Ta kiểm tra ma trận nếu đúng thì trả kết quả Ma Trận trên là ma trận đối xứng qua trục giữa
        // Còn ngược lại thì sẽ in ra dòng ma trận trên là ma trận không đối xứng qua trục giữa
        {
            Console.WriteLine("\n--- Kết quả kiểm tra cho ta thấy ---");
            Console.WriteLine("\n => MATRIX trên là MATRIX đối xứng qua trục giữa. ");
        }
        else
        {
            Console.WriteLine("\n--- Kết quả kiểm tra cho ta thấy ---");
            Console.WriteLine("\n => MATRIX trên không là MATRIX đối xứng qua trục giữa. ");
        }

        Console.ReadLine();
    }
}




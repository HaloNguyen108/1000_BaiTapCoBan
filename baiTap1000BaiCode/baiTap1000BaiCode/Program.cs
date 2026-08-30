using System.Text;

namespace baiTap1000BaiCode
{
    internal class Program
    {
        #region TinhTongSieuNhanh
        //static double TinhTongSieuNhanh(double x, int n)
        //{
        //    if (x == 1) return n; // Trường hợp đặc biệt: 1 + 1^2 + 1^3... = n
        //    return x * (Math.Pow(x, n) - 1) / (x - 1);
        //}
        #endregion
        #region tinhGiaiThua
        static double TinhGiaiThua(double n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * TinhGiaiThua(n - 1);
        }
        #endregion
        #region thanDeQuy
        //static double Dequy(double x,double n)
        //{
        //    #region dieuKienDung
        //    //if (n == 0)
        //    //{
        //    //    //return 1;        // cho các bài trả về 1
        //    //    //return 1.0/2.0;  // cho các bài trả về các số phần
        //    //    //return 0;          // Lưu ý có 1 số bài điều kiện dừng n == 0 vd: bài 8; Khi đó ta cần tính toán biểu thức cuối để trả về được điều kiện dừng.
        //    //    //return x;
        //    //}
        //    #endregion
        //    #region  deQuy
        //    //return n + Dequy(n - 1);  //bai1
        //    //return Math.Pow(n, 2) + Dequy(n - 1);
        //    //return 1 / n + Dequy(n - 1);
        //    //return 1 / (2.0 * n) + Dequy(n - 1)  ;
        //    //return 1 / (2 * n + 1) + Dequy(n - 1);
        //    //return 1.0 / (n * (n + 1.0)) + Dequy(n - 1);
        //    //return n / (n + 1.0) + Dequy(n - 1);
        //    //return (2.0 * n + 1.0) / (2.0 * n + 2.0) + Dequy(n - 1);  //bài 8
        //    //return n * Dequy(n - 1);
        //    //return TinhGiaiThua(n) + Dequy(n - 1);
        //    //return Math.Pow(x,n) + Dequy(x,n-1);
        //    //return Math.Pow(x, (2.0 * n)) + Dequy(x, n - 1.0);
        //    //return Math.Pow(x, 2.0 * n + 1.0) + Dequy(x, n - 1);
        //    //return (2.0 / (n * (n + 1.0))) + Dequy(n - 1);
        //    //return Math.Pow(x, n)/ ((n * (n + 1.0))/2.0) + Dequy(x, n - 1);  //bài 16
        //    //return (( Math.Pow(x, n)) / TinhGiaiThua(n)) + Dequy(x, n - 1);
        //    //return ((Math.Pow(x, (2 * n))) / TinhGiaiThua(2 * n) + Dequy(x, n - 1);
        //    //return ((Math.Pow(x, (2 * n + 1)))) / TinhGiaiThua(2 * n + 1) + Dequy(x, n - 1);
        //    #endregion
        //}
        #endregion
        static void Main(string[] args)
        {
            Console.Clear();
            Console.InputEncoding = Encoding.UTF8; Console.OutputEncoding = Encoding.UTF8;
            #region DeQuy
            //Console.Write("Nhập vào n: ");
            //double n = double.Parse(Console.ReadLine());
            //Console.Write("Nhập vào x: ");
            //double x = double.Parse(Console.ReadLine());
            //double sum = Dequy(x,n);
            //Console.WriteLine($"Kết quả là: {sum}");
            #endregion
            #region Bai1
            //Console.Write("Nhập vào n: ");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i <= n; i++)
            //{
            //    sum += i;

            //}
            //Console.WriteLine($"Kết quả là: {sum}");
            #endregion
            #region Bai2
            //Console.Write("Nhập vào n: ");
            //int n = int.Parse(Console.ReadLine());
            //double sum = 0;
            //for (double i = 0; i <= n; i++)
            //{
            //    double a = 0;
            //    a = Math.Pow(i, 2);
            //    sum += a;
            //}
            //Console.WriteLine($"Kết quả là: {sum}");
            #endregion
            #region Bai3
            //Bài 3: Tính S(n) = 1 + ½ + 1/3 + ... + 1/n
            //Console.Write("Nhập vào n: ");
            //double n = double.Parse(Console.ReadLine());
            //double sum = 0;
            //for (double i = 1; i <= n; i++)
            //{
            //    double a = 0;
            //    a = 1 / i;
            //    sum += a;
            //}
            //Console.WriteLine($"Kết quả là: {sum}");
            #endregion
            #region Bai4
            //Bài 4: Tính S(n) = ½ + ¼ +... +1 / 2n
            //Console.Write("Nhập vào n: ");
            //double n = double.Parse(Console.ReadLine());
            //double sum = 0;
            //for (double i = 1; i <= n; i++)
            //{
            //    double a = 0;
            //    a = 1 / (2*i);
            //    sum += a;
            //}
            //Console.WriteLine($"Kết quả là: {sum}");
            #endregion
            #region Bai5
            //Bài 5: Tính S(n) = 1 + 1/3 + 1/5 + ... + 1/(2n + 1)
            //Console.Write("Nhập vào n: ");
            //double n = double.Parse(Console.ReadLine());
            //double sum = 0;
            //for (double i = 1; i <= n; i++)
            //{
            //    double a = 0;
            //    a = 1 / ((2*i) + 1);
            //    sum += a;
            //}
            //Console.WriteLine($"Kết quả là: {sum}");
            #endregion
            #region Bai6
            //Bài 6: Tính S(n) = 1 / 1x2 + 1 / 2x3 + ...+1 / n x(n + 1)
            //Console.Write("Nhập vào n: ");
            //double n = double.Parse(Console.ReadLine());
            //double sum = 0;
            //for (double i = 1; i <= n; i++)
            //{
            //    double a = 0;
            //    a = 1 / (i * (i + 1));
            //    sum += a;
            //}
            //Console.WriteLine($"Kết quả là: {sum}");
            #endregion
            #region Bai10
            //Console.Write("Nhập vào số x: ");
            //double x = Double.Parse(Console.ReadLine());
            //Console.Write("Nhập vào số n: ");
            //double n = Double.Parse(Console.ReadLine());
            //double pow = 0;
            //pow = Math.Pow(x, n);
            //Console.Write($"Kết quả là: {pow}");
            #endregion
            #region Bai11
            //Bài 11: Tính S(n) = 1 + 1.2 + 1.2.3 + ... +1.2.3....N
            #endregion
            #region Bai13

            #endregion
            #region Bai14
            #endregion
            #region Bai15
            #endregion
            #region Bai17
            //Bài 17: Tính S(n) = x + x ^ 2 / 2! + x ^ 3 / 3! + ... +x ^ n / N!
            #endregion
            #region Bai18
            //Bài 18: Tính S(n) = 1 + x^2/2! + x^4/4! + ... + x^2n/(2n)!
            #endregion
            #region Bai 20
            Console.Write("Nhập vào n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Kết quả là: ");
            int sum = 0;
            int nhan = 1;
            int count = 0;
            int chan = 0;
            int sumChan = 0;
            int tichLe = 1;
            int luongChan = 0;
            int sumNho = 0;
            int sumHoanThien = 0;
            for (int i = 1; i <= n; i++)     // Console.Write("Kết quả là: ");
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");
                    sum += i;               // Console.WriteLine($"Tổng:{sum} ");
                    nhan *= i;              // Console.WriteLine($"Tích:{nhan} ");
                    count++;
                    
                }
            }
            Console.WriteLine($"");
            Console.Write($"số lẻ là: ");
            for (int i = 1; i <= n; i++)    // Console.Write($"số lẻ là: ");
            {
                if ( n % i == 0 && i % 2 == 1)
                {
                    Console.Write($"{i} ");
                }
            }
            for (int i = 1; i <= n; i++)    // Console.WriteLine($"Tổng Chẵn:{sumChan} ");
            {
                if (n % i == 0 && i % 2 == 0)
                {
                    sumChan += i;
                }
            }
            for (int i = 1; i <= n; i++)    // Console.WriteLine($"Tích lẻ:{tichLe} ");
            {
                if (n % i == 0 && i % 2 == 1)
                {
                    tichLe *= i;
                }
            }
            for (int i = 1; i <= n; i++)    // Console.WriteLine($"Lượng chẳn:{luongChan} ");
            {
                if (n % i == 0 && i % 2 == 0)
                {
                    luongChan ++;
                }
            }
            for (int i = 1; i < n; i++)     // Console.WriteLine($"Tổng:{sumNho} ");
            {
                if (n % i == 0)
                {
                    sumNho += i;               
                }
            }

            int max = 0;                    //
            for (int i = n; i >= 1; i--)    
            {
                if (n % i == 0 && i % 2 == 1)
                {
                max = i;
                    break; 
                }
            }
            Console.WriteLine();
            for (int i = 1; i < n; i++)     //30
            {
                if (n % i == 0)
                {
                    sumHoanThien += i;
                }
            }
            if (sumHoanThien == n)
            {
                Console.WriteLine($"{n} là Số hoàn thiện");
            }
            else
            {
                Console.WriteLine($"{n} không là Số hoàn thiện");
            }                               
            //

            bool SNT = true;                //31
            for (int i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    SNT = false;
                }       
            }
            if (SNT == true)
                Console.WriteLine($"{n} là Số nguyên tố");
            else
                Console.WriteLine($"{n} không là Số nguyên tố");
            //
            
            double SCP = 0;                    //32
            SCP = Math.Sqrt(n);
            if (SCP % 1 == 0)
                Console.WriteLine($"{n} là Số chính phương");
            else
                Console.WriteLine($"{n} không là Số chính phương");
            //

            double Canbai1 = 0;                    //33
            double Canbai2 = 0;
            double Canbai3 = 0;
            double Canbai4 = 0;
            double Canbai5 = 0;
            for (int i = 1; i <= n; i++)
            {
                Canbai1 = Math.Sqrt(2 +  Canbai1);
            }
            Console.WriteLine($"Kết quả căn bậc hai n lần là: {Canbai1}");

            for (int i = 1; i <= n; i++)          //34
            {
                Canbai2 = Math.Sqrt(i + Canbai2);
            }
            Console.WriteLine($"Kết quả căn bậc hai n lần là: {Canbai2}");

            for (int i = 1; i <= n; i++)          //36
            {
                Canbai3 = Math.Sqrt(TinhGiaiThua(i) + Canbai3);
            }
            Console.WriteLine($"Kết quả là: {Canbai3}");

            for (int i = 1; i <= n; i++)          //37
            {
                Canbai4 = Math.Pow(Canbai4 + i , 1.0/i);
            }
            Console.WriteLine($"Kết quả là: {Canbai4}");

            for (int i = 1; i <= n; i++)          //37
            {
                Canbai5 = Math.Pow(Canbai5 + i, 1.0 / (i + 1.0));
            }
            Console.WriteLine($"Kết quả là: {Canbai5}");





            Console.WriteLine($"Tổng:{sum} ");
            Console.WriteLine($"Tích:{nhan} ");
            Console.WriteLine($"Số lượng:{count}");
            Console.WriteLine($"Tổng Chẵn:{sumChan} ");
            Console.WriteLine($"Tích lẻ:{tichLe} ");
            Console.WriteLine($"Lượng chẳn:{luongChan} ");      //27
            Console.WriteLine($"Tổng nhỏ hơn n:{sumNho} ");     //28
            Console.WriteLine($"Số lẻ lơn nhất:{max} ");        //29







            #endregion

            Console.ReadKey();
        }
    }
}
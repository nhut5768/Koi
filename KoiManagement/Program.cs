using System;

namespace KoiManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RunKoiManagement();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        static void RunKoiManagement()
        {
            while (true)
            {
                Console.WriteLine("Hệ Thống Quản Lý Cá Koi");
                Console.WriteLine("1. Thêm Cá Koi");
                Console.WriteLine("2. Hiển Thị Tất Cả Cá Koi");
                Console.WriteLine("3. Thoát");
                Console.Write("Chọn một tùy chọn: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Vui lòng nhập một số hợp lệ.");
                    continue;
                }

                if (choice == 1)
                {
                    AddKoi();
                }
                else if (choice == 2)
                {
                    DisplayKoi();
                }
                else if (choice == 3)
                {
                    break;
                }
            }
        }

        static void AddKoi()
        {
            try
            {
                string name = GetInput("Nhập Tên Cá Koi: ");
                string variety = GetInput("Nhập Giống Cá Koi: ");
                int age = GetIntInput("Nhập Tuổi Cá Koi (năm): ");
                double size = GetDoubleInput("Nhập Kích Thước Cá Koi (cm): ");
                double weight = GetDoubleInput("Nhập Trọng Lượng Cá Koi (kg): ");

                // Thêm logic để lưu cá Koi vào danh sách hoặc cơ sở dữ liệu
                Console.WriteLine("Cá Koi đã được thêm thành công!\n");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        static void DisplayKoi()
        {
            // Thêm logic để hiển thị danh sách cá Koi
            Console.WriteLine("Danh Sách Cá Koi:");
            // Giả sử có danh sách Koi để hiển thị
        }

        static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine(); // Sử dụng nullable để kiểm tra null

            return input ?? throw new ArgumentNullException("Giá trị không thể để trống."); // Kiểm tra null
        }

        static int GetIntInput(string prompt)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            throw new ArgumentException("Vui lòng nhập một số hợp lệ.");
        }

        static double GetDoubleInput(string prompt)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                return result;
            }
            throw new ArgumentException("Vui lòng nhập một số hợp lệ.");
        }
    }
}
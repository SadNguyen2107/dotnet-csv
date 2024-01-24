using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "numbers.csv";

        try
        {
            // Đọc nội dung từ file CSV
            string[] lines = File.ReadAllLines(filePath);

            // Hiển thị danh sách các quốc gia
            foreach (string line in lines)
            {
                // Tách thông tin trong mỗi dòng bằng phương thức Split()
                string[] columns = line.Split(',');

                // In ra thông tin quốc gia
                Console.WriteLine($"Quoc gia: {columns[5]}, Ma quoc gia: {columns[4]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Đa xay ra loi: {ex.Message}");
        }
    }
}

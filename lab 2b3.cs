using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tạo danh sách điểm
        List<float> ldata = new List<float>() { 10, 9, 8, 7.5f, 2, 1.4f };

        // Khởi tạo đối tượng userData
        userData student = new userData("2024001", "Nguyen Van A");

        // Nhập điểm từ ldata sang student.Scores
        student.Scores.AddRange(ldata);

        // Hiển thị thông tin của sinh viên
        Console.WriteLine($"ID: {student.ID}");
        Console.WriteLine($"UserName: {student.UserName}");
        Console.WriteLine("Scores: " + string.Join(", ", student.Scores));
    }
}

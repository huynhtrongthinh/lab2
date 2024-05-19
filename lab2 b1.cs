using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_b1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class UserData
    {
        public int id;
        public int level;
        public string name;
        public UserData() 
        {
            id = 0;
            level = 0;
            name = "null";
        }
        public UserData(int id, int level, string name)
        {
            this.id = id;
            this.level = level;
            this.name = name;
        }
        public void XuatThongTin()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Name: " + name);
        }
    }
    public class Bai1c
    {
        public static void XuatThongTin(String attributeName, dynamic attribute)
        {
            Console.WriteLine(attributeName + ": " + attribute);
        }
    }
  
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Learning
{
    class Diem
    {
        public int X;
        public int Y;

        public void NhapDiem(string ghichu)
        {
            Console.Write("Nhap toa do X " + ghichu + ": ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do Y " + ghichu + ": ");
            Y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Toa do {ghichu}: ({this.X}, {this.Y})");
        }
    }
}

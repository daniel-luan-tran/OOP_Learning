using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Learning
{
    class TamGiac
    {
        public Diem A;
        public Diem B;
        public Diem C;

        public void NhapTamGiac()
        {
            Diem A, B, C;
            A = new Diem();
            B = new Diem();
            C = new Diem();

            Console.WriteLine("Nhap diem A:");
            A.NhapDiem("Diem A");
            Console.WriteLine("Nhap diem B:");
            B.NhapDiem("Diem B");
            Console.WriteLine("Nhap diem C:");
            C.NhapDiem("Diem C");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diem A, B;
            //A = new Diem();
            //A.NhapDiem("Diem A");
            //B = new Diem();
            //B.NhapDiem("Diem B");

            TamGiac t;
            t = new TamGiac();
            t.NhapTamGiac();

            Console.ReadKey();
        }
    }
}

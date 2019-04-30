using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    public class Trangle
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;
        public Trangle(double  a,double b,double  c)
        {
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }
        public Boolean IsTrangle
        {
            get
            {
                if (this.sideA + this.sideB > this.sideC && this.sideA + this.sideC > this.sideB && this.sideB + this.sideC > this.sideA)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public double Circumference
        {
            get
            {
                if (IsTrangle)
                {
                    return this.sideA + this.sideB + this.sideC;
                }
                else
                    return -1;
            }
        }
        public double Area
        {
            get
            {
                if (IsTrangle)
                {
                    return System.Math.Sqrt(Circumference/2 * (Circumference/2 - this.sideA) * (Circumference/2 - this.sideB) * (Circumference/2 - this.sideC));
                }
                else
                {
                    return -1;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("输入三角形第一条边");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("输入三角形第一条边");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("输入三角形第一条边");
            c = double.Parse(Console.ReadLine());
            Trangle p = new Trangle(a,b,c);
            if (p.IsTrangle)
            {
                Console.WriteLine("是一个面积为：" + p.Area + "周长为：" + p.Circumference + "的三角形");
            }
            else
            {
                Console.WriteLine("不是三角形");
            }
            Console.Read();
        }
    }
}

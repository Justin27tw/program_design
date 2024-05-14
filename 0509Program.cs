using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CShape
    {
       

        public double area()
        {

            return 0.0;
        }
       
    }
    class CCircle : CShape//圓形
    {
        double radius;
        double pi = 3.14;
        public CCircle(double r)
        {
            radius = r;
        }
        public new  double area()
        {
            return (radius * radius * pi);

            
        }
        public double Largest(double one ,double two)
        { if (one > two)
                return one;
            else
                return two;
        }
    }
    class CSquare : CShape//正方形
    {
        int length;
        public CSquare(int l)
        {
            length = l;
        }
        public new double area()
        {

            return (length * length);
        }
        public double Largest(double one, double two)
        {
            if (one > two)
                return one;
            else
                return two;
        }
    }
    class CTriangle : CShape//三角形
    {
        int lowwrlth;
        int height;
        public CTriangle(int l, int h)
        {
            lowwrlth = l;
            height = h;
        }
        public new double area()
        {
            return (lowwrlth * height) / 2;
        }

        public double Largest(double one, double two)
        {
            if (one > two)
                return one;
            else
                return two;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CCircle Cir1, Cir2;
            Cir1 = new CCircle(3.0);
            Cir2 = new CCircle(9.0);
            CSquare Csq1, Csq2;
            Csq1 = new CSquare(5);
            Csq2 = new CSquare(16);
            CTriangle Ct1, Ct2;
            Ct1 = new CTriangle(6, 16);
            Ct2 = new CTriangle(9,18);
             double CirL=Cir1.Largest(Cir1.area(), Cir2.area());
            double CSqL = Csq1.Largest(Csq1.area(), Csq2.area());
            double CTL = Ct1.Largest(Ct1.area(), Ct2.area());
            double MaxArea;
            if (CirL > CSqL)
                if (CirL > CTL)
                    MaxArea = CirL;
                else
                    MaxArea = CTL;
            else
                if (CSqL > CTL)
                MaxArea = CSqL;
                else
                    MaxArea = CTL;

            if (MaxArea == CirL)
                Console.WriteLine("最大面積在圓形"+MaxArea);
            else
                    if (MaxArea == CSqL)
                    Console.WriteLine("最大面積在正方形" + MaxArea);
                    else
                    Console.WriteLine("最大面積在三角形" + MaxArea);



            Console.Read();
        }

    }
}

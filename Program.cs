using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0314
{//1. 1.定義一個梯形CTrapezoid類別
 //2.在類別內請備妥所需設定初值的建構元兩個，
 //其一為能給定預設梯形(上底為1下底為2高為2)的建構元，但初值設定請使用呼叫另一建構元的方式執行
 //3.產生兩個梯形，一個是使用預設梯形，一個是給定梯形的上底為4下底為8高為3  ，並分別輸出兩個梯形面積
    class CTrapezpid
    {
        int upline;
        int dnline;
        int height;
        
        

      
        public CTrapezpid():this(1,2,2)
        {
          
        }
        public CTrapezpid(int u ,int d, int h)
        {
            upline = u;
            dnline = d;
            height = h;
        }
        public int area() 
        {return (upline + dnline) * height / 2; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CTrapezpid z1, z2;
            z1 = new CTrapezpid();
            z2 = new CTrapezpid(4, 8, 3);


            
                Console.WriteLine("第1個梯形面積為" + z1.area());
                Console.WriteLine("第2個梯形面積為"+z2.area());
            
            Console.Read();
            


        }
    }
}

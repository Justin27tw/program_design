using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1.介面Math，裡面定義add()+, sub()-,mul()x.div()/四個抽象方法
2.增加一個AdvanceMath介面，這介面定義了3個方法 分別是
取餘數  mod(int a ,int b) 
階層 fac(int a)
和次方pow(int a, int b)
3.再宣告一個介面show_ans   主要去定義一個抽象方法 show()；使得介面Math去繼承這個介面
4.Compute類別透過實作Math與AdvanceMath來處理兩個整數的四則運算以及餘數等運算能力
 */
namespace _0530hw
{   
    interface IShow_ans
    {
        
        void Show();
    }
    interface IMath:IShow_ans
    {
        
        int add(int x,int y);//+
        int sub(int x,int y);//-
        int mul(int x,int y);//乘
        double div(int x,int y);//除        
    }
    interface IAdvanceMath
    {
        int mod(int x, int y);//餘數
        int fac(int x);//n!階層 ex: n=5 5*4*3*2*1
        double pow(int x, int y);//次方
        
    }
    class Compute : IMath, IAdvanceMath
    {
        int add_1;
        int sub_1;
        int mul_1;
        double div_1;
        int mod_1;
        int pow_1;
        int total;
        public int add(int x, int y)
            {
                add_1 = x + y;
                return add_1;
            }
            public int sub(int x, int y)
            {
                sub_1 = x - y;
                return sub_1; 
            }
            public int mul(int x, int y)
            {
                mul_1 = x*y;
                return mul_1;
            }
            public double div(int x, int y)//除
            {
                div_1 = x / y;
                return div_1;
            }
            public int mod(int x, int y)//餘數
            {   
                mod_1 = x%y;
                return mod_1; 
            }
        /*   public int fac(int x)//ex :x=5 //階層
            { 
                total = x;  
                for (int i = 1; i < x; i++)
                { total *= i; }
                return total;
            }
        */
            public int fac(int x) //遞減
            {
                if (x == 1)
                    { 
                        return 1; 
                    }
                else
                    { 
                        return total+=x * fac(x - 1);//呼叫在呼叫 
                    }
            }
            public double pow(int x, int y)//和次方
            {
                pow_1 = x;
                for (int i = 1; i < y; i++)
                {
                    pow_1 *= x;
                }
                return pow_1;
            }
        public void  Show()
        { Console.WriteLine("加法="+add_1+"\n"+"減法="+sub_1+"\n"+"乘法="+mul_1+"\n"+"除法="+div_1+"\n"+"餘數="+mod_1+"\n"+"階層="+total+"\n"+"次方="+pow_1+"\n"); }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        { Compute cp1 = new Compute();

            Console.Write("請輸入第1個數字");
            int first_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入第2個數字");
            int second_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入運算方法!");
            char count_way = Convert.ToChar(Console.ReadLine());
            switch (count_way)//char 
            {
                case '+':
                { int add_result = cp1.add(first_num, second_num);
                        break;
                    }
                case '-':
                    {
                        int sub_result = cp1.sub(first_num, second_num);
                        break;
                    }
                case '*':
                    {
                        int mul_result = cp1.mul(first_num, second_num);
                        break;
                    }
                case '/':
                    {
                        double div_result = cp1.div(first_num, second_num);
                        break;
                    }
                case '%':
                    {
                        int mod_result = cp1.mod(first_num, second_num);
                        break;
                    }
                case '!':
                    {
                        int fac_result = cp1.fac(first_num);
                        break;
                    }
                case '^':
                    {
                        double pow_result = cp1.pow(first_num, second_num);
                        break;
                    }
                case '=':
                    {
                        cp1.Show();
                        break;
                    }
            }
            Console.Read();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
/*
1. 定義一個梯形CTrapezoid類別
2.在類別內請備妥所需所有需要的建構元，初值設定請使用呼叫另一建構元的方式執行
3.產生5個梯形，這是目前產生第幾個梯形物件，並且將之以陣列形態存放。
4.請完成比較這一陣列中哪一個梯形物件面積最大，那一個 梯形物件面積最小(請以同一個方法完成)
5.在主程式輸出哪一個物件是最大與最小*/
namespace _0328
{
    class CTrapezoid
    {
        double upline;
        double dnline;
        double height;
        int cc=0;
        static int count = 0;
        int max_count;
        int min_count;
        int maxcount_index = 0;
        int mincount_index = 0;
        static double[] max_vs = new double[4]; //4
            static double[] min_vs = new double[4]; //4

        public CTrapezoid(double u, double d, double h, int cal)
        {
            for (int i = 0; i < cal; i++)
            {
                upline = u;
                dnline = d;
                height = h;

            }
            count++;
        }

        public static void show()
        {
            Console.WriteLine("第" + count + "個梯形");
        }
        public double Area()
        { return (upline + dnline) * height / 2; }
        
        public (double vs_max,double vs_min) Compare(double vs,double vs_2,int  forloop_index,int total_index)
        {
            


            //[0123]
            if (vs>vs_2)//0-1,1-2,2-3,3-4
            { max_vs[forloop_index]=vs;
                min_vs[forloop_index]=vs_2;}
            else
            {
                max_vs[forloop_index] = vs_2;
                min_vs[forloop_index] = vs;
            }
            double vs_min = min_vs[0];
            double vs_max = max_vs[0];
            if (forloop_index==total_index-2)//3
            {
                
                for (int j=0;j<max_vs.Length;j++)//0123
                { if (max_vs[j]>vs_max)
                    { vs_max = max_vs[j];}
                else
                        continue;
                if (vs_min >min_vs[j])
                    {
                        vs_min = min_vs[j]; }
                  else
                            continue;

                }
                }
            return (vs_max,vs_min);
        }
 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入要計算幾個梯形");
            int  ct = Convert.ToInt32(Console.ReadLine());
            CTrapezoid []ctr=new CTrapezoid[ct];
            double[] up=new double[ct];
            double[] dn = new double[ct];
            double[] hig = new double[ct];
            
            for (int j=0;j<ctr.Length;j++)
            { 
                Console.WriteLine("請輸入第{0}梯形的上底：",j+1);
                up[j] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("請輸入第{0}梯形的下底：",j+1);
                dn[j] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("請輸入第{0}梯形的高：",j+1);
                hig[j] = Convert.ToDouble(Console.ReadLine());
                ctr[j]=new CTrapezoid(up[j], dn[j], hig[j],ct);
                   CTrapezoid.show();
            }
            for (int i=0;i<ctr.Length;i++)
            {
                Console.WriteLine("第{0}個梯形面積" + ctr[i].Area(), i + 1);
            }

            //st1.0vs1 st2 1vs2 st3 2vs3 st4 3vs4 st5 4vs5
            for (int i=0; i<ctr.Length-1;i++)//0123共4次
            {
               var(max,min)= ctr[i].Compare(ctr[i].Area(),ctr[i+1].Area(),i,ct);
                if(i==3)
                { Console.WriteLine("  最大面積為 {0}", max);
                Console.WriteLine("  最小面積為 {0}", min); }
                
            }
              




            Console.Read();
        }


    } 
}

/*if (vs > vs_2)
                    {
                        max_vs[vs_index - 1] = vs;
                        min_vs[vs_index - 1] = vs_2;
                        Console.WriteLine("test00");

                    }
                    else
                        max_vs[vs_index - 1] = vs_2;
                    min_vs[vs_index - 1] = vs;
                    Console.WriteLine("test");
                 cc++;

               
                if (vs_2 > vs_last)
                    {
                        max_vs[final_index - 1] = vs_2;
                        min_vs[final_index - 1] = vs_last;

                    }
                    else
                        max_vs[final_index - 1] = vs_last;
                    min_vs[final_index - 1] = vs_2;
                 cc++;

                 double max_final = max_vs[0];
                    double min_final = min_vs[0];
                    int final_count_max = 0;
                    int final_count_min = 0;
                    for (int j = 0; j < max_vs.Length; j++)//0~4
                    {

                        if (max_final < max_vs[j])
                        {
                            max_final = max_vs[j];
                            final_count_max++;
                        }
                        else
                            final_count_min++;

                        if (min_final > min_vs[j])
                        { min_final = min_vs[j];
                            final_count_min++;
                        }
                        else
                            final_count_max++;
                    }


                     Console.WriteLine("最大面積為" + max_final + "為第{0}個", final_count_max + 1);
                     Console.WriteLine("最小面積為" + min_final + "為第{0}個", final_count_min + 1);
                    
 */
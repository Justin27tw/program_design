using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Temp//命名空間 Temp 生存範圍第6行~第30行
{
    class CCircle
    {
        const double pi = 3.14;   //const固定值不能更改，圓周率
        double radius;  //半徑
        public CCircle(double r)//用建構元給予半徑值
        {
            if (r > 0)
            {
                radius = r;
            }
            else
            {
                radius = 1.0;
            }

        }
        public double Area()//圓面積計算
        {
            return radius * radius * pi;
        }

    }
}
    namespace _0606classroom//命名空間 _0606classroom 生存範圍第31行~第58行
    {
    using Temp; //引入其他命名空間

        internal class Program
        {
            static void Main(string[] args)
            {
                //如果想在 0606classroom命名空間 使用其他命名空間的類別或方法或建構元
                /*有兩種做法 
                       1.在現在的命名空間中使用的其他命名空間之類別還有方法和建構元
                前面加上 原本所屬的命名空間之名稱ex: 在Temp 裡面有class CCircle類別 
                如果想在0606classroom這個命名空間使用CCircle就要變成 Temp.CCircle
                就這像檔案管理員中，C:\作業\Temp\CCircle 檔案所在的路徑 
                       2.using = >告訴系統說我要使用這個命名空間，
                系統才知道要引入該命名空間，所以系統才能辨識
                ex：第33行 using Temp 這樣底下不用再 Temp.CCircle*/

                CCircle cir1 = new CCircle(9.5);//產生物件並直接用建構元呼叫
                CCircle cir2 = new CCircle(8.0);
                Console.Write("面積=" + cir2.Area());

            Console.Read();

            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象類別
{ abstract class CShape//抽象類別
    {

        protected String color;//存取修飾詞=>保護
        public void setColor(String str)//方法
        { 
         color = str;
        }
        public abstract void show();//抽象方法，只做好模板未實作，記得最後加上;
    }
    class CRectangle : CShape//類別繼承抽象類別
    { 
        protected int width,height;
        public CRectangle(int w, int h)//方法
        {
            width = w;
            height = h;
        }
        public override void show()//改寫，並實作
        {
            Console.Write("color=" + color + ", ");
            Console.WriteLine("area=" + width * height);
        }
    }
    class CCircle : CShape
    {
        protected double radius;
        public CCircle(double r) 
        { 
        radius = r;
        }
        public override void show()
        {
            Console.Write("color=" + color + ", ");
            Console.WriteLine("area="+3.14*radius*radius);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CRectangle rect = new CRectangle(5, 10);
            rect.setColor("Yellow");
            rect.show();
            CCircle cir = new CCircle(2.0);
            cir.setColor("Green");
            cir.show();
            Console.Read();
        }
    }
}
//抽象類別abstract VS 介面interface
/*抽象類別裡面可以有一般的方法，也可以有抽象方法，只要有抽象方法就要在class的時候加上abstract
//定義時方法如同只給大方向未說清楚內容，繼承下去後自己改
abstract class 類別名
{
    public abstract 資料型態 方法名();
}
class 類別名:父類別
{
    public (new/override) 資料型態 方法名() //此處為改寫並實作
    {
    ...................//實作
    }
}

---------------------------------------------------------------------------------------------
//定義規格，在子類別實作內容
interface 類別名  //裡面的方法不能有public private abstract 因為已經預設好了不能多寫
{
    資料型態 方法名();//一樣為抽象方法未實作
}
class 類別名:介面名
{
   資料型態 方法名()
    {
...............//實作
    }
}
 */

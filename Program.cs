using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pen_domjudg
{
    class CCount
    {
        int pen=12;
        int index12;
        int index5;
        int money;
        public void Counting(int pencount)
        {
            index12= pencount / pen;
            index5= pencount % pen;
            
            money += (index12 * 50)+(index5*5);
            Console.Write(money);
          
        }
       
    }
    
    internal class Program
    {
        static void Main(string[] args)
        { CCount count1 = new CCount();
            Console.Write("鉛筆幾隻?");
            int pen_count=Convert.ToInt32(Console.ReadLine());
            if (pen_count >= 1 && pen_count <= 200)
            { count1.Counting(pen_count );
                
            }

            Console.Read();
        }
    }
}

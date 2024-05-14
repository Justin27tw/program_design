using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1.請撰寫一個CHuman 類別，定義姓名 性別 年齡
2.請撰寫一個CStudent子類別，定義學號 班級 成績
3.請生成3個學生物件，並且適度的準備好對應的子類別和父類別的建構元(請善用base和this)
4.請在CStudent類別內，完成一個compare方法，得以找出所有學生中分數最高的學生學號 */
namespace _0411
{class CHuman
    { static string[]name=new string[3];
        static int[] age=new int[3];
        static int[]sex=new int[3];
        public CHuman(string Name,int Sex,int Age,int count )
        {
            name[count]=Name;
            sex[count]=Sex;
            age[count]=Age;
            
        
        }
    }
    class CStudent:CHuman
    {
       
        static int []StudentNumber=new int[3];
      static string[] ClassNumber=new string[3];
        static int[] score=new int [3];
        int max_score=0;
        int max_SNindex;
        public CStudent(string n ,int s,int a,int sn,string cn,int se,int ct):base(n,s,a,ct)
        {
            StudentNumber[ct]=sn;
            ClassNumber[ct]=cn;
            score[ct]=se;
        }
        public void Compare()
        {for (int i=0;i<StudentNumber.Length;i++) 
           { if (score[i]>max_score)
            { max_score = score[i];
              max_SNindex = StudentNumber[i];}
           else
                { continue;}
            }
        Console.WriteLine("最高分的學號為{0}為{1}分",max_SNindex,max_score);
        }
    
    }


    class Program
    {
        static void Main(string[] args)
        { 
            CStudent Std1, Std2, Std3;
            
            Console.WriteLine("請輸入共幾位學生");
            int count = Convert.ToInt32(Console.ReadLine());
            string[] name = new string[count];
            int[] age = new int[count];
            int[] sex = new int[count];
            int []StudentNumber=new int[count];
            string []ClassNumber=new string[count];
            int []score=new int [count];
            int sign;
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < 1; i++)
                {
                    
                    Console.WriteLine("請輸入第{0}位學生姓名:",j +1);
                    name[j] = Console.ReadLine();
                    Console.WriteLine("請輸入第{0}位學生性別(男生請輸入0、女生請輸入1):", j + 1);
                    sex[j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("請輸入第{0}位學生年齡:", j + 1);
                    age[j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("請輸入第{0}位學生學號:", j + 1);
                    StudentNumber[j]= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("請輸入第{0}位學生班級:", j + 1);
                    ClassNumber[j]=Convert.ToString(Console.ReadLine());
                    Console.WriteLine("請輸入第{0}位學生成績:", j + 1);
                    score[j]= Convert.ToInt32(Console.ReadLine());

                }    
                }
            while (true) { Console.WriteLine("請輸入是否登入學生資料:按任意正數 離開請按0:");
                sign=Convert.ToInt32(Console.ReadLine());
                if(sign>0)
                { 
                    Std1 = new CStudent(name[0], sex[0], age[0], StudentNumber[0], ClassNumber[0], score[0], 0);
                    Std2 = new CStudent(name[1], sex[1], age[1], StudentNumber[1], ClassNumber[1], score[1], 1);
                    Std3 = new CStudent(name[2], sex[2], age[2], StudentNumber[2], ClassNumber[2], score[2], 2);
                Std3.Compare();
                }
                if(sign==0)
                    {break; }
            
            }


            Console.Read();
        }
        }
   
    }
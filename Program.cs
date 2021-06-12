using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleAppTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\pc\Desktop\.NET\Test.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            Console.WriteLine("chose oration 1- add studint 2- retrieve  student 3- update  : 4- Display");
            string op_chos = Console.ReadLine();
            if (op_chos == "1" )
            {
                Console.WriteLine("Enter How many user you want ? :");
                int InpuCont =Convert.ToInt32( Console.ReadLine());
                for (int i = 0; i < InpuCont; i++)
                {
                    Console.WriteLine("Enter ID :");
                    int UserID =Convert.ToInt32( Console.ReadLine());
                    Console.WriteLine("Enter Name :");
                    string UserName = Console.ReadLine();
                    Console.WriteLine("Enter Class :");
                    string UserClass = Console.ReadLine();
                    Console.WriteLine("Enter Sucen :");
                    string UserSachen = Console.ReadLine();
                    string x = UserID.ToString() + ',' + UserName + ',' + UserClass + ',' + UserSachen;
                    lines.Add(x);
                    File.WriteAllLines(filePath, lines);
                }
            }
            else if (op_chos == "2")
            {
                Console.WriteLine("Enter ID To find  :");
                string ScanID = Console.ReadLine();


                foreach (var line in lines)
                {
                    string[] arry = line.Split(',');
                    if (arry[0] == ScanID)
                    {
                       
                        Console.WriteLine("ID is :" + arry[0] + "\t NAME is " + arry[1] + "\t CLASS is " + arry[2] + "\t SACTION is " + arry[3]);

                    }  

                }
            }
            else if (op_chos == "3")
            {
                Console.WriteLine("Enter ID for UPDET  :");
                string ScanID = Console.ReadLine();
                
                foreach (var line in lines)
                {
                    
                        string[] arry = line.Split(',');
                        if (arry[0] == ScanID)
                        {
                            lines.Remove(arry[0] + ',' + arry[1] + ',' + arry[2] + ',' + arry[3]);
                            Console.WriteLine("Enter Name :");
                            string UserName = Console.ReadLine();
                            Console.WriteLine("Enter Class :");
                            string UserClass = Console.ReadLine();
                            Console.WriteLine("Enter Sucen :");
                            string UserSachen = Console.ReadLine();
                            arry[1] = UserName;
                            arry[2] = UserClass;
                            arry[3] = UserSachen;
                            string x = ScanID + ',' + arry[1] + ',' + arry[2] + ',' + arry[3];
                            
                            lines.Add(x);
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine(" Update Scssefle");
                            Console.WriteLine("ID is :" + arry[0] + "\t NAME is " + arry[1] + "\t CLASS is " + arry[2] + "\t SACTION is " + arry[3]);
                            break;

                         }
                    
                }  
            }
            else
            {
                foreach (string line in lines)
                {

                    string[] arry = line.Split(',');
                    Console.WriteLine("ID is :"+arry[0]+"\t NAME is "+ arry[1]+ "\t CLASS is "+ arry[2]+ "\t SACTION is "+ arry[3]);
                }

            }
            
            
            

        }
    }

   
}

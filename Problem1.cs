using System;
using System.Linq;

namespace CodingChallenge
{
    class Program
    {
        public static int totalCount=1;
        static void Main(string[] args)
        {
           
            int n;
            n = int.Parse(Console.ReadLine());
            Persistence(n);
            
            static void Persistence(int arr)
            {
                int[] converted = ToConvert(arr);
                int mul = 1,count = 1,len=0,len2;
                len2 = converted.Length;
              //  Console.WriteLine("Check first array"+len2);
                if (len2 == 1)
                {
                    Console.WriteLine("Number of times multiplied: 0");
                }
                else
                {
                    for (int i = 0; i < converted.Length; i++)
                    {
                        //Console.WriteLine(converted[i]);
                        mul = mul *converted[i];    
                    }
                    
                  //  Console.WriteLine(mul);
                    int[] num3 = ToConvert(mul);
                    len = num3.Length;

               // Console.WriteLine("check len result"+len);
               
                    if (len == 1)
                    {

                        Console.WriteLine("Number of times multiplied: " + (totalCount));

                    }
                    else
                    {
                        totalCount += count;
                    //  Console.WriteLine("TC" + totalCount);

                        Persistence(mul);

                    }
                }
        }

            static int[] ToConvert(int num){
                String nn = num.ToString();
                char[] input;
                input = nn.ToCharArray();
                int[] num2;
                num2= nn.Select(c => Convert.ToInt32(c.ToString())).ToArray();
                return num2;
            }
            

        }
    }
}

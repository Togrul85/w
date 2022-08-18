using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork0
{
      static class ExtentionMethods
    {
        public static bool IsOdd(int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
            return false;
        }

       public static  bool IsEven(int num)
        {
            if (num % 2 ==0)
            {
                return true;
            }
            return false;
        }
        public static  bool IsContainsDigit(string str)
        {
            if (str == "digit character")
            {
                return true;
            }

            return false;    
           
        }
        public  static string ToCapitalize(this string str)
        {
            StringBuilder a = new StringBuilder();
            a.Append(Char.ToUpper(str[0]));
            a.Append(str.Substring(1).ToLower());
            return a.ToString(); 
        }
        public static int []  GetValueIndexes(this string str,char c)
        {
            int[] Array = new int[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==c)
                {
                    Array (ref Array, Array.Length + 1);
                    Array[^1] = i;
                }
            }
            return Array;
        }
       


    }
      

}


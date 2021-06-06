using System;
using System.Collections.Generic;
using System.Text;

namespace extension_method.Extensions
{
    public static class Extensions
    {
      
        public static string encryption(this string str,  int key) 
        {
            
             char[] alphabet ={'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı',
        'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };

            string result = "";
            foreach (var i in str)
            { 
                if (str.Contains(i))
                {
                    int number = Array.IndexOf(alphabet, i);
                    number = (number + key) % 29;
                    result = result + alphabet[number];

                }
                else { result += i; }
                }
                return result;

            }
        public static string decoder(this string str, int key)
        {
            return encryption(str, 29 - key);

        }
    }
 }
         




  
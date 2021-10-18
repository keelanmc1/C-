using System;
using System.IO; 
using System.Collections; 
using System.Text; 

namespace myapp
{
    public class Program
    {
        public static void Main(string [] args)
        {
           
            Console.WriteLine("Enter the string you would like to reverse >"); 
            string str = Console.ReadLine(); 

            Console.WriteLine("The reversed string is: "+reverseString(str)); 
            
        }

        private static string reverseString (string str)
        {
            char[]charArray = str.ToCharArray(); 
            Array.Reverse(charArray); 
            return new string(charArray); 
        }

        
            
            
            
                

        
    }
}

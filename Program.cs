using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a word that reads from the left to the right and still remains the same
            Console.Write("Enter the word to check its palidrome : ");
            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();


            string reverse ="" ;
            for (int i = chars.Length-1; i >= 0; i--)
            {
                //read the word from the right to the left
                reverse = reverse + chars[i].ToString();
                
            }
           

            if (reverse.Contains(word))
            {
                Console.WriteLine("The word '{0}' is palindrome", word);
            }else
            {
                Console.WriteLine("The word '{0}' is not palindrome", word);
            }

            Console.ReadLine();
        }
    }
}

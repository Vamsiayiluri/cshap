using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "21121221111111111111";
            if (input.Length < 4)
            {
                Console.WriteLine("invalid input");
            }
            else
            {
                Program product = new Program();
                int result = product.getMaxProduct(input);
                Console.WriteLine(result);
                
            }
        }

        public int getMaxProduct(string input)
        {
            int maxProduct = 0;
            for (int i = 0; i < input.Length - 3; i++)
            {
                int tempProduct = 1;
                for (int j = 0; j < 4; j++)
                {                   
                    char k = input[i + j];
                    int val = (int)Char.GetNumericValue(k);                   
                    tempProduct = tempProduct * val;
                }
                if (tempProduct > maxProduct)
                {                    
                    maxProduct = tempProduct;                    
                }               
            }
            return maxProduct;
        }
    }
}

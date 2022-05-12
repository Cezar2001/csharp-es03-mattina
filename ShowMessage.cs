using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_es03_mattina
{
    internal class ShowMessage
    {
        public static void AppendMessage(string text)
        {
            /*
            if (text.Length > 10)
            {
                Console.WriteLine(text.Substring(0, 10));
                AppendMessage(text.Substring(10));
            }
            else
            {
                Console.WriteLine(text);
            }
            */


            
            while (text.Length > 10)
            {
                Console.WriteLine(text.Substring(0, 10));
                text = text.Substring(10);
            }
            Console.WriteLine(text);
            

            /*
            int pos = 0;
            foreach (char c in text)
            {
                if (pos == 10)
                {
                    Console.WriteLine(c);   
                    pos = 0;
                }
                Console.WriteLine(c);
                pos++;
            }
            */

        }
    }
}

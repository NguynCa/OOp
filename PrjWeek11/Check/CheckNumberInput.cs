using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    class CheckNumberInput
    {
        public void Check (ref int n)
        {
            do
            {
                bool kt = false;
                do
                {
                    Console.Write("Enter the number: ");
                    string Load = Console.ReadLine();
                    kt = int.TryParse(Load, out n);
                } while (!kt);
            } while (0 < n);
        }
    }
}

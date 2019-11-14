using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblre_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many numbers are you going to input?");
            int lot = Convert.ToInt32(Console.ReadLine());

            int hold;
            int[] to = new int[lot];

            for (int i = 0; i < lot; i++)
            {
                hold = Convert.ToInt32(Console.ReadLine());

                to[i] = hold;
            }
                
            int[] d = bubbleu(to);

            Console.WriteLine();

            foreach (int num in d)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();

        }

        public static int[] bubbled(int[] old)
        {
            int[] newl = old;
            bool done = false;
            int i;
            int hold;

            while (!done)
            {
                i = 0;
                done = true;

                foreach (int num in newl)
                {
                    if (i != newl.Length - 1)
                    {
                        if (num < newl[i + 1])
                        {
                            hold = num;
                            newl[i] = newl[i + 1];
                            newl[i + 1] = hold;

                            done = false;
                        }
                    }
                    i = i + 1;
                }
            }
            return newl;
        }

        public static int[] bubbleu(int[] old)
        {
            int[] newl = old;
            bool done = false;
            int i;
            int hold;

            while (!done)
            {
                i = 0;
                done = true;

                foreach (int num in newl)
                {
                    if (i != newl.Length - 1)
                    {
                        if (num < newl[i + 1])
                        {
                            hold = num;
                            newl[i] = newl[i + 1];
                            newl[i + 1] = hold;

                            done = false;
                        }
                    }
                    i = i + 1;
                }
            }
            return newl;
        }
    }
}

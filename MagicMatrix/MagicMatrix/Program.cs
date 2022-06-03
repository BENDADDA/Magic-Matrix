using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicMatrix
{

    class Program
    {
        /* magic matrix Function ---------------------------------------------------------------------------------------*/
        static void g(ref int a, ref int b, int n) //1---------------------------------------------------------------.
        {
            if (a == n + 1) a = 0;
            if (a == -1) a = n;
            if (b == n + 1) b = 0;
            if (b == -1) b = n;
        }

        public static void MagicMatrix(int[,] v, int n)//2------------------------------------------------------------------------------------.
        {
            int l, c, i, N;
            if (n % 2 == 0) n++; N = (n - 1) / 2; l = N - 1; c = N; i = 0;
            while (i < n * n)
            {
                if (l >= 0 && l < n && c >= 0 && c < n)
                {
                    if (v[l, c] == 0) { v[l, c] = i + 1; i++; l--; c++; }
                    else { l--; c--; }
                }
                else g(ref l, ref c, n - 1);
            }
        }
       
        static void Main(string[] args)
        {
            start:
            Console.Write("Enter a number where n=2K+1\nn=");
            int n = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[n, n];
            MagicMatrix(Matrix, n);
            for (int i = 0; i < n; i++)
            {
                for(int j=0;j<n;j++)
                Console.Write(Matrix[i,j]+"  ");
                Console.WriteLine();
            }
          /* The sum of any column, any line, or any chord in
              MagicMatrix = const = n* (n * n + 1) / 2 */
            Console.Write("\nSum=" + n * (n * n + 1) / 2);
            string str = Console.ReadLine();
            if (str != "Exit") { Console.Clear();goto start; }
           

        }
    }
}

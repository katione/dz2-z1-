using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_z1_
{
    internal class z1
    {
       static void Main()
        {
            Random random = new Random();
            Console.WriteLine("Введите размер первого массива: ");
            int N = Convert.ToInt32( Console.ReadLine());
            int[] array1 = new int[N];
            for (int i=0; i<N; i++)
            {
                array1[i]=random.Next(50);
                Console.Write(array1[i]+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Введите размер второго массива: ");
            int M = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[M];
            for (int i = 0; i < M; i++)
            {
                array2[i]=random.Next(50);
                Console.Write(array2[i]+" ");
            }
            Console.WriteLine();

            int k =random.Next(0,N);
            Console.WriteLine("k = "+  k);

            Array.Resize(ref array1, array1.Length + array2.Length);
            for(int i=N-1; i>k-1; i--)
            {
                array1[i + M] = array1[i];
            }
            Array.Copy(array2 ,0,array1, k, M);
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }
        }
    }
}

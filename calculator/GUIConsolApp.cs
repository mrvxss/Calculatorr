using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    internal class GUIConsolApp
    {
        public double[] GetArray(double[] array)
        {
            //Intial Array Length
            Console.Write($"ВВедите количество чисел:");
            array = new double[int.Parse(Console.ReadLine())];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"ВВедите число {i}  ");
                array [i] = double.Parse(Console.ReadLine());
            }
            return array;
        }

    }
}

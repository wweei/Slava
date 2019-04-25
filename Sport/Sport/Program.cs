using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    class Program
    {
        static void Main(string[] args)
        {
            float[][] Sportsmens = new float[5][];
            Console.WriteLine("Введите результаты спортсменов:");
            for (int i = 1; i < 6; i++)
            {
                float[] sportsmen = new float[5];
                sportsmen[0] = i;
                for (int j = 1; j < 4; j++)
                {
                    Console.WriteLine("Спортсмен №" + i + "\nПопытка №" + j);
                    sportsmen[j] = Convert.ToSingle(Console.ReadLine());
                }
                sportsmen[4] = BestRes(sportsmen);
                Sportsmens[i - 1] = sportsmen;
            }
            Console.WriteLine("Таблица результатов спортсменов:");
            Console.WriteLine("Участник №\tПопытка 1\tПопытка 2\tПопытка 3\tЛучший результат");
            foreach (var i in Sportsmens)
            {
                foreach (var x in i)
                {
                    Console.Write(x + "\t\t");
                }
                Console.Write("\n");
            }
            float bestIndex = -1, bestRes = float.MinValue;
            for (int i = 0; i < Sportsmens.Length; i++)
            {
                if (Sportsmens[i][4] > bestRes) { bestRes = Sportsmens[i][4]; bestIndex = Sportsmens[i][0]; }
            }

            Console.WriteLine("\nЛучший результат у спортсмена №" + bestIndex + " = " + bestRes);
            Console.ReadLine();
        }

        static float BestRes(float[] mass)
        {
            float max = float.MinValue;
            for (int i = 1; i < 5; i++)
            {
                if (mass[i] > max) max = mass[i];
            }
            return max;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public class Program
    {
        static void Main(string[] args)
        {
            float[][] Athletes = new float[5][];
            Console.WriteLine("Введите результаты спортсменов:");
            for (int i = 0; i < 5; i++)
            {
                Athletes[i] = NewSportsman(i+1);
            }

            Console.WriteLine("Таблица результатов спортсменов:");
            Console.WriteLine("Участник №\tПопытка 1\tПопытка 2\tПопытка 3\tЛучший результат");
            foreach (var sportsman in Athletes)
            {
                foreach (var x in sportsman)
                {
                    Console.Write(x + "\t\t");
                }
                Console.Write("\n");
            }


            float bestIndex = -1, bestRes = float.MinValue;
            for (int i = 0; i < Athletes.Length; i++)
            {
                if (Athletes[i][4] > bestRes) { bestRes = Athletes[i][4]; bestIndex = Athletes[i][0]; }
            }

            Console.WriteLine("\nЛучший результат у спортсмена №" + bestIndex + " = " + bestRes);
            Console.ReadLine();
        }

        /// <summary>
        /// Запрашивает данные у пользователя и выдает массив sportsmen[5],
        /// где номер это sportsmen[0] и лучший результат sportsmen[4]
        /// </summary>
        /// <param name="Number">Номер спортсмена</param>
        /// <returns></returns>
        public static float[] NewSportsman(int Number)
        {
            float[] sportsman = new float[5];
            sportsman[0] = Number;                   //Первый элемент массива sportsmen, это его номер.

            for (int j = 1; j < 4; j++)
            {
                Console.WriteLine("Спортсмен №" + Number + "\nПопытка №" + j);
                sportsman[j] = Convert.ToSingle(Console.ReadLine());
            }
            sportsman[4] = BestRes(sportsman);
            return sportsman;
        }

        /// <summary>
        /// Для поиска максимума с первого элемента.
        /// </summary>
        /// <param name="mass"></param>
        /// <returns></returns>
        public static float BestRes(float[] mass)
        {
            float max = float.MinValue;
            for (int i = 1; i < mass.Length; i++)
            {
                if (mass[i] > max) max = mass[i];
            }
            return max;
        }
    }
}

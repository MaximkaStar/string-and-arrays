using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterYourName = "Пожалуйста, введите свое имя.";
            string greetings = "Привет";
            string name;

            Console.WriteLine(enterYourName);
            name = Console.ReadLine();

            //greetings = greetings + " , " + name;

            //Console.WriteLine(greetings);
            Console.WriteLine(string.Format("{1}, {0}", name, greetings));

            //интерполяция
            Console.WriteLine($"{greetings}, {name}");

            //String Builder
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("строка");
            //много-много раз что-то присоединяется.
            var result = stringBuilder.ToString();

            var nameChange = name.Contains(greetings);

            Console.ReadLine();

            //массивы
            int[] numbersOne = new int[5];
            numbersOne[0] = 2;

            int[] numbersTwo = new int[] { 1, 2, 3, 4, 5 };
            int[] numbersThree = { 1, 2, 3, 4, 5 };

            int[,] numbers = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };

            int[][] numbersReaped = new int[3][];
            numbersReaped[0] = new int[] { 1, 2 };
            numbersReaped[1] = new int[] { 1, 2, 3, 4 };
            numbersReaped[2] = new int[] { 0 };

            for(int i = 0; i<numbersTwo.Length; i++)
            {
                if(numbersTwo[i]%2==0)
                {

                }
            }

            foreach (var number in numbersTwo)
            {
                if(number%2==0)
                {
                    //number = 2; //не имеете права
                }
            }

            
        }
    }
}

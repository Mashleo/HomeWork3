using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NODEvklid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Среди какого количества чисел вы ходите найти НОД - ");
            int amount = int.Parse(Console.ReadLine());
            int[] writingNumbers = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                Console.Write($"Укажите число номер {i + 1} - ");
                writingNumbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Array.Sort(writingNumbers);
            //Реализация Евклидового метода
            int c;
            int nod = writingNumbers[0];
            for (int i = 1; i < amount; i++)
            {
                c = writingNumbers[i] % nod;
                if (c == 0)
                {
                    nod = writingNumbers[0];


                }
                else if (c == 1)
                {
                    nod = c;
                    break;//так как если у 1й пары  только 1 НОК, но неиеет смысла след проверять


                }
                else
                {
                    
                    while (c > 1)
                    {

                        int Temp = c; //  до деления запишем остаток в переменную. что б потом туда после каждого днлнния записывать перменную
                        nod = nod % c;
                        c = nod;
                        nod = Temp; //  меняем местами остаток ито на что делили

                    }
                    if (c == 1)
                    {
                        nod = c;
                        break; //так как если у пвры только 1 НОК, но неиеет смысла след проверять

                    }
                }
            }
            Console.WriteLine(nod);
        }
    }
}

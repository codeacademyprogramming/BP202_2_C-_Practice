using System;

namespace _15032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Taks1
            //int num1 = 45;
            //int num2 = 3;
            //char operation = '*';

            //int result = 0;

            ////if (operation == '+')
            ////    result = num1 + num2;
            ////else if (operation == '-')
            ////    result = num1 - num2;
            ////else if (operation == '*')
            ////    result = num1 * num2;
            ////else if(operation == '/')
            ////    result = num1 / num2;
            ////else
            ////    Console.WriteLine("Simvol operator deyil!");

            ////Console.WriteLine("Result: "+result);

            //string output;
            //bool check = true;
            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        result = num1 / num2;
            //        break;
            //    default:
            //        check = false;
            //        break;

            //}

            //if (check)
            //{
            //    output = $"{num1}{operation}{num2}={result}";
            //    Console.WriteLine(output);
            //}
            //else
            //    Console.WriteLine("Operator yanlisdir!");
            #endregion


            #region Task2

            //Console.WriteLine("Adlarin sayini daxil et:");
            //string namesCountStr = Console.ReadLine();

            //int namesCount = Convert.ToInt32(namesCountStr);

            //string[] names = new string[namesCount];

            //for (int i = 0; i < namesCount; i++)
            //{
            //    Console.WriteLine($"{i+1}. adi daxil et");
            //    names[i] = Console.ReadLine();
            //}   


            //int count = 0;

            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i][0] == 'A')
            //        count++;
            //}

            //string[] newNames = new string[count];
            //int j = 0;

            //for (int i = 0;i < names.Length; i++)
            //{
            //    if (names[i][0] == 'A')
            //    {
            //        newNames[j] = names[i];
            //        j++;
            //    }
            //}


            //Console.WriteLine("Wanted names:");
            //foreach (var item in newNames)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            int num = 45;


            Console.WriteLine(num);

            var newNum = num;


            string word = null;
            int[] numbers = null;

            if (word!=null && word.Length > 0)
            {
                Console.WriteLine();
            }

            byte? age = null;
            Console.WriteLine(word);

        }
    }
}

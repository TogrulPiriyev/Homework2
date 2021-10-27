using System;

namespace Homework_3
{
    class Homework3
    {
        static void Main(string[] args)
        {
            #region Task1

            //string word = Console.ReadLine();
            //string letter = Console.ReadLine();

            //bool negativeOneOrPositiveTwo = FindInWordLetter(word, letter);

            //ShowNegativeOneOrPositiveTwo(negativeOneOrPositiveTwo);






            //static bool FindInWordLetter(string word, string letter)
            //{
            //   for (int i = 0; i < word.Length; i++)
            //   {
            //       for (int j = 0; j < letter.Length; j++)
            //       {
            //         if (word[i] == letter[j])
            //                return true;
            //       }

            //   }
            //   return false;
            //}
            //static void ShowNegativeOneOrPositiveTwo(bool trueFalse)
            //{
            //     if (trueFalse)
            //     {
            //        Console.WriteLine(2);

            //     }
            //     else
            //     {
            //        Console.WriteLine(-1);
            //     }


            //}
            #endregion
            #region Task2
            //int num = 27;
            //Console.WriteLine(Sqrt(num));
            //static int Sqrt(int num)
            //{
            //    int sqrtNum = 1;
            //    while (true)
            //    {
            //        if (sqrtNum * sqrtNum <= num)
            //        {
            //            sqrtNum++;
            //        }
            //        else if (sqrtNum * sqrtNum > num)
            //        {
            //            sqrtNum--;
            //            return sqrtNum;
            //        }

            //    }
            //    return sqrtNum;
            //}
            #endregion
            #region Task3
            //int num = 254;
            //Console.WriteLine(SumOfnum(num));
            //static int SumOfnum(int num) 
            //{
            //    int new_num = 0;
            //    while (num > 0)
            //    {
            //        new_num += num % 10;
            //        num = (num - (num % 10)) / 10;

            //    }
            //    return new_num;
            //}

            #endregion
            #region Task4
            //int[] arr = { 5, 15, 23, 99, 245, 123  };
            //int max = arr[0];
            //Console.WriteLine(MaxArr(arr, max));
            //static int MaxArr(int[] arr,int max)
            //{
            //    for (int i = 1; i < arr.Length; i++)
            //    {

            //        if (max < arr[i]) max=arr[i];

            //    }
            //    return max;
            //}  

            #endregion
            #region Task5
            int[] numbers = { 1, -4, 9, -8 };
            numbers = PositivNumbers(numbers);
            ShowArray(numbers);
                        
            static int[] PositivNumbers(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < 0)
                    {
                        numbers[i] = numbers[i] * -1;
                    }
                    
                }
                return numbers;
            }
            static void ShowArray(int[] numbers)
            {
                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }

            }
            #endregion
        }
    }
} 
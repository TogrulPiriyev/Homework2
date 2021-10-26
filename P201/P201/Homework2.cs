using System;

namespace P201
{
    class Homework2
    {
        static void Main2(string[] args)
        {
            string word = Console.ReadLine();
            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
            for (int i = 0; i < word.Length; i++) {
                for (int j = 0; j < numbers.Length; j++) 
                {   if (word[i] == numbers[j])
                    {
                        Console.WriteLine("var");
                        break;
                    }

                }

            }




        }
    }
}

using System;

namespace P201
{
    class Homework2
    {
        static void Main2(string[] args)
        {
            string word = Console.ReadLine();
            string letter = Console.ReadLine();

            bool negativeOneOrPositiveTwo = FindInWordLetter(word, letter);

            ShowNegativeOneOrPositiveTwo(negativeOneOrPositiveTwo);





        }
        static bool FindInWordLetter(string word,string letter)
        {
            for (int i = 0; i < word.Length; i++) 
            {
                for (int j = 0; j < letter.Length; j++) {
                    if (word[i] == letter[j])
                        return true;
                }

            }
            return false;
        }
        static void ShowNegativeOneOrPositiveTwo(bool trueFalse)
        {
            if (trueFalse)
            {
                Console.WriteLine("2");

            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}

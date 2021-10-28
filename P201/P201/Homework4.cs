using System;

namespace Homework4
{
    class Homework4
    {
        static void Main(string[] args)
        {   
            //First Task
            string word = Console.ReadLine();
            string new_word = ConverselyWord(word);
            Console.WriteLine(new_word);
            //Second Task
            string text = Console.ReadLine();
            int Counter = 1;
            Counter = CounterWordInText(text, Counter);
            Console.WriteLine(Counter);
            //Third task
            string word_char = Console.ReadLine();
            char new_char = 'a';
            int[] arrnum=new int[10];
            arrnum = IndexSearch(word_char, new_char, arrnum);

            foreach (var num in arrnum)
            {
                Console.WriteLine(num);
            }

        }
        static string ConverselyWord(string word)
        {
            string temporary_word= "" ;
            for (int i = 0; i < word.Length; i++)
            {
                int new_index = (word.Length-1) - i;
                temporary_word += word[new_index];
                
            }
            return temporary_word;
            
            
        }
        static int CounterWordInText(string word,int counter)
        {
            for (int i = 1; i < word.Length-1; i++)
            {
                if (word[i-1]!=' ' && word[i]==' ' &&  word[i+1]!= ' ')
                {
                   counter++;

                }
            }
            return counter;
        }
        static int[] IndexSearch(string word,char newchar,int[] arrnum)
        {
            
            for (int i = 0; i < word.Length; i++)
            {
                
                
                if (word[i]==newchar)
                {
                    
                    arrnum[i] = i;
                    

                }
            }
            return arrnum;

        }
    }
}

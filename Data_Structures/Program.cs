using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            /*take word and revers inputed word
            * take input and display input in reverse
            * create separate method for resersing sting
            * return type should be a string
            * parameter should be a string
            * inside sting reverse method, reverse inputed string unsing a stack
            * start a stack
            * use stack to store characters
            * use stack to retrieve characters in reverse order
            * display revers string in console
            * problem can be solved without stack. if you find easier without still use stack
            * ============================================
            * consider cases where user does not enter a single word but a sentence
            * don't reverse entire sentense, instead reverse each word but keep the words in the original order
            * validate user input to make sure user isn't using symbols or numbers
            */

            Console.Write("Please enter what you would like to reverse: ");
            string forWord = Console.ReadLine();   //grab the word

            string finalRev = ReverseString(forWord);  // call method

            Console.Write($"\nYour word in reverse is {finalRev}.\n\n");


            StringBuilder revSent = new StringBuilder();   //new stuff
            string[] words = finalRev.Split(' ');          //creates an array and splits a string by whatever character you want into different entries in the array. 
            for (int i = words.Length - 1; i >= 0; i--)   //loop through the array backwards to right the order of the words
            {
                revSent.Append(words[i]);                  //searches through the array values
                revSent.Append(" ");                       //and appends them together to form a new string with a space between them
            }
            Console.WriteLine(revSent);

            //for (int i = 0; i < finalRev.Length; i++)
            //{

            //    if (finalRev[i] == " ")
            //    {

            //    }
            //}

            Console.Write("There is another way.\n\nYour word in reverse is ");

            for (int i = forWord.Length - 1; i >= 0; i--)  //this is the non-stack way to do this
            {

                Console.Write(forWord[i]);  //assigns a number and works through the string backwards
            }

            Console.Write(".\n\n");

        }

        static string ReverseString(string input)
        {
            Stack<char> words = new Stack<char>();   //created stack
            string newWord = "";

            for (int i = 0; i < input.Length; i++)  //loop through input
            {
                //Console.WriteLine($"{input[i]}");   //test
                words.Push(input[i]);               //save to stack
            }

            for (int i = 0; i < input.Length; i++)  //to grab the text from the top of the stack
            {
                newWord = newWord + words.Pop();

            }

            return newWord;


        }

    }
}

using System;
using System.Collections.Generic;

namespace ComposeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rules = { "O>M", "M>E", "R>O" };
            Console.WriteLine("What word stand over this rules?");
            foreach (var rule in rules)
            {
                Console.Write(rule + " ");
            }
            Console.WriteLine();
            Console.WriteLine(WordComposing(rules));
            Console.ReadKey();
        }

        static string WordComposing(string[] rules)
        {
            LinkedList<char> word = new LinkedList<char>();
            LinkedListNode<char> firstNode;
            LinkedListNode<char> secondNode;
            foreach (var rule in rules)
            {
                firstNode = word.Find(rule[0]);
                secondNode = word.Find(rule[2]);
                if (firstNode != null)
                {
                    word.AddAfter(firstNode, rule[2]);
                }
                else if(secondNode != null)
                {
                    word.AddBefore(secondNode, rule[0]);
                }
                else
                {
                    word.AddLast(rule[0]);
                    word.AddLast(rule[2]);
                }
            }
            return string.Join("", word);
        }
    }
}

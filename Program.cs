using System;
using System.IO;

namespace hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //File.WriteAllText("text.txt", "THE CAKE IS A LIE");
            //string ahh = File.ReadAllText("text.txt");
            //Console.WriteLine(ahh);
            

            // string[] words = {"hat", "coat", "Pants"};
            
            //string[] words = File.ReadAllText("word.txt");

            // File.WriteAllLines("words.txt", words);


            if(File.Exists("words.txt"))
            {
                string[] words = File.ReadAllLines("words.txt");
                Console.WriteLine(words[0]);
            }
            Console.ReadLine();
        }
    }
}

﻿using System;

namespace ConsoleApp2
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            int num = 121;
            NewNumber(ref num);
            Console.WriteLine(num);


           
            string text = "Karabakh is Azerbaijan ! ! !";
            ReplaceSpace(ref text)
            Console.WriteLine(text);
            

        }


        static void ReplaceSpace(ref string text)
        {
            text = text.Replace(" ", "");
        }
        
      


        // Task3 Method Start
        static void NewNumber(ref int num)
        {
            int index = 0;
            while (index * index <= num)
            {
                index++;

            }

            num = index - 1;
        }














    }
}

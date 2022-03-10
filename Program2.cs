using System;

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
            Console.WriteLine(ReplaceSpace(ref text));
            

        }


        static string ReplaceSpace(ref string text)
        {
            text = text.Replace(" ", "");
            return text;
        }
        
      


        // Task3 Method Start
        static int NewNumber(ref int num)
        {
            int index = 0;
            while (index * index <= num)
            {
                index++;

            }

            num = index - 1;
            return num;
        }














    }
}

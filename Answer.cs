using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
   public class Answer
    {
        public string answer;

        public Answer(string answer)
        {
            this.answer = answer;
        }

        public Answer()
        {
            string choice;
            Console.WriteLine("Enter your choice: ");
            choice = Console.ReadLine();
        }

        public void printInfo()
        {
            Console.WriteLine(answer);
        }
    }
}

using System;

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

        public void PrintInfo()
        {
            Console.WriteLine(answer);
        }
    }
}

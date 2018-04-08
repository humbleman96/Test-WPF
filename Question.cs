using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
   public class Question
    {

        public int numOfQuestion;
        public string question;


        public Question(int numOfQuestion, string question)
        {
            this.numOfQuestion = numOfQuestion;
            this.question = question;
        }

        public Question(string question)
        {
            this.question = question;
        }

        public Question()
        {

        }


        public void printInfo()
        {
            Console.WriteLine(numOfQuestion + " " + question);
        }
      
    }
}

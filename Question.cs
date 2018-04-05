using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Question
    {

        public int numOfQuestion;
        public string question;


        public Question(int numOfQuestion, string question)
        {
            this.numOfQuestion = numOfQuestion;
            this.question = question;
        }


        public void printInfo()
        {
            Console.WriteLine(numOfQuestion + " " + question);
        }
      
    }
}

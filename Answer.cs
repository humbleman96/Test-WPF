using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Answer
    {
        public string answer;

        public Answer(string answer)
        {
            this.answer = answer;
        }


        public void printInfo()
        {
            Console.WriteLine(answer);
        }
    }
}

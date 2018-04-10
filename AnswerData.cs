using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class AnswerData
    {
        private static List<Answer> answers = new List<Answer>();

        public static List<Answer> testAnswers
        {
            get
            {
                testAnswerData();
                return answers;
            }

            set
            {

            }


        }


        private static void testAnswerData()
        {
            answers.Add(new Answer("1"));
            answers.Add(new Answer("2"));
            answers.Add(new Answer("3"));
            answers.Add(new Answer("4"));

            answers.Add(new Answer("125"));
            answers.Add(new Answer("625"));
            answers.Add(new Answer("425"));
            answers.Add(new Answer("225"));


            answers.Add(new Answer("3"));
            answers.Add(new Answer("6"));
            answers.Add(new Answer("1"));
            answers.Add(new Answer("2"));

            answers.Add(new Answer("26см"));
            answers.Add(new Answer("40см"));
            answers.Add(new Answer("13см"));
            answers.Add(new Answer("20см"));

        }
    }
}

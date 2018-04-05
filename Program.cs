using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            /* foreach(Question question in QuestionData.testQuestions)
              {
                  Console.WriteLine(question.numOfQuestion + " " + question.question);
              }*/

            AnswersGiven.setAnswers();

           /*   foreach(KeyValuePair<Question , List<Answer>> dict in AnswersGiven.answersGiven)
                 {

                Console.WriteLine(dict.Key.numOfQuestion + " " + dict.Key.question);

                foreach (List<Answer> values in AnswersGiven.answersGiven.Values)
                     {
                    Console.WriteLine(AnswersGiven.answersGiven.Values.Count);
                     }
                 }*/
                 
           
            
          



           
            /*
                string question = "Колко страни има квадратът ?";

                Console.WriteLine(question);
                

                List<string> answers = new List<string>();
                answers.Add("1");
                answers.Add("2");
                answers.Add("3");
                answers.Add("4");

                shuffleAnswers(answers);

                for (int j = 0; j < answers.Count; j++)
                {
                    Console.WriteLine(answers[j]);
                }

                Console.WriteLine("Enter your answer here: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 4)
                {
                    Console.WriteLine("Correct Answer !");

                }

                else
                {
                    Console.WriteLine("Try again");
                }
           
            */
            
        }


     /*   public static void shuffleAnswers(List<string> answers)
        {
            Random randomAnswer = new Random();
            for(int i=0; i<answers.Count; i++)
            {
                swapAnswers(answers, i, randomAnswer.Next(i, answers.Count));
            }
        }
        */
       /* public static void swapAnswers(List<string> answers , int a , int b)
        {

               // List temp = answers[answers.IndexOf(answers[a])];
                // answers.IndexOf(answers[a]) = answers.IndexOf(answers[b]);
                //  (answers.IndexOf(answers[b]) = temp;
                answers[answers.IndexOf(answers[a])] = answers[answers.IndexOf(answers[b])];
                answers[answers.IndexOf(answers[b])] = temp;
                
                
            var temp = answers[a];
            answers[a] = answers[b];
            answers[b] = temp;
            



        }*/
    }
}

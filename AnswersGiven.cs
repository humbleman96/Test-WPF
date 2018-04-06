using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class AnswersGiven
    {
        public static Dictionary<Question, Dictionary<List<string>, List<bool>>> correctAnswers;

        //  public static Dictionary <Question, List<Answer>> answersGiven;
        /*  private static List<Answer> answersToQ1 = new List<Answer>();
          private static List<Answer> answersToQ2 = new List<Answer>();
          private static List<Answer> answersTsoQ3 = new List<Answer>();
          */

        private static Dictionary<List<string>, List<bool>> correctAnswersQ1;
        private static Dictionary<List<string>, List<bool>> correctAnswersQ2;
        private static Dictionary<List<string>, List<bool>> correctAnswersQ3;


        private static Dictionary<string, bool> getCorrectAnswerFromQuestion = new Dictionary<string, bool>();
        private static Dictionary<Question, Dictionary<string, bool>> goGocorrectAnswer = new Dictionary<Question, Dictionary<string, bool>>();
        private static List<string> allCorrectAnswers = new List<string>();
       


        private static List<string> answersQ1 = new List<string>();
        private static List<string> answersQ2 = new List<string>();
        private static List<string> answersQ3 = new List<string>();

        private static List<bool> boolsCorrectAnswerQ1 = new List<bool>();
        private static List<bool> boolsCorrectAnswerQ2 = new List<bool>();
        private static List<bool> boolsCorrectAnswerQ3 = new List<bool>();



        public static void setAnswers()
        {

            correctAnswers = new Dictionary<Question, Dictionary<List<string>, List<bool>>>();

            correctAnswersQ1 = new Dictionary<List<string>, List<bool>>();
            correctAnswersQ2 = new Dictionary<List<string>, List<bool>>();
            correctAnswersQ3 = new Dictionary<List<string>, List<bool>>();

            goGocorrectAnswer = new Dictionary<Question, Dictionary<string, bool>>();

            answersQ1.Add("1");
            answersQ1.Add("2");
            answersQ1.Add("3");
            answersQ1.Add("4");

            answersQ2.Add("125");
            answersQ2.Add("625");
            answersQ2.Add("425");
            answersQ2.Add("225");

            answersQ3.Add("3");
            answersQ3.Add("6");
            answersQ3.Add("1");
            answersQ3.Add("2");

            boolsCorrectAnswerQ1.Add(false);
            boolsCorrectAnswerQ1.Add(false);
            boolsCorrectAnswerQ1.Add(false);
            boolsCorrectAnswerQ1.Add(true);

            boolsCorrectAnswerQ2.Add(false);
            boolsCorrectAnswerQ2.Add(true);
            boolsCorrectAnswerQ2.Add(false);
            boolsCorrectAnswerQ2.Add(false);

            boolsCorrectAnswerQ3.Add(true);
            boolsCorrectAnswerQ3.Add(false);
            boolsCorrectAnswerQ3.Add(false);
            boolsCorrectAnswerQ3.Add(false);


            correctAnswersQ1.Add(answersQ1, boolsCorrectAnswerQ1);
            correctAnswersQ2.Add(answersQ2, boolsCorrectAnswerQ2);
            correctAnswersQ3.Add(answersQ3, boolsCorrectAnswerQ3);

            allCorrectAnswers.Add("4");
            allCorrectAnswers.Add("625");
            allCorrectAnswers.Add("3");

         


            /* getCorrectAnswerFromQuestion.Add("4", true);
             getCorrectAnswerFromQuestion.Add("625", true);
             getCorrectAnswerFromQuestion.Add("3", true);
             */
              correctAnswers.Add(QuestionData.testQuestions[0], correctAnswersQ1);
              correctAnswers.Add(QuestionData.testQuestions[1], correctAnswersQ2);
              correctAnswers.Add(QuestionData.testQuestions[2], correctAnswersQ3);





            //getCorrectAnswerFromQuestion.Add(allCorrectAnswers, allCorrectIndexesBool);

            

          

            foreach(string correctAnswer in allCorrectAnswers)
            {
                getCorrectAnswerFromQuestion.Add(correctAnswer, true);
            }
            
            /*
            foreach(KeyValuePair<string, bool> correct in getCorrectAnswerFromQuestion)
            {
                Console.WriteLine(correct.Key + " " + correct.Value);
            }
            */

         //   Console.WriteLine(getCorrectAnswerFromQuestion.Count);

            for (int i= 0; i<getCorrectAnswerFromQuestion.Count; i++)
            {
              //  foreach (KeyValuePair<string, bool> answer in getCorrectAnswerFromQuestion) 
                //    {
                
                   goGocorrectAnswer.Add(QuestionData.testQuestions[i], new Dictionary<string, bool>());
                    goGocorrectAnswer[QuestionData.testQuestions[i]].Add(getCorrectAnswerFromQuestion.ElementAt(i).Key,getCorrectAnswerFromQuestion.ElementAt(i).Value);
              //  }
               
                    }
          
               /*
                for (int i=0; i<getCorrectAnswerFromQuestion.Count; i++)
                {
                    Console.WriteLine(QuestionData.testQuestions[i].question);
                    Console.WriteLine(getCorrectAnswerFromQuestion.ElementAt(i).Key);
                    Console.WriteLine(getCorrectAnswerFromQuestion.ElementAt(i).Value);

                }
                */
            
            

            

           


            // answersGiven = new Dictionary<Question, List<Answer>>();

            /*   answersToQ1.Add(new Answer("1"));
               answersToQ1.Add(new Answer("2"));
               answersToQ1.Add(new Answer("3"));
               answersToQ1.Add(new Answer("4"));

               answersToQ2.Add(new Answer("125"));
               answersToQ2.Add(new Answer("625"));
               answersToQ2.Add(new Answer("425"));
               answersToQ2.Add(new Answer("225"));

               answersToQ3.Add(new Answer("3"));
               answersToQ3.Add(new Answer("6"));
               answersToQ3.Add(new Answer("1"));
               answersToQ3.Add(new Answer("2"));*/

            /* foreach(Question question in QuestionData.testQuestions)
             {

                 answersGiven.Add(question, answersToQ1);
             }
             */

            /*   answersGiven.Add(QuestionData.testQuestions[0], answersToQ1);
               answersGiven.Add(QuestionData.testQuestions[1], answersToQ2);
               answersGiven.Add(QuestionData.testQuestions[2], answersToQ3);*/



            
               tryLabel:
            try
            {
               
                foreach (KeyValuePair<Question, Dictionary<List<string>, List<bool>>> question in correctAnswers)
                {
                    Console.WriteLine(question.Key.question);

                    foreach (KeyValuePair<List<string>, List<bool>> answers in question.Value)
                    {
                        shuffleAnswers(answers.Key, answers.Value);
                        foreach (string rightAnswer in answers.Key)
                        {
                            Console.WriteLine(rightAnswer);
                        }

                        foreach (bool rightIndex in answers.Value)
                        {
                            Console.WriteLine(rightIndex);
                        }

                        Console.WriteLine();

                        string choice;
                        Console.WriteLine("Enter your choice: ");
                        choice = Console.ReadLine();



                        if (goGocorrectAnswer[question.Key][choice])
                        {
                            Console.WriteLine("Correct answer!");
                        }

                        else
                        {
                            Console.WriteLine("Wrong answer!");
                        }

                        Console.WriteLine();
                        
                    }



                }
            }
            
            
            catch(Exception e)
            {
                Console.WriteLine("Wrong answer!");
                goto tryLabel;

            }
           

        }

       

        public static void shuffleAnswers(List<string> rightAnswer , List<bool> rightIndex)
        {
            Random randomAnswer = new Random();
            for (int i = 0; i < rightAnswer.Count; i++)
            {
                swapAnswers(rightAnswer, rightIndex ,i, randomAnswer.Next(i, rightAnswer.Count));
            }

         /*   for(int i=0; i<rightIndex.Count; i++)
            {
                swapAnswers(rightAnswer, rightIndex,i, randomAnswer.Next(i, rightIndex.Count));
            }*/
        }


        public static void swapAnswers(List<string> rightAnswer, List<bool> rightIndex, int a, int b)
        {
            
            
            // List temp = answers[answers.IndexOf(answers[a])];
            // answers.IndexOf(answers[a]) = answers.IndexOf(answers[b]);
            //  (answers.IndexOf(answers[b]) = temp;
            //    answers[answers.IndexOf(answers[a])] = answers[answers.IndexOf(answers[b])];
            //  answers[answers.IndexOf(answers[b])] = temp;


            var temp = rightAnswer[a];
            rightAnswer[a] = rightAnswer[b];
            rightAnswer[b] = temp;

            var temp2 = rightIndex[a];
            rightIndex[a] = rightIndex[b];
            rightIndex[b] = temp2;

        }

    }
}

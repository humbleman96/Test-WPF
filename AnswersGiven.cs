using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
   public class AnswersGiven
    {
        private static Dictionary<Question, Dictionary<List<Answer>, List<bool>>> correctAnswers;


        private static Dictionary<List<Answer>, List<bool>> correctAnswersQ1;
        private static Dictionary<List<Answer>, List<bool>> correctAnswersQ2;
        private static Dictionary<List<Answer>, List<bool>> correctAnswersQ3;


        private static Dictionary<string, bool> getCorrectAnswerFromQuestion = new Dictionary<string, bool>();
        private static Dictionary<Question, Dictionary<string, bool>> goGocorrectAnswer = new Dictionary<Question, Dictionary<string, bool>>();
        private static List<string> allCorrectAnswers = new List<string>();
       


        private static List<Answer> answersQ1 = new List<Answer>();
        private static List<Answer> answersQ2 = new List<Answer>();
        private static List<Answer> answersQ3 = new List<Answer>();

        private static List<bool> boolsCorrectAnswerQ1 = new List<bool>();
        private static List<bool> boolsCorrectAnswerQ2 = new List<bool>();
        private static List<bool> boolsCorrectAnswerQ3 = new List<bool>();


        public static Dictionary<Question, Dictionary<List<Answer> , List<bool>>> CorrectAnswers
        {
            get
            {
             
                return correctAnswers;
            }

            set { }
        }

        public static Dictionary<List<Answer> , List<bool>> CorrectAnswersToQ1
        {
            get
            {
            
                return correctAnswersQ1;
            }

            set { }
        }

        public static Dictionary<List<Answer>, List<bool>> CorrectAnswersToQ2
        {
            get
            {
              
                return correctAnswersQ2;
            }

            set { }
        }

        public static Dictionary<List<Answer>, List<bool>> CorrectAnswersToQ3
        {
            get
            {
              
                return correctAnswersQ3;
            }

            set { }
        }

        public static Dictionary<string, bool> getCorrectAnswerFromQuestions
        {
            get
            {
              
                return getCorrectAnswerFromQuestion;
            }

            set { }
        }

        public static Dictionary<Question, Dictionary<string, bool>> goGocorrectAnswers
        {
            get
            {
              
                return goGocorrectAnswer;
            }

            set { }
        }

        public static List<string> AllCorrectAnswers
        {
            get
            {
              
                return allCorrectAnswers;
            }

            set { }
        }


        public static List<Answer> AnswersQ1
        {
            get
            {
              
                return answersQ1;
            }
            set { }
        }

        public static List<Answer> AnswersQ2
        {
            get
            {
            
                return answersQ2;
            }
            set { }
        }

        public static List<Answer> AnswersQ3
        {
            get
            {
              
                return answersQ3;
            }
            set { }
        }


        public static List<bool> BoolsCorrectAnswerQ1
        {
            get
            {
             
                return boolsCorrectAnswerQ1;
            }

            set { }
        }

        public static List<bool> BoolsCorrectAnswerQ2
        {
            get
            {
             
                return boolsCorrectAnswerQ2;
            }

            set { }
        }

        public static List<bool> BoolsCorrectAnswerQ3
        {
            get
            {
             
                return boolsCorrectAnswerQ3;
            }

            set { }
        }





        public static void setAnswers()
        {

            correctAnswers = new Dictionary<Question, Dictionary<List<Answer>, List<bool>>>();

            correctAnswersQ1 = new Dictionary<List<Answer>, List<bool>>();
            correctAnswersQ2 = new Dictionary<List<Answer>, List<bool>>();
            correctAnswersQ3 = new Dictionary<List<Answer>, List<bool>>();

            goGocorrectAnswer = new Dictionary<Question, Dictionary<string, bool>>();

            answersQ1.Add(new Answer("1"));
            answersQ1.Add(new Answer("2"));
            answersQ1.Add(new Answer("3"));
            answersQ1.Add(new Answer("4"));

            answersQ2.Add(new Answer("125"));
            answersQ2.Add(new Answer("625"));
            answersQ2.Add(new Answer("425"));
            answersQ2.Add(new Answer("225"));

            answersQ3.Add(new Answer("3"));
            answersQ3.Add(new Answer("6"));
            answersQ3.Add(new Answer("1"));
            answersQ3.Add(new Answer("2"));

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





            correctAnswers.Add(QuestionData.testQuestions[0], correctAnswersQ1);
            correctAnswers.Add(QuestionData.testQuestions[1], correctAnswersQ2);
            correctAnswers.Add(QuestionData.testQuestions[2], correctAnswersQ3);





            foreach (string correctAnswer in allCorrectAnswers)
            {
                getCorrectAnswerFromQuestion.Add(correctAnswer, true);
            }

            /* 
             foreach(KeyValuePair<string, bool> correct in getCorrectAnswerFromQuestion)
             {
                 Console.WriteLine(correct.Key + " " + correct.Value);
             }
             */

            // Console.WriteLine(getCorrectAnswerFromQuestion.Count);

            for (int i = 0; i < getCorrectAnswerFromQuestion.Count; i++)
            {
                //  foreach (KeyValuePair<string, bool> answer in getCorrectAnswerFromQuestion) 
                //    {

                goGocorrectAnswer.Add(QuestionData.testQuestions[i], new Dictionary<string, bool>());
                goGocorrectAnswer[QuestionData.testQuestions[i]].Add(getCorrectAnswerFromQuestion.ElementAt(i).Key, getCorrectAnswerFromQuestion.ElementAt(i).Value);
                //  }

            }



          /*  for (int i = 0; i < getCorrectAnswerFromQuestion.Count; i++)
            {
                Console.WriteLine(QuestionData.testQuestions[i].question);
                Console.WriteLine(getCorrectAnswerFromQuestion.ElementAt(i).Key);
                Console.WriteLine(getCorrectAnswerFromQuestion.ElementAt(i).Value);

            }*/

        
               
            
            

            /*
               tryLabel:
            try
            {
               
                foreach (KeyValuePair<Question, Dictionary<List<Answer>, List<bool>>> question in correctAnswers)
                {
                    Console.WriteLine(question.Key.question);
                    

                    foreach (KeyValuePair<List<Answer>, List<bool>> answers in question.Value)
                    {
                        shuffleAnswers(answers.Key, answers.Value);
                        foreach (Answer rightAnswer in answers.Key)
                        {
                            Console.WriteLine(rightAnswer.answer);
                        }

                        foreach (bool rightIndex in answers.Value)
                        {
                            Console.WriteLine(rightIndex);
                        }

                        Console.WriteLine();


                        
                        string choice;
                        Console.WriteLine("Enter your choice: ");
                        choice = Console.ReadLine();
                        Answer ans = new Answer(choice);
                        



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
           */

        }

       

        public static void shuffleAnswers(List<Answer> rightAnswer , List<bool> rightIndex)
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


        public static void swapAnswers(List<Answer> rightAnswer, List<bool> rightIndex, int a, int b)
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

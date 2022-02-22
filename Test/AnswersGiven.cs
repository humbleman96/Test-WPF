using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class AnswersGiven
    {
        private static Dictionary<Question, Dictionary<List<Answer>, List<bool>>> correctAnswers;
        private static Dictionary<List<Answer>, List<bool>> correctAnswersQ1;
        private static Dictionary<List<Answer>, List<bool>> correctAnswersQ2;
        private static Dictionary<List<Answer>, List<bool>> correctAnswersQ3;
        private static Dictionary<List<Answer>, List<bool>> correctAnswersQ4;
        private static Dictionary<List<Answer>, List<bool>> correctAnswersQ5;
        private static Dictionary<List<Answer>, List<bool>> correctAnswersQ6;
        private static Dictionary<List<Answer>, List<bool>> correctAnswersQ7;
        private static Dictionary<List<Answer>, List<bool>> correctAnswersQ8;
        private static Dictionary<List<Answer>, List<bool>> correctAnswersQ9;
        private static Dictionary<List<Answer>, List<bool>> correctAnswersQ10;
        private static List<bool> boolsCorrectAnswerQ1 = new List<bool>();
        private static List<bool> boolsCorrectAnswerQ2 = new List<bool>();
        private static List<bool> boolsCorrectAnswerQ3 = new List<bool>();
        private static List<bool> boolsCorrectAnswerQ4 = new List<bool>();
        private static List<bool> boolsCorrectAnswerQ5 = new List<bool>();
        private static List<bool> boolsCorrectAnswerQ6 = new List<bool>();
        private static List<bool> boolsCorrectAnswerQ7 = new List<bool>();
        private static List<bool> boolsCorrectAnswerQ8 = new List<bool>();
        private static List<bool> boolsCorrectAnswerQ9 = new List<bool>();
        private static List<bool> boolsCorrectAnswerQ10 = new List<bool>();
        private static List<Answer> answersQ1 = new List<Answer>();
        private static List<Answer> answersQ2 = new List<Answer>();
        private static List<Answer> answersQ3 = new List<Answer>();
        private static List<Answer> answersQ4 = new List<Answer>();
        private static List<Answer> answersQ5 = new List<Answer>();
        private static List<Answer> answersQ6 = new List<Answer>();
        private static List<Answer> answersQ7 = new List<Answer>();
        private static List<Answer> answersQ8 = new List<Answer>();
        private static List<Answer> answersQ9 = new List<Answer>();
        private static List<Answer> answersQ10 = new List<Answer>();
        private static Dictionary<Question, Dictionary<string, bool>> goGocorrectAnswer = new Dictionary<Question, Dictionary<string, bool>>();
        private static Dictionary<string, bool> getCorrectAnswerFromQuestion = new Dictionary<string, bool>();
        private static List<string> allCorrectAnswers = new List<string>();

        public static Dictionary<Question, Dictionary<List<Answer>, List<bool>>> CorrectAnswers
        {
            get
            {
                return correctAnswers;
            }
            set { }
        }

        public static Dictionary<List<Answer>, List<bool>> CorrectAnswersToQ1
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

        public static Dictionary<string, bool> GetCorrectAnswerFromQuestions
        {
            get
            {
                return getCorrectAnswerFromQuestion;
            }
            set { }
        }

        public static Dictionary<Question, Dictionary<string, bool>> GoGocorrectAnswers
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

        public static void SetAnswers()
        {
            correctAnswers = new Dictionary<Question, Dictionary<List<Answer>, List<bool>>>();
            correctAnswersQ1 = new Dictionary<List<Answer>, List<bool>>();
            correctAnswersQ2 = new Dictionary<List<Answer>, List<bool>>();
            correctAnswersQ3 = new Dictionary<List<Answer>, List<bool>>();
            correctAnswersQ4 = new Dictionary<List<Answer>, List<bool>>();
            correctAnswersQ5 = new Dictionary<List<Answer>, List<bool>>();
            correctAnswersQ6 = new Dictionary<List<Answer>, List<bool>>();
            correctAnswersQ7 = new Dictionary<List<Answer>, List<bool>>();
            correctAnswersQ8 = new Dictionary<List<Answer>, List<bool>>();
            correctAnswersQ9 = new Dictionary<List<Answer>, List<bool>>();
            correctAnswersQ10 = new Dictionary<List<Answer>, List<bool>>();

            goGocorrectAnswer = new Dictionary<Question, Dictionary<string, bool>>();

            answersQ1.Add(new Answer("4"));
            answersQ1.Add(new Answer("-4"));
            answersQ1.Add(new Answer("-8"));
            answersQ1.Add(new Answer("8"));

            answersQ2.Add(new Answer("14 и 16"));
            answersQ2.Add(new Answer("-14 и -16"));
            answersQ2.Add(new Answer("14 и -16"));
            answersQ2.Add(new Answer("-14 и 16"));

            answersQ3.Add(new Answer("5 и -1"));
            answersQ3.Add(new Answer("-5 и 1"));
            answersQ3.Add(new Answer("1 и 5"));
            answersQ3.Add(new Answer("-1 и -5"));

            answersQ4.Add(new Answer("2"));
            answersQ4.Add(new Answer("-2"));
            answersQ4.Add(new Answer("0"));
            answersQ4.Add(new Answer("няма решение"));

            answersQ5.Add(new Answer("2"));
            answersQ5.Add(new Answer("-2"));
            answersQ5.Add(new Answer("4"));
            answersQ5.Add(new Answer("-4"));

            answersQ6.Add(new Answer("125"));
            answersQ6.Add(new Answer("225"));
            answersQ6.Add(new Answer("425"));
            answersQ6.Add(new Answer("625"));

            answersQ7.Add(new Answer("15"));
            answersQ7.Add(new Answer("60"));
            answersQ7.Add(new Answer("30"));
            answersQ7.Add(new Answer("54"));

            answersQ8.Add(new Answer("26"));
            answersQ8.Add(new Answer("40"));
            answersQ8.Add(new Answer("52"));
            answersQ8.Add(new Answer("13"));

            answersQ9.Add(new Answer("6"));
            answersQ9.Add(new Answer("12"));
            answersQ9.Add(new Answer("10"));
            answersQ9.Add(new Answer("20"));

            answersQ10.Add(new Answer("16"));
            answersQ10.Add(new Answer("12"));
            answersQ10.Add(new Answer("20"));
            answersQ10.Add(new Answer("18"));

            boolsCorrectAnswerQ1.Add(false);
            boolsCorrectAnswerQ1.Add(false);
            boolsCorrectAnswerQ1.Add(false);
            boolsCorrectAnswerQ1.Add(true);

            boolsCorrectAnswerQ2.Add(false);
            boolsCorrectAnswerQ2.Add(false);
            boolsCorrectAnswerQ2.Add(true);
            boolsCorrectAnswerQ2.Add(false);

            boolsCorrectAnswerQ3.Add(true);
            boolsCorrectAnswerQ3.Add(false);
            boolsCorrectAnswerQ3.Add(false);
            boolsCorrectAnswerQ3.Add(false);

            boolsCorrectAnswerQ4.Add(false);
            boolsCorrectAnswerQ4.Add(false);
            boolsCorrectAnswerQ4.Add(false);
            boolsCorrectAnswerQ4.Add(true);

            boolsCorrectAnswerQ5.Add(false);
            boolsCorrectAnswerQ5.Add(true);
            boolsCorrectAnswerQ5.Add(false);
            boolsCorrectAnswerQ5.Add(false);

            boolsCorrectAnswerQ6.Add(false);
            boolsCorrectAnswerQ6.Add(false);
            boolsCorrectAnswerQ6.Add(false);
            boolsCorrectAnswerQ6.Add(true);

            boolsCorrectAnswerQ7.Add(false);
            boolsCorrectAnswerQ7.Add(false);
            boolsCorrectAnswerQ7.Add(true);
            boolsCorrectAnswerQ7.Add(false);

            boolsCorrectAnswerQ8.Add(false);
            boolsCorrectAnswerQ8.Add(true);
            boolsCorrectAnswerQ8.Add(false);
            boolsCorrectAnswerQ8.Add(false);

            boolsCorrectAnswerQ9.Add(true);
            boolsCorrectAnswerQ9.Add(false);
            boolsCorrectAnswerQ9.Add(false);
            boolsCorrectAnswerQ9.Add(false);

            boolsCorrectAnswerQ10.Add(false);
            boolsCorrectAnswerQ10.Add(true);
            boolsCorrectAnswerQ10.Add(false);
            boolsCorrectAnswerQ10.Add(false);

            correctAnswersQ1.Add(answersQ1, boolsCorrectAnswerQ1);
            correctAnswersQ2.Add(answersQ2, boolsCorrectAnswerQ2);
            correctAnswersQ3.Add(answersQ3, boolsCorrectAnswerQ3);
            correctAnswersQ4.Add(answersQ4, boolsCorrectAnswerQ4);
            correctAnswersQ5.Add(answersQ5, boolsCorrectAnswerQ5);
            correctAnswersQ6.Add(answersQ6, boolsCorrectAnswerQ6);
            correctAnswersQ7.Add(answersQ7, boolsCorrectAnswerQ7);
            correctAnswersQ8.Add(answersQ8, boolsCorrectAnswerQ8);
            correctAnswersQ9.Add(answersQ9, boolsCorrectAnswerQ9);
            correctAnswersQ10.Add(answersQ10, boolsCorrectAnswerQ10);

            correctAnswers.Add(QuestionData.TestQuestions[0], correctAnswersQ1);
            correctAnswers.Add(QuestionData.TestQuestions[1], correctAnswersQ2);
            correctAnswers.Add(QuestionData.TestQuestions[2], correctAnswersQ3);
            correctAnswers.Add(QuestionData.TestQuestions[3], correctAnswersQ4);
            correctAnswers.Add(QuestionData.TestQuestions[4], correctAnswersQ5);
            correctAnswers.Add(QuestionData.TestQuestions[5], correctAnswersQ6);
            correctAnswers.Add(QuestionData.TestQuestions[6], correctAnswersQ7);
            correctAnswers.Add(QuestionData.TestQuestions[7], correctAnswersQ8);
            correctAnswers.Add(QuestionData.TestQuestions[8], correctAnswersQ9);
            correctAnswers.Add(QuestionData.TestQuestions[9], correctAnswersQ10);

            allCorrectAnswers.Add("8");
            allCorrectAnswers.Add("14 и -16");
            allCorrectAnswers.Add("5 и -1");
            allCorrectAnswers.Add("няма решение");
            allCorrectAnswers.Add("-2");
            allCorrectAnswers.Add("625");
            allCorrectAnswers.Add("30");
            allCorrectAnswers.Add("40");
            allCorrectAnswers.Add("6");
            allCorrectAnswers.Add("12");

            foreach (string correctAnswer in allCorrectAnswers)
            {
                getCorrectAnswerFromQuestion.Add(correctAnswer, true);
            }

            for (int i = 0; i < getCorrectAnswerFromQuestion.Count; i++)
            {
                //  foreach (KeyValuePair<string, bool> answer in getCorrectAnswerFromQuestion) 
                //    {
                goGocorrectAnswer.Add(QuestionData.TestQuestions[i], new Dictionary<string, bool>());
                goGocorrectAnswer[QuestionData.TestQuestions[i]].Add(getCorrectAnswerFromQuestion.ElementAt(i).Key, getCorrectAnswerFromQuestion.ElementAt(i).Value);
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

        public static void ShuffleAnswers(List<Answer> rightAnswer, List<bool> rightIndex)
        {
            Random randomAnswer = new Random();
            for (int i = 0; i < rightAnswer.Count; i++)
            {
                SwapAnswers(rightAnswer, rightIndex, i, randomAnswer.Next(i, rightAnswer.Count));
            }
            /*   for(int i=0; i<rightIndex.Count; i++)
               {
                   swapAnswers(rightAnswer, rightIndex,i, randomAnswer.Next(i, rightIndex.Count));
               }*/
        }

        public static void SwapAnswers(List<Answer> rightAnswer, List<bool> rightIndex, int a, int b)
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

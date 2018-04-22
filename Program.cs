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
              AnswersGiven.setAnswers();
          
            tryLabel:
            try
            {

                foreach (KeyValuePair<Question, Dictionary<List<Answer>, List<bool>>> question in AnswersGiven.CorrectAnswers)
                {
                    Console.WriteLine(question.Key.question);


                    foreach (KeyValuePair<List<Answer>, List<bool>> answers in question.Value)
                    {
                        AnswersGiven.shuffleAnswers(answers.Key, answers.Value);
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
                       // Answer ans = new Answer(choice);




                        if (AnswersGiven.goGocorrectAnswers[question.Key][choice])
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


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Wrong answer!");
                goto tryLabel;

            }

    
        }

    }
      
    }


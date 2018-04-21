using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Test;

namespace TestSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        private static int counter = 0;
        private static int correctAnswersCounter = 0;
     //   private static bool previousCallFucn = false;
     //   private static bool nextCallFunc = false;
        private static int radioButtonCounter = 0;

        private static int time = 600;
        private static DispatcherTimer timer = new DispatcherTimer();    
      
        
       
       

        public MainWindow()
        {
            try
            {
              
                QuestionData.testQuestionData();
                AnswersGiven.setAnswers();
                InitializeComponent();



                foreach (KeyValuePair<Question, Dictionary<List<Answer>, List<bool>>> question in AnswersGiven.CorrectAnswers)
                {
                    foreach (KeyValuePair<List<Answer>, List<bool>> answers in question.Value)
                    {
                        AnswersGiven.shuffleAnswers(answers.Key, answers.Value);
                    }

                }


                initializeItems();
                btnPrevious.IsEnabled = false;



                timer.Interval = new TimeSpan(0, 0, 1);
                timer.Tick += Timer_Tick;

                timer.Start();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time--;

            if ((time < 550 && time >= 540) || (time<490 && time>=480) || (time < 430 && time >= 420) || (time < 370 && time >= 360) || (time < 310 && time >= 300)
                || (time < 250 && time >= 240) || (time < 190 && time >= 180) || (time < 130 && time >= 120 ) || (time < 70 && time > 60))
            {
                lblTimer.Content = string.Format("{0}:0{1}", time / 60, time % 60);
            }


            else
            {
                lblTimer.Content = string.Format("{0}:{1}", time / 60, time % 60);
            }
            
            if(time<60)
            {
                lblTimer.Content = string.Format("{0}", time % 60);
            }
           
            if (time == 0)
            {
                timer.Stop();
                MessageBox.Show("Времето свърши !");
                finalResults();
            }
            
        }

        private void finalResults()
        {
            Grid[] grid = new Grid[10];
            grid[0] = answers1;
            grid[1] = answers2;
            grid[2] = answers3;
            grid[3] = answers4;
            grid[4] = answers5;
            grid[5] = answers6;
            grid[6] = answers7;
            grid[7] = answers8;
            grid[8] = answers9;
            grid[9] = answers10;
            

            for (int i = 0; i < grid.Length; i++)
            {
                foreach (DependencyObject item in grid[i].Children)
                {
                    if (item is RadioButton)
                    {
                        ((RadioButton)item).IsEnabled = false;
                    }
                }
            }

            timer.Stop();

            MessageBox.Show("Поздравления! Вие имате" + " " + correctAnswersCounter + "/" + QuestionData.testQuestions.Count + " верни");
            if(correctAnswersCounter < 6)
            {
                MessageBox.Show("Вашата оценка е Слаб(2)");
            }

            else if (correctAnswersCounter == 6)
            {
                MessageBox.Show("Вашата оценка е Среден(3)");
            }
            else if (correctAnswersCounter == 7)
            {
                MessageBox.Show("Вашата оценка е Добър(4)");
            }
            else if (correctAnswersCounter == 8)
            {
                MessageBox.Show("Вашата оценка е Много добър(5)");
            }
            else
            {
                MessageBox.Show("Вашата оценка е Отличен(6)");
            }

        }

        private void initializeItems()
        {
         
            RadioButton[] radio = new RadioButton[4];

            radio[0] = radioBtnOpt1;
            radio[1] = radioBtnOpt2;
            radio[2] = radioBtnOpt3;
            radio[3] = radioBtnOpt4;


            lblQuestion.Content = "Въпрос " + QuestionData.testQuestions[counter].numOfQuestion;
            lblQuestionText.Content = QuestionData.testQuestions[counter].question;

            foreach (KeyValuePair<Question, Dictionary<List<Answer>, List<bool>>> question in AnswersGiven.CorrectAnswers)
            {
                foreach (KeyValuePair<List<Answer>, List<bool>> answer in AnswersGiven.CorrectAnswers[QuestionData.testQuestions[counter]])
                {
                    //AnswersGiven.shuffleAnswers(answer.Key, answer.Value);
                    for (int i = 0; i < answer.Key.Count; i++)
                    {    
                    //    radio[i].GroupName = answerRadio.Name + " " + QuestionData.testQuestions[counter].numOfQuestion;
                        radio[i].Content = answer.Key.ElementAt(i).answer;
                    }
                }

                break;


            }

            
          
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Grid[] grid = new Grid[10];
            grid[0] = answers1;
            grid[1] = answers2;
            grid[2] = answers3;
            grid[3] = answers4;
            grid[4] = answers5;
            grid[5] = answers6;
            grid[6] = answers7;
            grid[7] = answers8;
            grid[8] = answers9;
            grid[9] = answers10;

           

            btnPrevious.IsEnabled = true;

          


            grid[counter].Visibility = Visibility.Hidden;

            counter++;

            /*  RadioButton[] radio = new RadioButton[4];

              radio[0] = radioBtnOpt1;
              radio[1] = radioBtnOpt2;
              radio[2] = radioBtnOpt3;
              radio[3] = radioBtnOpt4;*/

            lblQuestion.Content = "Въпрос " + QuestionData.testQuestions[counter].numOfQuestion;
            lblQuestionText.Content = QuestionData.testQuestions[counter].question;
           

          
                RadioButton[] radio = new RadioButton[4];               
                grid[counter].Name = "answers" + QuestionData.testQuestions[counter].numOfQuestion;
                grid[counter].Visibility = Visibility.Visible;
                foreach(DependencyObject item in grid[counter].Children)
                {
                    radio[radioButtonCounter] = (RadioButton)item;
                    radioButtonCounter++;
                }

                radioButtonCounter = 0;

                foreach (KeyValuePair<Question, Dictionary<List<Answer>, List<bool>>> question in AnswersGiven.CorrectAnswers)
                {
                    foreach (KeyValuePair<List<Answer>, List<bool>> answer in AnswersGiven.CorrectAnswers[QuestionData.testQuestions[counter]])
                    {
                        //  AnswersGiven.shuffleAnswers(answer.Key, answer.Value);
                        for (int j = 0; j< answer.Key.Count; j++)
                        {
                            //     answerRadio.Name = answerRadio.Name + " " + QuestionData.testQuestions[counter].numOfQuestion;
                            //   radio[i].GroupName = answerRadio.Name + " " + QuestionData.testQuestions[counter].numOfQuestion;

                            radio[j].Content = answer.Key.ElementAt(j).answer;
                        }
                    }


                    break;

                }

            if (counter == QuestionData.testQuestions.Count - 1)
            {
                // MessageBox.Show("Няма следващ въпрос");
            //    counter--;
                btnNext.IsEnabled = false;
            }


        }

        

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            btnNext.IsEnabled = true;

         

            Grid[] grid = new Grid[10];
            grid[0] = answers1;
            grid[1] = answers2;
            grid[2] = answers3;
            grid[3] = answers4;
            grid[4] = answers5;
            grid[5] = answers6;
            grid[6] = answers7;
            grid[7] = answers8;
            grid[8] = answers9;
            grid[9] = answers10;



        

            grid[counter].Visibility = Visibility.Hidden;

            counter--;

            /*   RadioButton[] radio = new RadioButton[40];

               radio[0] = radioBtnOpt1;
               radio[1] = radioBtnOpt2;
               radio[2] = radioBtnOpt3;
               radio[3] = radioBtnOpt4;
               */


            lblQuestion.Content = "Въпрос " + QuestionData.testQuestions[counter].numOfQuestion;
            lblQuestionText.Content = QuestionData.testQuestions[counter].question;


            RadioButton[] radio = new RadioButton[4];
            grid[counter].Name = "answers" + QuestionData.testQuestions[counter].numOfQuestion;
            grid[counter].Visibility = Visibility.Visible;
            foreach (DependencyObject item in grid[counter].Children)
            {
                radio[radioButtonCounter] = (RadioButton)item;
                radioButtonCounter++;
            }

            radioButtonCounter = 0;

            foreach (KeyValuePair<Question, Dictionary<List<Answer>, List<bool>>> question in AnswersGiven.CorrectAnswers)
            {
                foreach (KeyValuePair<List<Answer>, List<bool>> answer in AnswersGiven.CorrectAnswers[QuestionData.testQuestions[counter]])
                {
                    //  AnswersGiven.shuffleAnswers(answer.Key, answer.Value);
                    for (int j = 0; j < answer.Key.Count; j++)
                    {
                        //     answerRadio.Name = answerRadio.Name + " " + QuestionData.testQuestions[counter].numOfQuestion;
                        //   radio[i].GroupName = answerRadio.Name + " " + QuestionData.testQuestions[counter].numOfQuestion;

                        radio[j].Content = answer.Key.ElementAt(j).answer;
                    }
                }


                break;

            }

            if (counter == 0)
            {
                //  MessageBox.Show("Няма предишен въпрос");
              //  counter++;
                btnPrevious.IsEnabled = false;
            }


        }
      
    
        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            Grid[] grid = new Grid[10];
            grid[0] = answers1;
            grid[1] = answers2;
            grid[2] = answers3;
            grid[3] = answers4;
            grid[4] = answers5;
            grid[5] = answers6;
            grid[6] = answers7;
            grid[7] = answers8;
            grid[8] = answers9;
            grid[9] = answers10;

            for (int i = 0; i < grid.Length; i++)
            {
                foreach (DependencyObject item in grid[i].Children)
                {
                    if (item is RadioButton)
                    {
                        ((RadioButton)item).IsEnabled = false;
                    }
                }
            }
        

            timer.Stop();

            MessageBox.Show("Поздравления! Вие имате" + " " + correctAnswersCounter + "/" + QuestionData.testQuestions.Count + " верни");
            if (correctAnswersCounter < 6)
            {
                MessageBox.Show("Вашата оценка е Слаб(2)");
            }

            else if (correctAnswersCounter == 6)
            {
                MessageBox.Show("Вашата оценка е Среден(3)");
            }
            else if (correctAnswersCounter == 7)
            {
                MessageBox.Show("Вашата оценка е Добър(4)");
            }
            else if (correctAnswersCounter == 8)
            {
                MessageBox.Show("Вашата оценка е Много добър(5)");
            }
            else
            {
                MessageBox.Show("Вашата оценка е Отличен(6)");
            }
        }


        private void btnCheck_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radio = new RadioButton();
            radio = (RadioButton) sender;
       

            if (AnswersGiven.goGocorrectAnswers[QuestionData.testQuestions[counter]].ContainsKey(radio.Content.ToString()))
            {
                   if(!QuestionData.correctAnswered.Contains(QuestionData.testQuestions[counter]))
                    {
                        QuestionData.correctAnswered.Add(QuestionData.testQuestions[counter]);
                    }
                 //   MessageBox.Show("CongratZ bro, you got it right !");
                    correctAnswersCounter = QuestionData.correctAnswered.Count;
               
            }

            else
            {
                QuestionData.correctAnswered.Remove(QuestionData.testQuestions[counter]);
                correctAnswersCounter = QuestionData.correctAnswered.Count;
                
              //  MessageBox.Show("Sorry bro, try again !");
            }


         
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Наистина ли искате да излезете от теста ?", "Изход", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Current.Shutdown();
            }
        }
    }
    }


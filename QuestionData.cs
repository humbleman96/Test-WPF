using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
   public class QuestionData
    {
        private static List<Question> questions = new List<Question>();

        public static List<Question> correctAnswered = new List<Question>();
        public static List<Question> testQuestions
        {
            get
            {
              
                return questions;
            }
            set
            {

            }


        }


        public static void testQuestionData()
        {
            

            questions.Add(new Question(1, "Решението на уравнението (x -3)(x + 4) - 2(3x - 2) = (x - 4)^2  е: ")); //8
            questions.Add(new Question(2, "Решенията на модулното уравнение |(x + 1)/3| = 5 са: ")); // 14 и -16
            questions.Add(new Question(3, "Решенията на квадратното уарвнение (x - 2)^2 - 9 = 0 са :")); // 5 и -1
            questions.Add(new Question(4, "Решенията на квадратното уравнение 3x^2 + 4x + 5 = 0 са:")); //няма решение 
            questions.Add(new Question(5, "Решенията на квадратното уравнение x^2 + 4x + 4 = 0 са: ")); // -2
            questions.Add(new Question(6, "На колко е равно лицето на квадрат със страна 25 ?")); // 625
            questions.Add(new Question(7, "На колко е равен периметърът на правоъгълник със страни 6 и 9 ?")); //30
            questions.Add(new Question(8, "На колко е равно лицето на правоъгълник със страни 5 и 8 ?")); // 40
            questions.Add(new Question(9, "На колко е равно лицето на правоъгълен триъгълник с катет 4 и хипотенуза 5 ?")); // 6
            questions.Add(new Question(10, "На колко е равен периметърът на правоъгълен триъгълник с катети 3 и 4 ?"));  //12
        }
    }
}

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
            

            questions.Add(new Question(1, "Колко страни има квадратът ?"));
            questions.Add(new Question(2, "Колко е 25^2 ?"));
            questions.Add(new Question(3, "2x+6 = 12   x=?"));
            questions.Add(new Question(4, "На колко е равно лицето на правоъгълник със страни 5см и 8см ?"));
        }
    }
}

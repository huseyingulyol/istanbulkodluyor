using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_Inheritance
{
    public class Lesson
    {
        public DateTime LessonCreatedDate {  get; set; }

        public void Listen()
        {
            Console.WriteLine("Listening...");
        }
    }

    public class Mathematics : Lesson
    {
        public void PrintMathQuestion()
        {
            Console.WriteLine("f(x) = 2x+1  ise x=?");
        }
    }

    public class Science : Lesson
    {
        public void PrintScienceQuestion()
        {
            Console.WriteLine("Kalsiyum elementinin sembolü nedir?");
        }
    }
    public class English : Lesson
    {
        public void PrintEnglishQuestion()
        {
            Console.WriteLine("'What is the boiling point of water in Celsius?' What is the answer to the question?");
        }
    }
}

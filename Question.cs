using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TriviaTrek
{
    internal class Questions
    {
        public int ID { get; }
        public string Question { get; }
        public string Answer1 { get; }
        public string Answer2 { get; }
        public string Answer3 { get; }
        public string Answer4 { get; }
        public int correctAnswer { get; }
        public int Crux { get; }
        
        public Questions(int id, string question, string answer1, string answer2, string answer3, string answer4, int CorrectAnswer, int crux)
        {
            ID = id;
            Question = question;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
            correctAnswer = CorrectAnswer;
            Crux = crux;
        }
    }
}

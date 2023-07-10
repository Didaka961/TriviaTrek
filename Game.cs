using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Net.Http.Headers;
using System.Collections;

namespace TriviaTrek
{
    class Game
    {
        public int[] playerLocation;
        public string[] players;
        public int spaces = 51;
        public int currentPlayer = 0;
        static ArrayList questions = new ArrayList();
        public List<int> ask = new List<int>();
        public int count = 1;
        public string FilePath = "E:\\TriviaTrek\\Questions.txt";

        public Game()
        {
        }
        public void Setup() 
        {
            Console.WriteLine("Mоля въведете число от 2 до 4.");
            int playerAmount = int.Parse(Console.ReadLine());
            ReadQuestionsFromFile(FilePath);
            while (true)
            {
                if (playerAmount > 1 && playerAmount < 5)
                {
                    players = new string[playerAmount];
                    for (int i = 0; i < playerAmount; i++)
                    {
                        Console.WriteLine($"Моля въведете име на играч номер {i+1}");
                        players[i] = Console.ReadLine();
                    }
                    playerLocation = new int[playerAmount];
                    break;
                }
                else if (playerAmount < 2)
                {
                    Console.WriteLine("Твърде малко играчи моля въведете число от 2 до 4.");
                    playerAmount = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Твърде много играчи моля въведете число от 2 до 4.");
                    playerAmount = int.Parse(Console.ReadLine());
                }   
            }
        }

        public void Move()
        {
            Random random = new Random();
            int roll = random.Next(1,6);
            Console.WriteLine($"Падна ти се {roll}");
            playerLocation[currentPlayer] += roll;

            for (int i = 0; i < playerLocation.Length; i++)
            {
                Console.Write(playerLocation[i] + " ");
                for (int j = 0; j < playerLocation[i]; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine(" " + players[i]);
                
            }
            if (roll<3)
            {
                Random rand = new Random();
                int num = rand.Next(100);
                int a;
                if (num==25)
                {
                    a = 0;
                }
                else if (num>25&&num<51)
                {
                    a = 1;
                }
                else if (num>50 &&num<76)
                {
                    a = 2;
                }
                else 
                { 
                    a = 3;
                }
                Console.WriteLine(questions[ask[a]]);
            }
        }

        public void ReadQuestionsFromFile(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("utf-8")))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] questionData = line.Split(',');
                    if (questionData.Length==8)
                    {
                        int id = int.Parse(questionData[0]);
                        string question = questionData[1];
                        string answer1 = questionData[2];
                        string answer2 = questionData[3];
                        string answer3 = questionData[4];
                        string answer4 = questionData[5];
                        int correctAnswer = int.Parse(questionData[6]);
                        int crux = int.Parse(questionData[7]);

                        Questions question1 = new Questions(id, question, answer1, answer2, answer3, answer4, correctAnswer, crux);
                        questions.Add((int)question1.ID);
                        questions.Add(question1.Question);
                        questions.Add(question1.Answer1);
                        questions.Add (question1.Answer2);
                        questions.Add(question1.Answer3);
                        questions.Add(question1.Answer4);
                        questions.Add((int)correctAnswer);
                        questions.Add((int)crux);
                        ask.Add(count);
                        count += 8;
                    }
                }
            }
        }
        
    }
}

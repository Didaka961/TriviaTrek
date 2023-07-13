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
        public int spaces = 50;
        public int currentPlayer = 0;
        static ArrayList questions = new ArrayList();
        public List<int> ask = new List<int>();
        public int count = 1;
        public int win;
        public string FilePath = "..\\..\\Questions.txt";

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
                        Console.WriteLine($"Моля въведете име на играч номер {i + 1}");
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
            int roll = random.Next(1, 6);
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
            if (playerLocation[currentPlayer] < 50)
            {
                int a;
                if (roll < 3)
                {
                    Random rand = new Random();
                    int num = rand.Next(10000);
                    if (num <= 1000)
                    {
                        a = 0;
                    }
                    else if (num > 1000 && num <= 2000)
                    {
                        a = 1;
                    }
                    else if (num > 2000 && num <= 3000)
                    {
                        a = 2;
                    }
                    else if (num > 3000 && num <= 4000)
                    {
                        a = 3;
                    }
                    else if (num > 4000 && num <= 5000)
                    {
                        a = 4;
                    }
                    else if (num > 5000 && num <= 6000)
                    {
                        a = 5;
                    }
                    else if (num > 6000 && num <= 7000)
                    {
                        a = 6;
                    }
                    else if (num > 7000 && num <= 8000)
                    {
                        a = 7;
                    }
                    else if (num > 8000 && num <= 9000)
                    {
                        a = 8;
                    }
                    else
                    {
                        a = 9;
                    }
                    Console.WriteLine(questions[ask[a]] + "\n1) " + questions[ask[a] + 1] + "\n2) " + questions[ask[a] + 2] + "\n3) " + questions[ask[a] + 3] + "\n4) " + questions[ask[a] + 4]);
                    string answer = Console.ReadLine();
                    if (answer == questions[ask[a] + 5].ToString())
                    {
                        Console.WriteLine("Правилно! Пак си ти на ред");
                    }
                    else
                    {
                        if (currentPlayer < players.Length - 1)
                        {
                            currentPlayer++;
                        }
                        else
                        {
                            currentPlayer = 0;
                        }
                        Console.WriteLine($"Грешно! Верния отговор е номер {questions[ask[a] + 5]} сега е {players[currentPlayer]} на ред");
                        roll = 7;
                    }

                }
                else if (roll < 5)
                {
                    Random rand = new Random();
                    int num = rand.Next(10000);
                    if (num <= 1000)
                    {
                        a = 10;
                    }
                    else if (num > 1000 && num <= 2000)
                    {
                        a = 11;
                    }
                    else if (num > 2000 && num <= 3000)
                    {
                        a = 12;
                    }
                    else if (num > 3000 && num <= 4000)
                    {
                        a = 13;
                    }
                    else if (num > 4000 && num <= 5000)
                    {
                        a = 14;
                    }
                    else if (num > 5000 && num <= 6000)
                    {
                        a = 15;
                    }
                    else if (num > 6000 && num <= 7000)
                    {
                        a = 16;
                    }
                    else if (num > 7000 && num <= 8000)
                    {
                        a = 17;
                    }
                    else if (num > 8000 && num <= 9000)
                    {
                        a = 18;
                    }
                    else
                    {
                        a = 19;
                    }
                    Console.WriteLine(questions[ask[a]] + "\n1) " + questions[ask[a] + 1] + "\n2) " + questions[ask[a] + 2] + "\n3) " + questions[ask[a] + 3] + "\n4) " + questions[ask[a] + 4]);
                    string answer = Console.ReadLine();
                    if (answer == questions[ask[a] + 5].ToString())
                    {
                        Console.WriteLine("Правилно! Пак си ти на ред");
                    }
                    else
                    {
                        if (currentPlayer < players.Length - 1)
                        {
                            currentPlayer++;
                        }
                        else
                        {
                            currentPlayer = 0;
                        }
                        Console.WriteLine($"Грешно! Верния отговор е номер {questions[ask[a] + 5]} сега е {players[currentPlayer]} на ред");
                        roll = 7;
                    }

                }
                else if (roll <= 6)
                {
                    Random rand = new Random();
                    int num = rand.Next(10000);
                    if (num <= 1000)
                    {
                        a = 20;
                    }
                    else if (num > 1000 && num <= 2000)
                    {
                        a = 21;
                    }
                    else if (num > 2000 && num <= 3000)
                    {
                        a = 22;
                    }
                    else if (num > 3000 && num <= 4000)
                    {
                        a = 23;
                    }
                    else if (num > 4000 && num <= 5000)
                    {
                        a = 24;
                    }
                    else if (num > 5000 && num <= 6000)
                    {
                        a = 25;
                    }
                    else if (num > 6000 && num <= 7000)
                    {
                        a = 26;
                    }
                    else if (num > 7000 && num <= 8000)
                    {
                        a = 27;
                    }
                    else if (num > 8000 && num <= 9000)
                    {
                        a = 28;
                    }
                    else
                    {
                        a = 29;
                    }
                    Console.WriteLine(questions[ask[a]] + "\n1) " + questions[ask[a] + 1] + "\n2) " + questions[ask[a] + 2] + "\n3) " + questions[ask[a] + 3] + "\n4) " + questions[ask[a] + 4]);
                    string answer = Console.ReadLine();
                    if (answer == questions[ask[a] + 5].ToString())
                    {
                        Console.WriteLine("Правилно! Пак си ти на ред");
                    }
                    else
                    {
                        if (currentPlayer < players.Length - 1)
                        {
                            currentPlayer++;
                        }
                        else
                        {
                            currentPlayer = 0;
                        }
                        Console.WriteLine($"Грешно! Верния отговор е номер {questions[ask[a] + 5]} сега е {players[currentPlayer]} на ред");
                        roll = 7;
                    }
                }
            }
            else
            {
                win = 50;
            }
        }


        public void ReadQuestionsFromFile(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("utf-8")))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] questionData = line.Split(';');
                    if (questionData.Length == 8)
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
                        questions.Add(question1.Answer2);
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
        class Questions
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
}

using QuizDasha.Entities;
using System;
using System.IO;

namespace QuizDasha.Services
{
    public class QuizReader : IQuizReader
    {
        public Quiz ReadQuiz(string fileName)
        {
            // Считать данные из файла.
            var data = File.ReadAllText(fileName);
        }
    }
}

using Prism.Commands;
using Prism.Mvvm;
using QuizDasha.Entities;
using QuizDasha.Services;
using System;
using System.IO;
using System.Windows.Input;
using System.Xml.Serialization;

namespace QuizDasha
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly QuizReader _quizReader;
        private Quiz _quiz;

        public MainWindowViewModel(QuizReader quizReader)
        {
            _quizReader = quizReader;

            ExitCommand = new DelegateCommand(DoExit);

            // Читаем данные опросника.
            Quiz = _quizReader.ReadQuiz("quiz.xml");
        }

        /// <summary>
        /// Данные вопросника.
        /// </summary>
        public Quiz Quiz
        {
            get { return _quiz; }
            set { SetProperty(ref _quiz, value); }
        }

        private void DoExit()
        {
            Environment.Exit(0);
        }

        public ICommand ExitCommand { get; }
    }
}

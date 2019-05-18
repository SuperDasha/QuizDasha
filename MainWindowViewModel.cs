using Prism.Commands;
using Prism.Mvvm;
using QuizDasha.Entities;
using QuizDasha.Services;
using System;
using System.Windows.Input;

namespace QuizDasha
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly QuizReader _quizReader;

        public MainWindowViewModel(QuizReader quizReader)
        {
            _quizReader = quizReader;

            ExitCommand = new DelegateCommand(DoExit);
            ShowResultCommand = new DelegateCommand(DoShowResult);

            // Читаем данные опросника.
            Quiz = _quizReader.ReadQuiz("quiz.xml");
            _сurrentQuestionId = 0;
            CurrentQuestion = Quiz.Questions[_сurrentQuestionId];
        }

        private Quiz _quiz;

        /// <summary>
        /// Данные опросника.
        /// </summary>
        public Quiz Quiz
        {
            get { return _quiz; }
            set { SetProperty(ref _quiz, value); }
        }

        private int _сurrentQuestionId;
        private Question _сurrentQuestion;

        /// <summary>
        /// Идентификатор текущего вопроса в списке вопросов опросника.
        /// </summary>
        public Question CurrentQuestion
        {
            get { return _сurrentQuestion; }
            set { SetProperty(ref _сurrentQuestion, value); }
        }

        private void DoExit()
        {
            Environment.Exit(0);
        }

        private void DoShowResult()
        {

        }

        public ICommand ExitCommand { get; }
        public ICommand ShowResultCommand { get; }
    }
}

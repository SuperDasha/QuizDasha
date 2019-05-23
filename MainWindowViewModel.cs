using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using QuizDasha.Entities;
using QuizDasha.Services;
using System;
using System.Windows.Input;

namespace QuizDasha
{
    public class MainWindowViewModel : ObservableObject
    {
        private readonly QuizReader _quizReader;

        public MainWindowViewModel(QuizReader quizReader)
        {
            _quizReader = quizReader;

            ExitCommand = new RelayCommand(DoExit);
            ShowResultCommand = new RelayCommand(DoShowResult);
            NextCommand = new RelayCommand(DoNext, CanDoNext);
            PrevCommand = new RelayCommand(DoPrev, CanDoPrev);

            // Читаем данные опросника.
            Quiz = _quizReader.ReadQuiz("quiz.xml");
            _questionIndex = 0;
            ObjectToDisplay = Quiz.Questions[_questionIndex];
        }

        private Quiz _quiz;

        /// <summary>
        /// Данные опросника.
        /// </summary>
        public Quiz Quiz
        {
            get { return _quiz; }
            set { Set(ref _quiz, value); }
        }

        private bool _questionMode;

        private int _questionIndex;

        private object _objectToDisplay;

        /// <summary>
        /// Объект, который будет выводиться на форме.
        /// </summary>
        public object ObjectToDisplay
        {
            get { return _objectToDisplay; }
            set { Set(ref _objectToDisplay, value); }
        }

        private void DoPrev()
        {
            _questionIndex -= 1;
            ObjectToDisplay = Quiz.Questions[_questionIndex];
        }

        private void DoExit()
        {
            Environment.Exit(0);
        }

        private void DoShowResult()
        {
        }

        private void DoNext()
        {
            _questionIndex += 1;
            ObjectToDisplay = Quiz.Questions[_questionIndex];
        }

        private bool CanDoNext()
        {
            return _questionIndex < Quiz.Questions.Length - 1;
        }

        private bool CanDoPrev()
        {
            return _questionIndex > 0;
        }

        public ICommand PrevCommand { get; }
        public ICommand NextCommand { get; }
        public ICommand ExitCommand { get; }
        public ICommand ShowResultCommand { get; }
    }
}

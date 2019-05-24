using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using QuizDasha.Entities;
using QuizDasha.Services;
using System;
using System.Linq;
using System.Windows.Input;

namespace QuizDasha
{
    public class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel(QuizReader quizReader)
        {
            ExitCommand = new RelayCommand(DoExit);
            ShowResultCommand = new RelayCommand(DoShowResult);
            NextCommand = new RelayCommand(DoNext, CanDoNext);
            PrevCommand = new RelayCommand(DoPrev, CanDoPrev);

            // Читаем данные опросника.
            Quiz = quizReader.ReadQuiz("quiz.xml");

            ObjectToDisplay = Quiz.Intro;
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

        public bool QuestionMode
        {
            get { return _questionMode; }
            set { Set(ref _questionMode, value); }
        }

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

        private void DoGoToTest()
        {
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
            if (QuestionMode)
            {
                var userResult = new Result();

                foreach (var question in Quiz.Questions)
                    foreach (var option in question.Options)
                    {
                        if (option.IsSelected)
                        {
                            userResult.Score += option.PointWhenSelected;
                        }
                        else
                        {
                            userResult.Score += option.PointWhenNotSelected;
                        }
                    }

                foreach (var quizResult in Quiz.Results.OrderByDescending(r => r.Score))
                    if (userResult.Score > quizResult.Score)
                    {
                        userResult.Text = quizResult.Text;
                        break;
                    }

                QuestionMode = false;
                ObjectToDisplay = userResult;
            }
            else
            {
                _questionIndex = 0;
                ObjectToDisplay = Quiz.Questions[_questionIndex];

                QuestionMode = true;
            }
        }

        private void DoNext()
        {
            _questionIndex += 1;
            ObjectToDisplay = Quiz.Questions[_questionIndex];
        }

        private bool CanDoNext()
        {
            return QuestionMode && _questionIndex < Quiz.Questions.Length - 1;
        }

        private bool CanDoPrev()
        {
            return QuestionMode && _questionIndex > 0;
        }

        public ICommand PrevCommand { get; }
        public ICommand NextCommand { get; }
        public ICommand ExitCommand { get; }
        public ICommand ShowResultCommand { get; }
    }
}

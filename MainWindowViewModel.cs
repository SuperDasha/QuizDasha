using Prism.Commands;
using Prism.Mvvm;
using QuizDasha.Services;
using System;
using System.Windows.Input;

namespace QuizDasha
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IQuizReader _quizDataReader;

        public MainWindowViewModel(IQuizReader quizDataReader)
        {
            _quizDataReader = quizDataReader;
            ExitCommand = new DelegateCommand(DoExit);
        }

        private void DoExit()
        {
            Environment.Exit(0);
        }

        public ICommand ExitCommand { get; }
    }
}

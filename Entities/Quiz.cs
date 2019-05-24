using GalaSoft.MvvmLight;

namespace QuizDasha.Entities
{
    /// <summary>
    /// Базовый класс с данными опросника.
    /// </summary>
    public class Quiz : ObservableObject
    {
        private string _name;

        /// <summary>
        /// Название опросника.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }

        private Question[] _questions;

        /// <summary>
        /// Массив вопросов.
        /// </summary>
        public Question[] Questions
        {
            get { return _questions; }
            set { Set(ref _questions, value); }
        }

        private Result[] _results;

        /// <summary>
        /// Варианты текстов результата с баллами.
        /// </summary>
        public Result[] Results
        {
            get { return _results; }
            set { Set(ref _results, value); }
        }

        private Intro _intro;

        public Intro Intro
        {
            get { return _intro; }
            set { Set(ref _intro, value); }
        }
    }
}

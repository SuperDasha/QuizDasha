using Prism.Mvvm;

namespace QuizDasha.Entities
{
    /// <summary>
    /// Базовый класс с данными опросника.
    /// </summary>
    public class Quiz : BindableBase
    {
        private string _name;

        /// <summary>
        /// Название опросника.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private Question[] _questions;

        /// <summary>
        /// Массив вопросов.
        /// </summary>
        public Question[] Questions
        {
            get { return _questions; }
            set { SetProperty(ref _questions, value); }
        }
    }
}

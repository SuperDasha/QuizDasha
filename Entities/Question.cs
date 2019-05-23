using GalaSoft.MvvmLight;

namespace QuizDasha.Entities
{
    /// <summary>
    /// Вопрос из опросник.
    /// </summary>
    public class Question : ObservableObject
    {
        private Option[] _options;

        /// <summary>
        /// Список (массив) вариантов ответов на вопрос.
        /// </summary>
        public Option[] Options
        {
            get { return _options; }
            set { Set(ref _options, value); }
        }

        private string _text;

        /// <summary>
        /// Текст вопроса.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { Set(ref _text, value); }
        }
    }
}

using Prism.Mvvm;

namespace QuizDasha.Entities
{
    /// <summary>
    /// Вопрос из опросник.
    /// </summary>
    public class Question : BindableBase
    {
        private string _text;

        /// <summary>
        /// Текст вопроса.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}

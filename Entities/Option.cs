using Prism.Mvvm;

namespace QuizDasha.Entities
{
    /// <summary>
    /// Вариант ответа на вопрос опросника.
    /// </summary>
    public class Option : BindableBase
    {
        private string _text;

        /// <summary>
        /// Текст варианта ответа.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        private bool _isSelected;

        /// <summary>
        /// Выбран ли ответ.
        /// </summary>
        public bool IsSelected
        {
            get { return _isSelected; }
            set { SetProperty(ref _isSelected, value); }
        }

        private int _pointwhenselected;

        /// <summary>
        /// Баллы за выбор ответа.
        /// </summary>
        public int PointWhenSelected
        {
            get { return _pointwhenselected; }
            set { SetProperty(ref _pointwhenselected, value); }
        }

        private int _pointwhennotselected;

        /// <summary>
        /// Баллы за невыбор ответа.
        /// </summary>
        public int PointWhenNotSelected
        {
            get { return _pointwhennotselected; }
            set { SetProperty(ref _pointwhennotselected, value); }
        }

    }
}

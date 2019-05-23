using GalaSoft.MvvmLight;

namespace QuizDasha.Entities
{
    /// <summary>
    /// Вариант ответа на вопрос опросника.
    /// </summary>
    public class Option : ObservableObject
    {
        private string _text;

        /// <summary>
        /// Текст варианта ответа.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { Set(ref _text, value); }
        }

        private bool _isSelected;

        /// <summary>
        /// Выбран ли ответ.
        /// </summary>
        public bool IsSelected
        {
            get { return _isSelected; }
            set { Set(ref _isSelected, value); }
        }

        private int _pointWhenSelected;

        /// <summary>
        /// Баллы за выбор ответа.
        /// </summary>
        public int PointWhenSelected
        {
            get { return _pointWhenSelected; }
            set { Set(ref _pointWhenSelected, value); }
        }

        private int _pointWhenNotSelected;

        /// <summary>
        /// Баллы за невыбор ответа.
        /// </summary>
        public int PointWhenNotSelected
        {
            get { return _pointWhenNotSelected; }
            set { Set(ref _pointWhenNotSelected, value); }
        }

    }
}

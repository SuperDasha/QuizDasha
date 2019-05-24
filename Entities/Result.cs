using GalaSoft.MvvmLight;

namespace QuizDasha.Entities
{
    /// <summary>
    /// Результат, показываемый при достижении указанного минимального количества баллов.
    /// </summary>
    public class Result : ObservableObject
    {
        private int _score;

        /// <summary>
        /// Минимальный балл, при котором требуется показать текст.
        /// </summary>
        public int Score
        {
            get { return _score; }
            set { Set(ref _score, value); }
        }

        private string _text;

        /// <summary>
        /// Текст, показываемый если пользователь набрал минимальное кол-во баллов.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { Set(ref _text, value); }
        }
    }
}

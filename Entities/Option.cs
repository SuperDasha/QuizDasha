using Prism.Mvvm;

namespace QuizDasha.Entities
{
    /// <summary>
    /// Вариант ответа на вопрос опросника.
    /// </summary>
    public class Option : BindableBase
    {
        // 1. Текст варианта ответа (Text)
        // 2. Баллы за выбор ответа int (PointsWhenSelected)
        // 2. Баллы за невыбор ответа int (PointsWhenNotSelected)


        private string _options;

        public string Options
        {
            get { return _options; }
            set { SetProperty(ref _options, value); }
        }


        // 1. Текст варианта ответа (Text)
        private string _text;

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }


        // 2. Баллы за выбор ответа int (PointsWhenSelected)
        private int _pointwhenselected;

        public int PointWhenSelected
        {
            get { return _pointwhenselected; }
            set { SetProperty(ref _pointwhenselected, value); }
        }

        // 3. Баллы за невыбор ответа int (PointsWhenNotSelected)
        private int _pointwhennotselected;

        public int PointWhenNotSelected
        {
            get { return _pointwhennotselected; }
            set { SetProperty(ref _pointwhennotselected, value); }
        }

    }
}

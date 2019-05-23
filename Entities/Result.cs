using GalaSoft.MvvmLight;

namespace QuizDasha.Entities
{
    /// <summary>
    /// Результат опросника.
    /// </summary>
    public class Result : ObservableObject
    {
        private string _total;

        public string Total
        {
            get { return _total; }
            set { Set(ref _total, value); }
        } 


    }
}

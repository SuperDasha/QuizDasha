using Prism.Mvvm;

namespace QuizDasha.Entities
{
    /// <summary>
    /// Результат опросника.
    /// </summary>
    public class Result : BindableBase
    {
        private string _total;

        public string Total
        {
            get { return _total; }
            set { SetProperty(ref _total, value); }
        } 


    }
}

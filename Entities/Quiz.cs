using Prism.Mvvm;

namespace QuizDasha.Entities
{
    /// <summary>
    /// Базовый класс с данными опроса.
    /// </summary>
    public class Quiz : BindableBase
    {
        private string _name;

        /// <summary>
        /// Название опроса.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
    }
}

using QuizDasha.Entities;

namespace QuizDasha.Services
{
    /// <summary>
    /// Интерфейс сервиса чтения данных опроса.
    /// </summary>
    public interface IQuizReader
    {
        /// <summary>
        /// Чтение данных опроса из файла.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        /// <returns>Данные опроса.</returns>
        Quiz ReadQuiz(string fileName);
    }
}

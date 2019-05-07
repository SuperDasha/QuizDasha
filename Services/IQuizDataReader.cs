using QuizDasha.Entities;

namespace QuizDasha.Services
{
    /// <summary>
    /// Интерфейс сервиса чтения данных опроса.
    /// </summary>
    public interface IQuizDataReader
    {
        /// <summary>
        /// Чтение данных опроса из файла.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        /// <returns>Данные опроса.</returns>
        QuizData ReadQuizData(string fileName);
    }
}

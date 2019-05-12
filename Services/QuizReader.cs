using QuizDasha.Entities;
using System.IO;
using System.Xml.Serialization;

namespace QuizDasha.Services
{
    /// <summary>
    /// Объект для чтения данных опроса.
    /// </summary>
    public class QuizReader
    {
        /// <summary>
        /// Чтение данных опроса из файла.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        /// <returns>Данные опроса.</returns>
        public Quiz ReadQuiz(string fileName)
        {
            // Объект для чтения XML.
            var xmlSerializer = new XmlSerializer(typeof(Quiz));

            // Открыть файл fileName для чтения.
            var stream = new FileStream(fileName, FileMode.Open);

            // Прочесть из него объект.
            var quiz = (Quiz)xmlSerializer.Deserialize(stream);

            // Закрыть файл.
            stream.Close();

            //Вернуть прочитанный объект.
            return quiz;
        }
    }
}

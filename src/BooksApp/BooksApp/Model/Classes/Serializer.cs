using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Environment;

namespace BooksApp.Model.Classes
{
    public class Serializer
    {
        /// <summary>
        /// Возвращает и задаёт путь, где будут сериализоваться данные.
        /// </summary>
        public static string Path { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя файла.
        /// </summary>
        public static string FileName { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Serializer"/>.
        /// </summary>
        static Serializer()
        {
            Path = $"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}"
                + "/BooksApp/";
            FileName = "data.json";

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="books">Список, который нужно сериализовать.</param>
        public static void Serialize(List<Book> books)
        {
            using StreamWriter writer = new(Path + FileName);
            writer.Write(JsonConvert.SerializeObject(books));
        }

        /// <summary>
        /// Реализует десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию книг.</returns>
        public static List<Book> Deserialize()
        {
            var books = new List<Book>();

            try
            {
                using (StreamReader reader = new(Path + FileName))
                {
                    books = JsonConvert.DeserializeObject<List<Book>>(reader.ReadToEnd());
                }

                if (books == null)
                {
                    books = new List<Book>();
                }
            }

            catch
            {
                return books;
            }

            return books;
        }
    }
}

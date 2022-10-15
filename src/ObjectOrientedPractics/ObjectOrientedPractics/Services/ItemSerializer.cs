using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using ObjectOrientedPractics.Model;
using static System.Environment;

namespace ObjectOrientedPractics.Services
{
    public class ItemSerializer
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
        /// Создаёт экземпляр класса <see cref="ItemSerializer"/>.
        /// </summary>
        static ItemSerializer()
        {
            Path = $"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}"
                + "/ObjectOrientedPractics/";
            FileName = "ItemData.json";

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="books">Список, который нужно сериализовать.</param>
        public static void Serialize(List<Item> items)
        {
            using StreamWriter writer = new(Path + FileName);
            writer.Write(JsonConvert.SerializeObject(items));
        }

        /// <summary>
        /// Реализует десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию книг.</returns>
        public static List<Item> Deserialize()
        {
            var items = new List<Item>();

            try
            {
                using (StreamReader reader = new(Path + FileName))
                {
                    items = JsonConvert.DeserializeObject<List<Item>>(reader.ReadToEnd());
                }

                if (items == null)
                {
                    items = new List<Item>();
                }
            }

            catch
            {
                return items;
            }

            return items;
        }
    }
}

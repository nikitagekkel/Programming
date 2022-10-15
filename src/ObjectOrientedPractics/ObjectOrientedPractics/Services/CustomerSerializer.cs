using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Environment;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует сериализацию и десериализацию
    /// данных класса <see cref="Customer"/>
    /// </summary>
    class CustomerSerializer
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
        /// Создаёт экземпляр класса <see cref="CustomerSerializer"/>.
        /// </summary>
        static CustomerSerializer()
        {
            Path = $"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}"
                + "/ObjectOrientedPractics/";
            FileName = "CustomerData.json";

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="customers">Список, который нужно сериализовать</param>
        public static void Serialize(List<Customer> customers)
        {
            using StreamWriter writer = new(Path + FileName);
            writer.Write(JsonConvert.SerializeObject(customers));
        }

        /// <summary>
        /// Реализует десериализацию данных.
        /// </summary>
        /// <returns>Возвращает список класса
        /// <see cref="Customer"/></returns>
        public static List<Customer> Deserialize()
        {
            var customers = new List<Customer>();

            try
            {
                using (StreamReader reader = new(Path + FileName))
                {
                    customers = JsonConvert.DeserializeObject<List<Customer>>(reader.ReadToEnd());
                }

                if (customers == null)
                {
                    customers = new List<Customer>();
                }
            }

            catch
            {
                return customers;
            }

            return customers;
        }
    }
}

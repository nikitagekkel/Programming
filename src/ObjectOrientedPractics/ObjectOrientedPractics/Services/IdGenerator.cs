namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует генерацию уникального Id
    /// </summary>
    public class IdGenerator
    {
        /// <summary>
        /// Уникальный Id типа int
        /// </summary>
        private static int _id = 0;

        /// <summary>
        /// Добавляет 1 к полю <see cref="_id"/>
        /// при каждом вызове класса
        /// </summary>
        /// <returns>Возвращает уникальный Id</returns>
        public static int GetNextId()
        {
            _id++;
            return _id;
        }
    }
}

using Programming.Model.Classes;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные об учебном предмете.
    /// </summary>
    public class EducationSubject
    {
        /// <summary>
        /// Уникальный идентификатор оценки(рейтинга) за учебный предмет.
        /// </summary>
        private int _educationSubjectRating;

        /// <summary>
        /// Уникальный идентификатор учебного предмета.
        /// </summary>
        public string EducationSubjectName { get; set; }

        /// <summary>
        /// Уникальный индентификатор имени преподавателя.
        /// </summary>
        public string EducationSubjectTeacherName { get; set; }

        /// <summary>
        /// Возвращает и задает оценку(рейтинг) за учебный предмет. Состоит только из положительного числа.
        /// </summary>
        public int EducationSubjectRating
        {
            get
            {
                return _educationSubjectRating;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(EducationSubjectRating), value);
                _educationSubjectRating = value;
            }
        }
    }
}

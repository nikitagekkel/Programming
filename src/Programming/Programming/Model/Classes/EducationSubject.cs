using System;

namespace Programming.Model.Classes
{
    class EducationSubject
    {
        private int _educationSubjectRating;

        public string EducationSubjectName { get; set; }
        public string EducationSubjectTeacherName { get; set; }
        public int EducationSubjectRating
        {
            get
            {
                return _educationSubjectRating;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Error");
                }
                _educationSubjectRating = value;
            }
        }
    }
}

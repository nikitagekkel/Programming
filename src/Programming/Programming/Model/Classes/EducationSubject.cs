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
                Validator.AssertOnPositiveValue(nameof(EducationSubjectRating), value);
                _educationSubjectRating = value;
            }
        }
    }
}

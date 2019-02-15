using System;

namespace StudyListApi.ViewModels
{
    public class StudentInfo
    {
        public long Id { get; set; }

        public string ImagePath { get; set; }

        public string Name { get; set; }

        public string FacultyName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
    }
}

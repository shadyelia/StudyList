using System;
using System.ComponentModel.DataAnnotations;

namespace StudyListApi.ViewModels
{
    public class StudentInfo
    {
        public long Id { get; set; }

        public string ImagePath { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public long FacultyId { get; set; }

        public string FacultyName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        [Required]
        public string Phone { get; set; }

        public int Age { get; set; }
    }
}

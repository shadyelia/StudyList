using Entities.Enum;
using System;

namespace Entities.Entites
{
    public class Student : BaseEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public String Phone { get; set; }

        public String Address { get; set; }

        public string ImagePath { get; set; }

        public Faculty Faculty { get; set; }
    }
}

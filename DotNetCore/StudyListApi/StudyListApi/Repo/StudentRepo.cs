using Entities.Entites;
using StudyListApi.Data;
using StudyListApi.Repo.InterFace;
using StudyListApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudyListApi.Repo
{
    public class StudentRepo : IStudentRepo
    {
        private StudyListDbContext _context;

        public StudentRepo(StudyListDbContext context)
        {
            _context = context;
        }

        public void CreateOrUpdateStudent(StudentInfo StudentInfo)
        {
            if (StudentInfo.Id == 0)
                Create(StudentInfo);
            else
                Update(StudentInfo);
        }

        private void Create(StudentInfo studentInfo)
        {
            Student Student = BindDataForCreateStudent(studentInfo);
            _context.Student.Add(Student);
            _context.SaveChanges();
        }

        private Student BindDataForCreateStudent(StudentInfo studentInfo)
        {
            Student StudentToDB = new Student();
            StudentToDB.Address = studentInfo.Address;
            StudentToDB.DateOfBirth = studentInfo.DateOfBirth;
            StudentToDB.FacultyId = studentInfo.FacultyId;
            StudentToDB.FacultyName = _context.Faculty.Find(studentInfo.FacultyId).Name;
            StudentToDB.ImagePath = studentInfo.ImagePath;
            StudentToDB.Name = studentInfo.Name;
            StudentToDB.Phone = studentInfo.Phone;
            StudentToDB.CreatedAt = DateTime.Now;

            return StudentToDB;
        }

        private void Update(StudentInfo studentInfo)
        {
            Student Student = BindDataForUpdateStudent(studentInfo);
            _context.Student.Update(Student);
            _context.SaveChanges();
        }

        private Student BindDataForUpdateStudent(StudentInfo studentInfo)
        {
            Student StudentToDB = _context.Student.Find(studentInfo.Id);
            StudentToDB.Address = studentInfo.Address;
            StudentToDB.DateOfBirth = studentInfo.DateOfBirth;
            StudentToDB.FacultyId = studentInfo.FacultyId;
            StudentToDB.FacultyName = _context.Faculty.Find(studentInfo.FacultyId).Name;
            StudentToDB.ImagePath = studentInfo.ImagePath;
            StudentToDB.Name = studentInfo.Name;
            StudentToDB.Phone = studentInfo.Phone;
            StudentToDB.ModifiedAt = DateTime.Now;

            return StudentToDB;

        }

        public void DeleteStudent(long id)
        {
            var Student = _context.Student.Find(id);
            Student.IsDeleted = true;
            _context.Update(Student);
            _context.SaveChanges();
        }

        public List<StudentInfo> GetAllStudents()
        {
            var Students = _context.Student.Where(Student => Student.IsDeleted != true);
            List<StudentInfo> OutputList = BindStudentsDataForOutput(Students);
            return OutputList;
        }

        private List<StudentInfo> BindStudentsDataForOutput(IQueryable<Student> Students)
        {
            List<StudentInfo> ListOfStudents = new List<StudentInfo>();

            foreach (var Student in Students)
            {
                StudentInfo StudentObject = new StudentInfo();

                StudentObject.Address = Student.Address;
                StudentObject.DateOfBirth = Student.DateOfBirth;
                StudentObject.FacultyId = Student.FacultyId;
                StudentObject.FacultyName = Student.FacultyName;
                StudentObject.Id = Student.Id;
                StudentObject.ImagePath = Student.ImagePath;
                StudentObject.Name = Student.Name;
                StudentObject.Phone = Student.Phone;

                ListOfStudents.Add(StudentObject);
            }

            return ListOfStudents;
        }

        public StudentInfo GetStudentInfo(long id)
        {
            var Student = _context.Student.Find(id);

            return BindStudentInforForOutpuut(Student);
        }

        private StudentInfo BindStudentInforForOutpuut(Student Student)
        {
            StudentInfo StudentObject = new StudentInfo();

            StudentObject.Address = Student.Address;
            StudentObject.DateOfBirth = Student.DateOfBirth;
            StudentObject.FacultyId = Student.FacultyId;
            StudentObject.FacultyName = Student.FacultyName;
            StudentObject.Id = Student.Id;
            StudentObject.ImagePath = Student.ImagePath;
            StudentObject.Name = Student.Name;
            StudentObject.Phone = Student.Phone;
            return StudentObject;
        }

        public List<FacultyVM> GetAllFaculties()
        {
            var Faculties = _context.Faculty.ToList();

            return BindDataForGetAllFaculties(Faculties);
        }

        private List<FacultyVM> BindDataForGetAllFaculties(List<Faculty> Faculties)
        {
            List<FacultyVM> OutputFaculties = new List<FacultyVM>();

            foreach(var Faculty in Faculties)
            {
                FacultyVM FacultyObject = new FacultyVM();
                FacultyObject.Id = Faculty.Id;
                FacultyObject.Name = Faculty.Name;
                OutputFaculties.Add(FacultyObject);
            }

            return OutputFaculties;
        }

    }
}

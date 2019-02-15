using StudyListApi.ViewModels;
using System.Collections.Generic;

namespace StudyListApi.Repo.InterFace
{
    public interface IStudentRepo
    {
        void CreateOrUpdateStudent(StudentInfo StudentInfo);

        StudentInfo GetStudentInfo(long id);

        List<StudentInfo> GetAllStudent();

        void DeleteStudent(long id);
    }
}

using StudyListApi.Repo.InterFace;
using StudyListApi.ViewModels;
using System.Collections.Generic;

namespace StudyListApi.Business.Student
{
    public class GetAllStudentsAction : BizActionBase
    {
        public List<StudentInfo> Students { get; set; }

        private readonly IStudentRepo StudentRepo;

        public GetAllStudentsAction(IStudentRepo studentRepo)
        {
            StudentRepo = studentRepo;
        }

        public override void DoAction()
        {
            this.Students = this.StudentRepo.GetAllStudent();
        }

        public override void DoValidate()
        {
        }
    }
}

using StudyListApi.Repo.InterFace;
using StudyListApi.ViewModels;

namespace StudyListApi.Business.Student
{
    public class CreateOrUpdateStudentAction : BizActionBase
    {
        private readonly StudentInfo StudentInfo;

        private readonly IStudentRepo StudentRepo;

        public CreateOrUpdateStudentAction(StudentInfo studentInfo, IStudentRepo studentRepo)
        {
            StudentInfo = studentInfo;
            StudentRepo = studentRepo;
        }

        public override void DoValidate()
        {
            this.StudentRepo.CreateOrUpdateStudent(StudentInfo);
        }

        public override void DoAction()
        {
        }
    }
}

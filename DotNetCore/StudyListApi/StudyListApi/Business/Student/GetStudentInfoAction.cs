using StudyListApi.Repo.InterFace;
using StudyListApi.ViewModels;

namespace StudyListApi.Business.Student
{
    public class GetStudentInfoAction : BizActionBase
    {
        private  long StudentId { get; set; }

        public StudentInfo Student { get; set; }

        private readonly IStudentRepo StudentRepo;

        public GetStudentInfoAction(long studentId, IStudentRepo studentRepo)
        {
            StudentId = studentId;
            StudentRepo = studentRepo;
        }

        public override void DoAction()
        {
            this.Student = this.StudentRepo.GetStudentInfo(this.StudentId);
        }

        public override void DoValidate()
        {
        }
    }
}

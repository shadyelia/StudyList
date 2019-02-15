using StudyListApi.Repo.InterFace;

namespace StudyListApi.Business.Student
{
    public class DeleteStudentAction : BizActionBase
    {
        public long StudentId;

        private readonly IStudentRepo StudentRepo;

        public DeleteStudentAction(long studentId, IStudentRepo studentRepo)
        {
            StudentId = studentId;
            StudentRepo = studentRepo;
        }

        public override void DoAction()
        {
            this.StudentRepo.DeleteStudent(this.StudentId);
        }

        public override void DoValidate()
        {
        }
    }
}

using StudyListApi.Repo.InterFace;

namespace StudyListApi.Business.Student
{
    public class DeleteStudentAction : BizActionBase
    {
        public long StudentId;

        private readonly IStudentRepo StudentRepo;

        public override void DoAction()
        {
            this.StudentRepo.DeleteStudent(this.StudentId);
        }

        public override void DoValidate()
        {
        }
    }
}

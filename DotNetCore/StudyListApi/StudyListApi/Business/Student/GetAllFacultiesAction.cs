using StudyListApi.Repo.InterFace;
using StudyListApi.ViewModels;
using System.Collections.Generic;

namespace StudyListApi.Business.Student
{
    public class GetAllFacultiesAction : BizActionBase
    {
        public List<FacultyVM> Faculties { get; set; }

        private readonly IStudentRepo StudentRepo;

        public GetAllFacultiesAction(IStudentRepo studentRepo)
        {
            StudentRepo = studentRepo;
        }

        public override void DoAction()
        {
            this.Faculties = this.StudentRepo.GetAllFaculties();
        }

        public override void DoValidate()
        {
        }
    }
}

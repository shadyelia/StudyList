using Microsoft.AspNetCore.Mvc;
using StudyListApi.Business.Student;
using StudyListApi.Repo.InterFace;
using StudyListApi.ViewModels;

namespace StudyListApi.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepo StudentRepo;

        public StudentsController(IStudentRepo studentRepo)
        {
            StudentRepo = studentRepo;
        }

        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents ()
        {
            GetAllStudentsAction getAllStudentsAction = new GetAllStudentsAction(this.StudentRepo);
            getAllStudentsAction.Execute();
            return Ok(getAllStudentsAction.Students);
        }

        [HttpPost("DeleteStudent")]
        public IActionResult DeleteStudent([FromBody]long StudentId)
        {
            DeleteStudentAction deleteStudentAction = new DeleteStudentAction(StudentId, this.StudentRepo);
            deleteStudentAction.Execute();
            return Ok();
        }

        [HttpGet("GetStudentInfo")]
        public IActionResult GetStudentInfo([FromBody]long StudentId)
        {
            GetStudentInfoAction getStudentInfoAction = new GetStudentInfoAction(StudentId, this.StudentRepo);
            getStudentInfoAction.Execute();
            return Ok(getStudentInfoAction.Student);
        }

        [HttpPost("CreateOrUpdateStudent")]
        public IActionResult CreateOrUpdateStudent([FromBody]StudentInfo StudentInfo)
        {
            CreateOrUpdateStudentAction createOrUpdateStudentAction = new CreateOrUpdateStudentAction(StudentInfo, this.StudentRepo);
            createOrUpdateStudentAction.Execute();
            return Ok();
        }
    }
}

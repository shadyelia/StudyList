using Microsoft.AspNetCore.Mvc;
using StudyListApi.Business.Student;
using StudyListApi.Repo.InterFace;
using StudyListApi.ViewModels;
using System;

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

        [HttpGet("GetAllFaulties")]
        public IActionResult GetAllFaulties()
        {
            try
            {
                GetAllFacultiesAction getAllFacultiesAction = new GetAllFacultiesAction(this.StudentRepo);
                getAllFacultiesAction.Execute();
                return Ok(getAllFacultiesAction.Faculties);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            try
            {
                GetAllStudentsAction getAllStudentsAction = new GetAllStudentsAction(this.StudentRepo);
                getAllStudentsAction.Execute();
                return Ok(getAllStudentsAction.Students);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpPost("DeleteStudent/{StudentId}")]
        public IActionResult DeleteStudent(long StudentId)
        {
            try
            {
                DeleteStudentAction deleteStudentAction = new DeleteStudentAction(StudentId, this.StudentRepo);
                deleteStudentAction.Execute();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            
        }

        [HttpGet("GetStudentInfo/{StudentId}")]
        public IActionResult GetStudentInfo(long StudentId)
        {
            try
            {
                GetStudentInfoAction getStudentInfoAction = new GetStudentInfoAction(StudentId, this.StudentRepo);
                getStudentInfoAction.Execute();
                return Ok(getStudentInfoAction.Student);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CreateOrUpdateStudent")]
        public IActionResult CreateOrUpdateStudent([FromBody]StudentInfo StudentInfo)
        {
            try
            {
                CreateOrUpdateStudentAction createOrUpdateStudentAction = new CreateOrUpdateStudentAction(StudentInfo, this.StudentRepo);
                createOrUpdateStudentAction.Execute();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
    }
}

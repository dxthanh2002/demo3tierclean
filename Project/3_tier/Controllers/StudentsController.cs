using BLL.LogicService;
using BOL.CE;
using BOL.DBE;
using Microsoft.AspNetCore.Mvc;

namespace _3_tier.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentsLogic _studentLogic;
        public StudentsController(IStudentsLogic studentLogic)
        {
            this._studentLogic = studentLogic;
        }

        [HttpGet]
        public IActionResult StudentList()
        {
            // main module

            StudentModule model = new StudentModule();
            

            //-- get student list--//
            model.studentsList = _studentLogic.GetStudentListLogic().ToList();
            return View(model);
        }
    }
}

using BOL.DBE;
using DAL.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.LogicService
{
    public class StudentsLogic : IStudentsLogic
    {
        public readonly IStudentsDataDAL _studentsDataDAL;
        public StudentsLogic(IStudentsDataDAL studentsDataDAL)
        {
            this._studentsDataDAL = studentsDataDAL;
        }
        public List<Students> GetStudentListLogic() {
            List<Students> result = new List<Students>();
            result = _studentsDataDAL.GetStudentsListDAL();
            return result;
        }
    }
}

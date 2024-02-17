using BOL.DBE;
using DAL.DataContext;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataService
{
    public class StudentsDataDAL : IStudentsDataDAL
    {
        private readonly IDapperOrmHelper _dapperOrmHelper;
        public StudentsDataDAL(IDapperOrmHelper dapperOrmHelper) {
        this._dapperOrmHelper = dapperOrmHelper;
                }
        public List<Students> GetStudentsListDAL()
        { 
            List <Students> students = new List<Students>();

            try
            { 
                using (IDbConnection dbConnection = _dapperOrmHelper.GetDapperContextHelper())
                {
                    string SqlQuery = "Select * FROM Students";
                    students = dbConnection.Query<Students>(SqlQuery,commandType : CommandType.Text).ToList();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            return students;
        }
        
    }
}

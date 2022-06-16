using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO_QLSinhVien;
using DAL_QLSinhVien;

namespace BLL_QLSinhVien
{
    public class StudentBLL
    {
        #region Attributes

        StudentDAL studentDAL = new StudentDAL();

        #endregion

        #region Methods

        public StudentBLL()
        {
        }

        public List<StudentDTO> getStudentList()
        {
            return studentDAL.readFile("../../../Data/StudentList.xml");
        }
        
        #endregion

    }
}

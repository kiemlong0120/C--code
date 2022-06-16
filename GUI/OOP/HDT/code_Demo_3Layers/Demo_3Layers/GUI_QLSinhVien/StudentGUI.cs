using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO_QLSinhVien;
using BLL_QLSinhVien;

namespace GUI_QLSinhVien
{
    public class StudentGUI
    {
        #region Attributes

        StudentBLL studentBLL = new StudentBLL();

        #endregion

        #region Methods
        public void showStudentList()
        {
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            try
            {
                Console.WriteLine("\t\t\t\t\t\tSTUDENT LIST");
                string kq = "StudentID\tFull name\t\t\tPhone\t\tE-mail\t\t\tAverage Score";
                Console.WriteLine(kq);

                List<StudentDTO> lstStudent = new List<StudentDTO>();
                lstStudent = studentBLL.getStudentList();

                foreach (StudentDTO st in lstStudent)
                {
                    Console.WriteLine(st.toString());
                }
            }
            catch (Exception e)
            {
            }
        }
        #endregion
    }
}


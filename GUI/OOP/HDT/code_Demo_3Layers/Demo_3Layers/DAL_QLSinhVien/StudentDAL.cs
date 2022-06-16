using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using DTO_QLSinhVien;

namespace DAL_QLSinhVien
{
    public class StudentDAL
    {
        #region Attributes

        List<StudentDTO> _lstStudent = new List<StudentDTO>();

        #endregion

        #region Methods

        public StudentDAL()
        {
        }

        internal List<StudentDTO> lstStudent
        {
            get { return _lstStudent; }
            set { _lstStudent = value; }
        }

        public List<StudentDTO> readFile(string fileName)
        {
            //Thiết lập để hiển thị tiếng việt trên cửa sổ Console.          
            Console.InputEncoding = UnicodeEncoding.Unicode;
            try
            {
                XmlDocument read = new XmlDocument();
                read.Load(fileName);
                XmlNodeList nodeList = read.SelectNodes("StudentList/Student");
                foreach (XmlNode node in nodeList)
                {
                    //Mỗi node chứa thông tin của một sinh viên
                    StudentDTO st = new StudentDTO();
                    st.StudentID = node["StudentID"].InnerText;
                    st.FirstName = node["FirstName"].InnerText;
                    st.LastName = node["LastName"].InnerText;
                    st.Phone = node["Phone"].InnerText;
                    st.Email = node["Email"].InnerText;
                    st.AverageScore = double.Parse(node["AverageScore"].InnerText);
                    lstStudent.Add(st); //Thêm st vào danh sách
                }
                return lstStudent;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion
    }
}

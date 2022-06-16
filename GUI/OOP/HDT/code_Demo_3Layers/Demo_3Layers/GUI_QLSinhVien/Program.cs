using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_QLSinhVien
{
    class Program
    {
        public static void testStudentList()
        {
            StudentGUI studentGUI = new StudentGUI();
            studentGUI.showStudentList();

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            testStudentList();
        }
    }
}

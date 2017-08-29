using Domain.PCyP.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.PCyP.BLL
{
   public static class StudentBusiness
    {
        private static List<Student> _studentList = new List<Student>();
        public static void Add(Student estudiante)
        {
            _studentList.Add(estudiante);
        }

        public static List<Student> GetStudentList()
        {
            return _studentList;
        }
    }
}

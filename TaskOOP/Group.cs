using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP
{
    public class Group
    {
        public string GroupNo { get; set; }
        private int _studentlimit { get; set; }
        public int StudentLimit
        {
            get => _studentlimit;
            set
            {
                if (value >= 5)
                {
                    _studentlimit = value;
                }
                else
                {
                    Console.WriteLine("Minimum Student limit must be 5!");
                }
                if (value <= 18)
                {
                    _studentlimit = value;
                    ;
                }
                else
                {
                    Console.WriteLine("Maximum Student limit must be 18!");
                }


            }
        }
        private Student[] Students;
        private int _studentCount = 0;
        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            Students = new Student[studentLimit];
        }
        public bool CheckGroupNo()
        {
            if (GroupNo.Length != 5)
            {
                return false;
            }

            return
            char.IsUpper(GroupNo[0]) &&
            char.IsUpper(GroupNo[1]) &&
            char.IsDigit(GroupNo[2]) &&
            char.IsDigit(GroupNo[3]) &&
            char.IsDigit(GroupNo[4]);
        }
        public bool AddStudent(Student student)
        {
            if (_studentCount < StudentLimit)
            {
                Students[_studentCount] = student;
                _studentCount++;
                return true;
            }
            return false;
        }
        public Student GetStudent(int id)
        {
            foreach (var student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                }

            }
            return null;
        }
        public void ShowAllStudents()
        {
            foreach (var student in Students)
            {
                if (student != null)
                {
                    student.StudentInfo();
                }
            }
        }
    }

}

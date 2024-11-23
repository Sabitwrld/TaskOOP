using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP
{
    public class Student : User
    {
        private double _point { get; set; }
        public double Point
        {
            get => _point;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _point = value;
                }
                else
                {
                    Console.WriteLine("Your Points must be between 0 and 100.");
                }
            }
        }
        public Student(string fullname, string email, string password, double point)
            : base(fullname, email, password)
        {
            Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Email: {Email}, Point: {Point}");
        }

    }
}


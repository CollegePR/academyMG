using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample
{
    class Student
    {
        string Name;
        int StudentID;
        bool Sex;
        string Phone, Address, BirthDay;
        string School;
        int Grade, SchoolClass;
        string Admission, ReAdmission, Leaving, Lecture;

        public Student(string Name,int StudentID,bool Sex,string Phone,string Address,string School,int Grade,int SchoolClass,string
Admission, string ReAdmission, string Leaving, string Lecture, string BirthDay){
            this.Name = Name;
            this.StudentID = StudentID;
            this.Sex = Sex;
            this.Phone = Phone; this.Address = Address; this.BirthDay = BirthDay;
            this.School = School; this.Grade = Grade; this.SchoolClass = SchoolClass;

            this.Admission = Admission; this.ReAdmission=ReAdmission; this.Leaving=Leaving;
            this.Lecture = Lecture;
        }
    }
}

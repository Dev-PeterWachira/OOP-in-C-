using System;
using System.Collections.Generic;
namespace Moringa

{
    public class Student
    {
        private string studentName;

        private int age;
        private int student_id;
        private int list_of_courses;

        private Course course;

        public virtual void Describe()
        {
            Console.WriteLine("I am a student named" + studentName);
        }

        public Course GetCourse()
        {
            return course;
        }
        public void SetCourse(Course course)
        {
            this.course = course;
        }



        public string GetStudentName()
        {
            return studentName;
        }
        public void SetStudentName(string studentName)
        {
            this.studentName = studentName;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetStudent_id()
        {
            return student_id;
        }

        public void SetStudent_id(int student_id)
        {
            this.student_id = student_id;
        }

        public int GetList_of_courses()
        {
            return list_of_courses;
        }

        public void SetList_of_courses(int list_of_courses)
        {
            this.list_of_courses = list_of_courses;
        }
    }




    public class Course
    {
        private string courseName;
        private int courseCode;
        private string instructorName;

        public string GetCourseName()
        {
            return courseName;
        }

        public void SetCourseName(string courseName)
        {
            this.courseName = courseName;
        }

        public int GetCourseCode()
        {
            return courseCode;
        }

        public void SetCourseCode(int courseCode)
        {
            this.courseCode = courseCode;
        }

        public string GetInstructorName()
        {
            return instructorName;
        }

        public void SetInstructorName(string instructorName)
        {
            this.instructorName = instructorName;
        }
    }


    public class GraduateStudent : Student
    {
        private string researchTopic;

        public string GetResearchTopic()
        {
            return researchTopic;
        }

        public void SetResearchTopic(string researchTopic)
        {
            this.researchTopic = researchTopic;
        }

        public override void Describe()
        {
            Console.WriteLine("I am a graduate student named " + GetStudentName() + "researching" + GetResearchTopic() );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GraduateStudent graduateStudent = new GraduateStudent();
            graduateStudent.SetStudentName("Alice");
            graduateStudent.SetAge(26);
            graduateStudent.SetStudent_id(5678);
            graduateStudent.SetResearchTopic("Machine learning in Healthcare");
            graduateStudent.Describe();



            Course course1 = new Course();
            course1.SetCourseName("Data science");
            course1.SetInstructorName("Dr.Smith");

            graduateStudent.SetCourse(course1);

            Console.WriteLine("Graduate student Name:" + graduateStudent.GetStudentName());
            Console.WriteLine("Age :" + graduateStudent.GetAge());
            Console.WriteLine("ID :" + graduateStudent.GetStudent_id());
            Console.WriteLine("Course" + graduateStudent.GetCourse().GetCourseName());
            Console.WriteLine("Instructor :" + course1.GetInstructorName());
            Console.WriteLine("Research Topic :" + graduateStudent.GetResearchTopic());


            

        }
    }
}
    
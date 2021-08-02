using System;

namespace SpecialCasePattern
{
    public class UsageOfSpecialCasePattern
    {

        public static void Run()
        {
            RunNormal();
            RunSpecialCase();
        }

        private static void RunNormal()
        {
            IStudent student = GetStudent();
            string userInfo = student.GetUserInfo();
            Console.WriteLine(userInfo);
        }

        private static void RunSpecialCase()
        {
            IStudent student = GetSpecialCaseStudent();
            string userInfo = student.GetUserInfo();
            Console.WriteLine(userInfo);
        }
        

        private static IStudent GetStudent()
        {
            var student =  new Student()
            {
                Id = 1,
                Name = "Caner"
            };
            
            return student;
        }

        private static IStudent GetSpecialCaseStudent()
        {
            var student = default(Student);

            if(student == null)
                return new StudentNotFound();
            
            return student;
        }
    }
}
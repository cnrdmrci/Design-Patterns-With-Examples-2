using System;

namespace NullObjectPattern
{
    public class UsageOfNullObjectPattern
    {

        public static void Run()
        {
            RunWithValue();
            RunWithNullValue();
        }

        private static void RunWithValue()
        {
            AbstractStudent abstractStudent = GetStudent();
            string userInfo = abstractStudent.GetUserInfo();
            Console.WriteLine(userInfo);
        }

        private static void RunWithNullValue()
        {
            AbstractStudent abstractStudent = GetNullStudent();
            string userInfo = abstractStudent.GetUserInfo();
            Console.WriteLine(userInfo);
        }
        

        private static AbstractStudent GetStudent()
        {
            var student =  new Student()
            {
                Id = 1,
                Name = "Caner"
            };
            return student.GetValue();
        }

        private static AbstractStudent GetNullStudent()
        {
            var student = default(Student);
            return student.GetValue();
        }
    }
}
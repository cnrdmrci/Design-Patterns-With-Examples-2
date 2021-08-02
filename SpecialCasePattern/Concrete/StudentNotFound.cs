namespace SpecialCasePattern
{
    public class StudentNotFound : IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string GetUserInfo()
        {
            return "Student not found.";
        }
    }
}
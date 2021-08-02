namespace SpecialCasePattern
{
    public class Student : IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GetUserInfo()
        {
            return Id + " - " + Name; 
        }
    }
}
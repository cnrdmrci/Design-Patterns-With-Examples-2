namespace NullObjectPattern
{
    public class Student : AbstractStudent
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string GetUserInfo()
        {
            return Id + ", " + Name; 
        }
    }
}
namespace NullObjectPattern
{
    public abstract class AbstractStudent
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string GetUserInfo();
    }
}
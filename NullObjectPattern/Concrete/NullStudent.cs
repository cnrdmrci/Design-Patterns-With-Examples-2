namespace NullObjectPattern
{
    public class NullStudent : AbstractStudent
    {
        public override int Id { get; set; }
        public override string Name { get; set; } = string.Empty;
        public override string GetUserInfo()
        {
            return string.Empty;
        }
    }
}
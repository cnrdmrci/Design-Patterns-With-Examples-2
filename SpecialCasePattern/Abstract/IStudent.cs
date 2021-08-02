namespace SpecialCasePattern
{
    public interface IStudent
    {
        int Id { get; set; }
        string Name { get; set; }
        string GetUserInfo();
    }
}
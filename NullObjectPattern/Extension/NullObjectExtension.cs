namespace NullObjectPattern
{
    public static class NullObjectExtension
    {
        public static AbstractStudent GetValue(this AbstractStudent abstractValue)
        {
            return abstractValue ?? new NullStudent();
        }
    }
}
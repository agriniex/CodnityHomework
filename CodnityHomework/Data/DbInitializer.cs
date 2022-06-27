namespace CodnityHomework.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ToDoContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}

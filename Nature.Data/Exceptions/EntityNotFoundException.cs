namespace Nature.Data.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string? message) : base(message)
        {
        }
    }
}

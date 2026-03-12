namespace Conclase9.ClassFeb272027.CustomExceptions
{
    [Serializable]
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) 
            : base(message) { }

        public NotFoundException(string message, Exception inner) 
            : base(message, inner)
        {
            
        }
    }
}
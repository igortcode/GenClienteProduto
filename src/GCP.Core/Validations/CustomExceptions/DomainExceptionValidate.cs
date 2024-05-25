namespace GCP.Core.Validations.CustomExceptions
{
    public class DomainExceptionValidate : Exception
    {
        public DomainExceptionValidate(string message) : base(message) { }

        public static void When(bool condition, string message) 
        { 
            if(condition) 
                throw new DomainExceptionValidate(message);
        }
    }
}

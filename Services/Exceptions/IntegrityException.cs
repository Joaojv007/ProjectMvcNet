using System;
namespace ProjectMvcNet.Services.Exceptions
{
    public class IntegrityException: ApplicationException
    {
        public IntegrityException(string message) : base(message)
        { 
        } 
    }
}

using System;


namespace SalesWeb_MVC.Services.Exceptions
{
    public class IntegrityException: ApplicationException
    {
        public IntegrityException(string message) :base (message)
        {
        }
    }
}

using System;

namespace SalesWebApp.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException (string message) : base (message)
        {

        }
    }
}
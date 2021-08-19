using System;
using SalesWebMvc.Services.Exceptions;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}

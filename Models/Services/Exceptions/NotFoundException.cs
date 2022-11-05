using System.Data;

namespace WebServiceMVC.Models.Services.Exceptions;

public class NotFoundException : ApplicationException
{
    public NotFoundException(string message) : base(message)
    {
    }
    
}
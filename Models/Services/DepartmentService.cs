using WebServiceMVC.Data;

namespace WebServiceMVC.Models.Services;

public class DepartmentService
{
    private readonly WebServiceMVCContext _context;
    public DepartmentService(WebServiceMVCContext context)
    {
        _context = context;
    }

    public List<Department> FindAll()
    {
        return _context.Department.OrderBy(x => x.Name).ToList();
    }
}
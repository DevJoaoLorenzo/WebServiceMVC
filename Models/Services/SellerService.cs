using WebServiceMVC.Data;

namespace WebServiceMVC.Models.Services;

public class SellerService
{
    private readonly WebServiceMVCContext _context;

    public SellerService(WebServiceMVCContext context)
    {
        _context = context;
    }

    public List<Seller> FindAll()
    {
        return _context.Seller.ToList();
    }

    public void Insert(Seller obj) //adicionar no banco de daddos
    {
        obj.Department = _context.Department.First();
        _context.Add(obj);
        _context.SaveChanges();
    }
}
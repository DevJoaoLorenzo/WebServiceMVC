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
        _context.Add(obj);
        _context.SaveChanges();
    }

    public Seller FindById(int id)
    {
        return _context.Seller.FirstOrDefault(obj => obj.Id == id);
    }

    public void Remove(int id)
    {
        var obj = _context.Seller.Find(id);
        _context.Seller.Remove(obj);
        _context.SaveChanges();
    }
}
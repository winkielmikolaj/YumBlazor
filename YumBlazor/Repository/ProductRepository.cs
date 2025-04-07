using Microsoft.EntityFrameworkCore;
using YumBlazor.Data;
using YumBlazor.Repository.IRepository;

namespace YumBlazor.Repository;

public class ProductRepository(ApplicationDbContext db) : IProductRepository
{
    public async Task<Product> CreateAsync(Product obj)
    {
        await db.Products.AddAsync(obj);
        await db.SaveChangesAsync();
        return obj;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var obj = await db.Products.FirstOrDefaultAsync(u => u.Id == id);

        if (obj != null)
        {
            db.Products.Remove(obj);
            return await (db.SaveChangesAsync()) > 0;
        }
        return false;
    }

    public async Task<Product> GetAsync(int id)
    {
        var obj = db.Products.FirstOrDefault(u => u.Id == id);
        if (obj == null)
        {
            return new Product();
        }
        return obj;
    }

    public async Task<Product> UpdateAsync(Product obj)
    {
        var objFromDb = await db.Products.FirstOrDefaultAsync(u => u.Id == obj.Id);
        if (objFromDb != null)
        {
            objFromDb.Name = obj.Name;
            objFromDb.Description = obj.Description;
            objFromDb.Price = obj.Price;
            objFromDb.CategoryId = obj.CategoryId;
            objFromDb.ImageUrl = obj.ImageUrl;
            db.Products.Update(objFromDb);
            await db.SaveChangesAsync();
            return objFromDb;
        }
        return obj;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await db.Products.Include(p => p.Category).ToListAsync();
    }
}
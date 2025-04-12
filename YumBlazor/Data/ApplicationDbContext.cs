using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YumBlazor.Components.Pages.Cart_Pages;

namespace YumBlazor.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    public DbSet<ShoppingCart> ShoppingCart { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<OrderHeader> OrderHeaders { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Apetizer" },
            new Category { Id = 2, Name = "Entree" },
            new Category { Id = 3, Name = "Desser" }
        );
    }
}
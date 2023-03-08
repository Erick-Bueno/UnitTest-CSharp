using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<productModel> products {get; set;}


    protected override void OnModelCreating(ModelBuilder model){
        model.ApplyConfiguration(new productMap());
        base.OnModelCreating(model);
    }
}
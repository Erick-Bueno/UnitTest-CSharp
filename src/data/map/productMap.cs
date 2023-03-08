using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class productMap : IEntityTypeConfiguration<productModel>
{
    public void Configure(EntityTypeBuilder<productModel> builder)
    {
        builder.HasKey(p => p.id);
        builder.Property(p => p.productName).IsRequired().HasMaxLength(200);
        builder.Property(p => p.productQuantity).IsRequired();
    }
}

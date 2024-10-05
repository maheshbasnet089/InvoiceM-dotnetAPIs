

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class InvoiceItemConfiguration:IEntityTypeConfiguration<InvoiceItem>{
    public void Configure(EntityTypeBuilder<InvoiceItem> builder){
        builder.ToTable("InvoiceItems"); 
        builder.Property(p=>p.Id).HasColumnName(nameof(InvoiceItem.Id)); 
        builder.Property(p=>p.Name).HasColumnName(nameof(InvoiceItem.Name)).HasMaxLength(64).IsRequired(); 
        builder.Property(p=>p.Description).HasColumnName(nameof(InvoiceItem.Description)).HasMaxLength(256); 
        builder.Property(p=>p.UnitPrice).HasColumnName(nameof(InvoiceItem.UnitPrice)).HasPrecision(8,2); 
        builder.Property(p=>p.Amount).HasColumnName(nameof(InvoiceItem.Amount)).HasPrecision(18,2); 
        builder.Property(p=>p.InvoiceId).HasColumnName(nameof(InvoiceItem.InvoiceId));
    }
}
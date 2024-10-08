

using EfCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Data; 



public class InvoiceDbContext(DbContextOptions<InvoiceDbContext> options): DbContext(options){
    public DbSet<Invoice> Invoices => Set<Invoice>(); 
    public DbSet<Invoicess> Invoicesses => Set<Invoicess>(); 
    public DbSet<InvoiceItem> InvoiceItems => Set<InvoiceItem>();
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ConfigureInvoice();
        // modelBuilder.Entity<Invoice>().HasData(
        //     new Invoice{
        //         Id = Guid.NewGuid(), 
        //         InvoiceNumber = "INV-001", 
        //         ContactName = "Manish Basnet",
        //         Description  = "Invoice for first month", 
        //         Amount = 100,
        //         InvoiceDate  = new DateTimeOffset(2023,1,1,0,0,0,TimeSpan.Zero),
        //         DueDate = new DateTimeOffset(2023,1,15,0,0,0,TimeSpan.Zero),
        //         Status = InvoiceStatus.AwaitPayment
        //     }
    
        // modelBuilder.ApplyConfigurationsFromAssembly(typeof(InvoiceDbContext).Assembly);
    }



}


using EfCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Data; 

public class InvoiceDbContext(DbContextOptions<InvoiceDbContext> options): DbContext(options){
    public DbSet<Invoice> Invoices => Set<Invoice>(); 
}
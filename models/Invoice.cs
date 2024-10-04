
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EfCore.Models; 

public class Invoice{
    public Guid Id{get;set;}
    public string InvoiceNumber{get;set;} = string.Empty; 
    public string ContactName{get;set;} = string.Empty; 
    public string? Description {get;set;}
    public decimal Amount {get;set;}
    public DateTimeOffset DueDate{get;set;}
    public InvoiceStatus Status{get;set;}
    public DateTimeOffset InvoiceDate{get;set;}
    
}

[Table("Invoicess")]
public class Invoicess{
    [Column("Id")]
    [Key]
    public Guid Id{get;set;}
    
    [Column(name:"InvoiceNumber", TypeName ="varchar(32)")]
    [Required]
    public string InvoiceNumber {get;set;} = string.Empty;

    [Column(name:"ContactName")]
    [Required]
    [MaxLength(32)]
    public string ContactName{get;set;} = string.Empty;

    [Column(name:"Description")]
    [MaxLengthAttribute(256)] 
    public string? Description {get;set;}

    [Column("Amount")]
    [Precision(18,2)]
    [Range(0,999999999.99)]
    public decimal Amount{get;set;}
    
    [Column(name:"InvoiceDate", TypeName ="datetimeoffset")]
    public DateTimeOffset InvoiceDate{get;set;}

    [Column(name:"DueDate", TypeName ="datetimeoffset")]
    public DateTimeOffset DueDate{get;set;}

}

public enum InvoiceStatus{
    Draft, 
    AwaitPayment, 
    Paid, 
    Overdeu, 
    Cancelled
}
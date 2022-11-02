using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CustomerModule.Data
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public int? ContactNumber { get; set; }
        [Column(TypeName = "date")]
        public DateTime? RegisteredDate { get; set; }
    }
}

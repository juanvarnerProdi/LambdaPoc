using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaAPI.Models
{
    [Table("Items")]
    public class Item
    {
        [Column("ItemId")]
        [Key]
        [Required]
        public int ItemId { get; set; }

        [Column("ItemName")]
        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }
    }
}

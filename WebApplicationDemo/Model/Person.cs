using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDemo.Model
{
    [Table("person")]
    public class Person
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [StringLength(50)]
        [Column("name")]
        public string Name { get; set; }

        [Column("age")]
        public int Age { get; set; }
    }
}

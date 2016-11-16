using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_Assignment.Models
{
    [Table ("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        [ForeignKey("sport")]
        public int Sport { get; set; }
        public virtual Sport sport { get; set; }
        public ICollection<Sport> sports { get; set; }
    }
}
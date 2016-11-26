using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_Assignment.Models
{
    [Table("Article")]
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }

        public DateTime datePublish { get; set; }

        public int SportID { get; set; }
        [ForeignKey("SportID")]
        public Sport sport { get; set; }

    }
}
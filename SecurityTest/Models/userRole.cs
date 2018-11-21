using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SecurityTest.Models
{
    public class userRole
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        [Required]
        public string UserRole { get; set; }
        [Required]
        public int userID { get; set; }

        public virtual user user { get; set; }
    }
}
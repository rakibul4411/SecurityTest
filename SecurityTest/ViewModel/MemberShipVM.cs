using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityTest.ViewModel
{
    public class MemberShipVM
    {
        [Required]
        public int ID { get; set; }
        [StringLength(50, MinimumLength =6, ErrorMessage ="User Name at least be 6 character")]
        public string UserName { get; set; }
        [StringLength(50, MinimumLength = 6, ErrorMessage = "User Name at least be 6 character")]
        public string Password { get; set; }
    }
}
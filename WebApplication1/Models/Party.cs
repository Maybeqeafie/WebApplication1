using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Party
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MinLength(2, ErrorMessage = "Name not valid")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MinLength(1, ErrorMessage = "Name not valid")]
        public string Status { get; set; }

        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        [MinLength(9, ErrorMessage = "Number not valid")]
        public String Number { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MinLength(2, ErrorMessage = "Name not valid")]
        public String Text { get; set; }
    }
}
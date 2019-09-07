using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ItinaryItem
    {
        [Required(ErrorMessage = "You must specify when the event will occur")]
        public DateTime? When { get; set; }
        [Required(ErrorMessage = "You must enter a description")]
        [MaxLength(5, ErrorMessage = "Must be less tham 5  characters")]
        public string Description { get; set; }
        public int? Duration { get; set; }
        public bool isActive { get; set; }
        public bool? Confirmed { get; set; }
    }
}
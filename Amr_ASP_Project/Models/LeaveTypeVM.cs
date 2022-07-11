using System;
using System.ComponentModel.DataAnnotations;

namespace Amr_ASP_Project.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Date Created")]

        public DateTime? DateCreated { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Default no of Days")]
        [Required]
        [Range(1, 25, ErrorMessage ="Please enter a vaild Number")]
        public int DefaultDays { get; set; }
    }
}

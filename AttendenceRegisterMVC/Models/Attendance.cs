using Microsoft.AspNetCore.Mvc.Rendering;

namespace AttendenceRegisterMVC.Models
{
    public class Attendance
    {
        public string SelectedOption { get; set; }
        public List<SelectListItem> attendance { get; set; }
    }
}

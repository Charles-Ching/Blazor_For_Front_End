using System;
using System.ComponentModel.DataAnnotations;

namespace EventEase.Data
{
    public class AttendanceTrackerModel
    {
        [Required(ErrorMessage = "Attendant name is required")]
        public string? AttendantName { get; set; }

        [Required(ErrorMessage = "Event name is required")]
        public string? EventName { get; set; }

        [Required(ErrorMessage = "Event date is required")]
        public DateTime EventDate { get; set; }

        [Required(ErrorMessage = "Event location is required")]
        public string? EventLocation { get; set; }

        [Required(ErrorMessage = "Attendance status is required")]
        public bool Attended { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
namespace EventEase.Data
{
    public class EventCardModel
    {
        [Required(ErrorMessage = "Event name is required")]
        public string? EventName { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string? Location { get; set; }
    }
}
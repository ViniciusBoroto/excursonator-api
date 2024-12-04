using Microsoft.EntityFrameworkCore;

namespace ExcursonatorAPI.Models.Entities
{
    public class Excursion
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime ReturnDate { get; set; }
        public string PicUrl { get; set; } = "https://www.flaticon.com/free-icon/image_739249";
        public required String Local { get; set; }

        public string Title {get;set}

        public string Theme {get;set}

        public string Description {get;set}

        public Itinerary {get;set}

        public ImageUrl {get;set}
    }

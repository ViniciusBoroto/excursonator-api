namespace ExcursonatorAPI.Models.Entities
{
    public class Excursion
    {
        public required int Id { get; set; }
        public String? Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime ReturnDate { get; set; }

        public required String Local { get; set; }
    }
}

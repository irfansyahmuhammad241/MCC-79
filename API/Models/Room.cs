namespace API.Models
{
    public class Room
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Floor { get; set; }
        public string Capacity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

namespace move.Models
{
    public class mooove 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string img { get; set; }
        public int time { get; set; }
        public int date { get; set; }
        public int categuryId { get; set; }

        public ICollection<mooove> categuries { get; set; } = new List<mooove>();

    }
}     

namespace simple_crud.Models
{
    public class Disc
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public string Color { get; set; }

        public int Speed { get; set; }

        public int Glide { get; set; }

        public sbyte Turn { get; set; }

        public int Fade { get; set; }
    }
}

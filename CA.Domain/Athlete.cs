namespace CA.Domain
{
    public class Athlete
    {
        public Athlete()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public DateTime Birthday { get; set; }
        public int Height { get; set; }
        public string Position { get; set; }
        public string VideoLink { get; set; }
        public bool LeftFooted { get; set; }

        public void SetId(Guid id)
        {
            Id = id;
        }
    }
}

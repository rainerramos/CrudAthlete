using System.ComponentModel.DataAnnotations;

namespace CA.Domain
{
    public class Athlete
    {
        public Athlete()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        public int Height { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string VideoLink { get; set; }

        [Required]
        public bool LeftFooted { get; set; }

        public void SetId(Guid id)
        {
            Id = id;
        }
    }
}

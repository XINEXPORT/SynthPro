using System.ComponentModel.DataAnnotations.Schema;

namespace SynthPro.Models
{
    public class Synth
    {
        public int SynthID { get; set; }

        public string ModelNumber { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        public DateTime ReleaseDate { get; set; } = DateTime.Now;

    }
}

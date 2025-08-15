using System.ComponentModel.DataAnnotations;

namespace WebPhim.Models
{
    public class Country
    {
        [Key]
        [StringLength(20)]
        public required string CountryID {  get; set; }

        [StringLength(100)]
        public required string CountryName { get; set; }

        [StringLength(10)]
        public string ISOCode {  get; set; } = string.Empty;

        //Navigation:
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}

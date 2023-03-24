using System.ComponentModel.DataAnnotations.Schema;


namespace CodeFirstApproachWithOneToMany
{
    public class DirectorAddress
    {
        [ForeignKey("DirectorModel")]
        public int DirectorAddressId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public virtual DirectorModel DirectorModel { get; set; }
    }
}

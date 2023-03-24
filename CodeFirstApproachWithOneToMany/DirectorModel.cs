using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproachWithOneToMany
{
    public class DirectorModel
    {
        [Key]
        public int DirectorId { get; set; }
        public string DirectorName { get; set; }

        //public virtual DirectorAddress Address { get; set; }

        public ICollection<MovieModel> movieModels { get; set; }
    }
}

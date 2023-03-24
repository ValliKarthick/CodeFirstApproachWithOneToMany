using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproachWithOneToMany
{
    public class MovieModel
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieName {get; set;}
        public string MovieGenre { get; set; }
        public int DirectorId { get; set; }
        public DirectorModel directorModel { get; set; }    
       // public ICollection<DirectorModel> directorModels { get; set; }
    }
}

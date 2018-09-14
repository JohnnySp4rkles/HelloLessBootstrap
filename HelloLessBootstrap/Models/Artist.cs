using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HelloLessBootstrap.Models
{
    public class Artist
    {
        [Key]
        public int ArtistID { get; set; }

        [Display(Name = "Band Name")]
        public string Title { get; set; }

        //Relationships!
        public int AlbumID { get; set; }

        public virtual List<Album> Albums { get; set; }
    }
}
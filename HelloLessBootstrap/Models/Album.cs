using System.ComponentModel.DataAnnotations;

namespace HelloLessBootstrap.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }

        [Display(Name = "Album Title")]
        public string Title { get; set; }

        [Display(Name = "# Tracks")]
        public int NoOfTracks { get; set; }

        //Relationship with artist
        public int ArtistID { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
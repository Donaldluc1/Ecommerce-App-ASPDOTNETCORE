using HomeCine.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeCine.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; } 

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile picture is Required")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "FullName is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}

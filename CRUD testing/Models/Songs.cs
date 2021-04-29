using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_testing.Models
{
    public class Songs
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string songName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string songAlbum { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string songArtist { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Upload File")]
        public string imageName { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile songImage { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public Songs()
        {

        }
    }
}

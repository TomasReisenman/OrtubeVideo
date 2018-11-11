using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practice1.Models
{
    public class Video

    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public string VideoUrl { get; set; }

        public Usuario UsuarioID { get; set; }

        public virtual Usuario Usuario { get; set; }

    }

    public class VideoDBContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}
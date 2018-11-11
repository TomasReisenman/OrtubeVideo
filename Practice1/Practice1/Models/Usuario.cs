using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Practice1.Models
{
    public class Usuario
    {

        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Video> Videos { get; set; }

    }

    public class UsuarioDBContext : DbContext
    {
        public DbSet<Usuario> Videos { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GyT.Data.Entity
{
    public class Entity
    {
        public Entity()
        {
            FechaCreacion = DateTime.UtcNow;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}

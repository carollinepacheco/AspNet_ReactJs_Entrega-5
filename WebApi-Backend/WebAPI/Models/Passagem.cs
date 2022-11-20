using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("passagens")]
    public class Passagem
    {
        [Required, Key, Column("id")]
        public int Id { get; set; }

        [Required, Column("destino",TypeName = "VARCHAR(255)")] 
        public string? Destino { get; set; }

        [Required, Column("data", TypeName = "VARCHAR(20)")]     
        public string? Data { get; set; }

        [Required, Column("horario",TypeName = "VARCHAR(20)")]
        public string? Horario { get; set; }

    }
}

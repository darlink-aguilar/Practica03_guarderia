using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica03_guarderia.Nucleo
{
    public class Profesores
    {
        [Key] public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public DateTime FechaContratacion { get; set; }
        public bool Activa { get; set; }
        public int IdSucursal { get; set;}

        [ForeignKey ("IdSucursal")] public Sucursales? Sucursales { get; set; }

    }
}
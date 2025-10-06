using System.ComponentModel.DataAnnotations;

namespace Practica03_guarderia.Nucleo
{
    public class Sucursales
    {
        [Key] public int Id { get; set; }
        public decimal Tamaño { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public DateTime FechaFundacion { get; set; }
        public bool Activa { get; set; }

    }
}
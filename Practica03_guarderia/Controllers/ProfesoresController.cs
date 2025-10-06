using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using parcial;
using Practica03_guarderia.Nucleo;

namespace Practica03_guarderia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfesoresController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Profesores> Get()
        {
            var Conexion = new Conexion();
            Conexion.StringConnection = "server=DESKTOP-RSS9QMM\\DEV;database=Practica03_guarderia;Integrated Security=True;TrustServerCertificate=true";
            Conexion.Database.Migrate();
            Conexion!.Profesores!.Add(new Profesores()
            {
                Nombre = "Darlink",
                Edad = 19,
                FechaContratacion = DateTime.Now,
                Activa = true,
                IdSucursal = 1
            }
            );

            Conexion!.Profesores!.Add(new Profesores()
            {
                Nombre = "Juan",
                Edad = 19,
                FechaContratacion = DateTime.Now,
                Activa = false,
                IdSucursal = 2
            }
            );

            Conexion!.SaveChanges();
            return Conexion!.Profesores!.ToList();
            //return new List<Profesores>();

        }
    }
}
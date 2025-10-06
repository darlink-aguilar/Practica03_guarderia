using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using parcial;
using Practica03_guarderia.Nucleo;

namespace Practica03_guarderia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SucursalesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Sucursales> Get()
        {
            var Conexion = new Conexion();
            Conexion.StringConnection = "server=DESKTOP-RSS9QMM\\DEV;database=Practica03_guarderia;Integrated Security=True;TrustServerCertificate=true";
            Conexion.Database.Migrate();
            Conexion!.Sucursales!.Add(new Sucursales()
            {
                Tamaño = 245.34m,
                Nombre = "Guarderia de los niños",
                Direccion = "Calle 36A #102A" + DateTime.Now,
                FechaFundacion = DateTime.Now,
                Activa = true,

            }
            );

            Conexion!.SaveChanges();
            return Conexion!.Sucursales!.ToList();
            //return new List<Sucursales>();

        }
    }
}

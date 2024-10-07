using InmobiliariaServicio.Clases;
using InmobiliariaServicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace InmobiliariaServicio.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Ciudades")]
    public class CiudadesController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public CIUDAD Consultar(int codigo)
        {
            clsCiudad ciudad = new clsCiudad();
            return ciudad.Consultar(codigo);
        }
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] CIUDAD ciudad)
        {
            clsCiudad _ciudad = new clsCiudad();
            _ciudad.ciudad = ciudad;
            return _ciudad.Insertar();
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] CIUDAD ciudad)
        {
            clsCiudad _ciudad = new clsCiudad();
            _ciudad.ciudad = ciudad;
            return _ciudad.Actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] CIUDAD ciudad)
        {
            clsCiudad _ciudad = new clsCiudad();
            _ciudad.ciudad = ciudad;
            return _ciudad.Eliminar();
        }
    }
}
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
    [RoutePrefix("api/Propiedades")]
    public class PropiedadesController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public PROPIEDAD Consultar(int codigo)
        {
            clsPropiedad prop = new clsPropiedad();
            return prop.Consultar(codigo);
        }
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] PROPIEDAD prop)
        {
            clsPropiedad _prop = new clsPropiedad();
            _prop.prop = prop;
            return _prop.Insertar();
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] PROPIEDAD prop)
        {
            clsPropiedad _prop = new clsPropiedad();
            _prop.prop = prop;
            return _prop.Actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] PROPIEDAD prop)
        {
            clsPropiedad _prop = new clsPropiedad();
            _prop.prop = prop;
            return _prop.Eliminar();
        }
    }
}
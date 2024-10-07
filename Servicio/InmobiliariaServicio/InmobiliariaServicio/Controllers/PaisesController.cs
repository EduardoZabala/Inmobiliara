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
    [RoutePrefix("api/Paises")]
    public class PaisesController : ApiController
    {
        [HttpGet]
        [Route("Consultar")]
        public PAI Consultar(int codigo)
        {
            clsPais pais = new clsPais();
            return pais.Consultar(codigo);
        }
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] PAI pais)
        {
            clsPais _pais = new clsPais();
            _pais.pais = pais;
            return _pais.Insertar();
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] PAI pais)
        {
            clsPais _pais = new clsPais();
            _pais.pais = pais;
            return _pais.Actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] PAI pais)
        {
            clsPais _pais = new clsPais();
            _pais.pais = pais;
            return _pais.Eliminar();
        }
        [HttpGet]
        [Route("LlenarTabla")]
        public IQueryable LlenarTabla()
        {
            clsPais pais = new clsPais();
            return pais.LlenarTabla();
        }
    }
}
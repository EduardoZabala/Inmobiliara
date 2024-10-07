using InmobiliariaServicio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace InmobiliariaServicio.Clases
{
    public class clsPais
    {
        INMOBILIARIAEntities DbIn = new INMOBILIARIAEntities();

        public PAI pais = new PAI();

        public string Insertar()
        {
            try
            {
                DbIn.PAIS.Add(pais);
                DbIn.SaveChanges();
                return "Se agregó el país: " + pais.NombrePais;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                PAI _pais = Consultar(pais.ID);
                if (_pais != null)
                {
                    DbIn.PAIS.AddOrUpdate(pais);
                    DbIn.SaveChanges();
                    return "Se actualizaron los datos del país: " + pais.NombrePais;
                }
                return "No existe el país";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string Eliminar()
        {
            try
            {
                PAI _pais = Consultar(pais.ID);
                if (_pais != null)
                {
                    DbIn.PAIS.Remove(_pais);
                    DbIn.SaveChanges();
                    return "Se eliminó el país: " + _pais.NombrePais;
                }
                return "El país no existe";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public IQueryable LlenarTabla()
        {
            //En SQL la instrucción es SELECT - FROM - WHERE
            //En linq la instrucción es FROM - WHERE - SELECT
            return from P in DbIn.Set<PAI>()
                   select new //Finalmente, se presentan los campos que se van a mostrar
                   {
                       Pais_id = P.ID,
                       Pais_Nombre = P.NombrePais
                   };
        }
        public PAI Consultar(int codigo)
        {
            return DbIn.PAIS.FirstOrDefault(p => p.ID == codigo);
        }

    }
}
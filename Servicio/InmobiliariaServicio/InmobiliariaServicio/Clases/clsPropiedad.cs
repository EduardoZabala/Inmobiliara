using InmobiliariaServicio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace InmobiliariaServicio.Clases
{
    public class clsPropiedad
    {
        INMOBILIARIAEntities DbIn = new INMOBILIARIAEntities();

        public PROPIEDAD prop = new PROPIEDAD();
        public string Insertar()
        {
            try
            {
                DbIn.PROPIEDADs.Add(prop);
                DbIn.SaveChanges();
                return "Se agregó la propiedad con la dirección: " + prop.Direccion;
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
                PROPIEDAD _prop = Consultar(prop.ID);
                if (_prop != null)
                {
                    DbIn.PROPIEDADs.AddOrUpdate(prop);
                    DbIn.SaveChanges();
                    return "Se actualizaron los datos de la propiedad con dirección: " + prop.Direccion;
                }
                return "No existe la propiedad";

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
                PROPIEDAD _prop = Consultar(prop.ID);
                if (_prop != null)
                {
                    DbIn.PROPIEDADs.Remove(_prop);
                    DbIn.SaveChanges();
                    return "Se eliminó la propiedad con dirección: " + _prop.Direccion;
                }
                return "La propiedad no existe";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public PROPIEDAD Consultar(int codigo)
        {
            return DbIn.PROPIEDADs.FirstOrDefault(p => p.ID == codigo);
        }

    }
}
using InmobiliariaServicio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace InmobiliariaServicio.Clases
{
    public class clsCiudad
    {
        INMOBILIARIAEntities DbIn = new INMOBILIARIAEntities();

        public CIUDAD ciudad = new CIUDAD();
        public string Insertar()
        {
            try
            {
                DbIn.CIUDADs.Add(ciudad);
                DbIn.SaveChanges();
                return "Se agregó la ciudad: " + ciudad.NombreCiudad;
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
                CIUDAD _ciudad = Consultar(ciudad.ID);
                if (_ciudad != null)
                {
                    DbIn.CIUDADs.AddOrUpdate(ciudad);
                    DbIn.SaveChanges();
                    return "Se actualizaron los datos de la ciudad: " + ciudad.NombreCiudad;
                }
                return "No existe la ciudad";

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
                CIUDAD _ciudad = Consultar(ciudad.ID);
                if (_ciudad != null)
                {
                    DbIn.CIUDADs.Remove(_ciudad);
                    DbIn.SaveChanges();
                    return "Se eliminó la ciudad: " + _ciudad.NombreCiudad;
                }
                return "La ciudad no existe";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public CIUDAD Consultar(int codigo)
        {
            return DbIn.CIUDADs.FirstOrDefault(c => c.ID == codigo);
        }

    }
}
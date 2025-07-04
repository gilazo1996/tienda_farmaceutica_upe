using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class FarmacoBLL
    {
        private FarmacoDAL dal = new FarmacoDAL();

        public Farmaco ObtenerFarmacoPorCodigo(string codigo)
        {
            // Aquí puedes agregar validaciones o lógica de negocio si es necesario
            return dal.ObtenerFarmacoPorCodigo(codigo);
        }

        public bool EliminarFarmaco(string codigoInventario)
        {
            try
            {
                // Validaciones de negocio
                if (string.IsNullOrEmpty(codigoInventario))
                {
                    throw new ArgumentException("El código de inventario no puede estar vacío.");
                }

                // Verificar que el fármaco existe
                var farmaco = dal.ObtenerFarmacoPorCodigo(codigoInventario);
                if (farmaco == null)
                {
                    throw new Exception("El fármaco no existe.");
                }

                // Llamar al método de eliminación en la DAL
                return dal.EliminarFarmaco(codigoInventario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la lógica de negocio al eliminar fármaco: " + ex.Message);
            }
        }

        public bool ActualizarFarmaco(Farmaco farmaco)
        {
            try
            {
                // Validaciones de negocio
                if (farmaco == null)
                {
                    throw new ArgumentException("El fármaco no puede ser nulo.");
                }

                if (string.IsNullOrEmpty(farmaco.CodigoInventario))
                {
                    throw new ArgumentException("El código de inventario es obligatorio.");
                }

                if (string.IsNullOrEmpty(farmaco.NombreComercial))
                {
                    throw new ArgumentException("El nombre comercial es obligatorio.");
                }

                if (farmaco.PrecioUnidad <= 0)
                {
                    throw new ArgumentException("El precio debe ser mayor a cero.");
                }

                if (farmaco.Stock < 0)
                {
                    throw new ArgumentException("El stock no puede ser negativo.");
                }

                // Llamar al método de actualización en la DAL
                return dal.ActualizarFarmaco(farmaco);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la lógica de negocio al actualizar fármaco: " + ex.Message);
            }
        }
    }
}

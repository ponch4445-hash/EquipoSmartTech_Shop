using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech_Shop
{
    // Clase que representa una orden
    public class Orden
    {
        // Atributos de la orden
        public int IdOrden { get; set; }
        public string Cliente { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }
        public string Fecha { get; set; }
        public string Estado { get; set; }

        // Constructor para inicializar los datos
        public Orden(int idOrden, string cliente, string descripcion, int cantidad, double precio, double total, string fecha, string estado)
        {
            IdOrden = idOrden;
            Cliente = cliente;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            Total = total;
            Fecha = fecha;
            Estado = estado;
        }

        // Método ToString para mostrar información básica
        public override string ToString()
        {
            return "Orden de " + Cliente;
        }
    }
}
